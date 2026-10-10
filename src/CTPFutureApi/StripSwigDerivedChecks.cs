using System.Text;

return await SwigTransformer.RunAsync(args);

static class SwigTransformer
{
    public static async Task<int> RunAsync(string[] args)
    {
        if (args.Length == 0 || args.Contains("--help", StringComparer.Ordinal))
        {
            PrintUsage();
            return args.Length == 0 ? 1 : 0;
        }

        var createBackup = !args.Contains("--no-backup", StringComparer.Ordinal);
        var targets = args.Where(static x => !x.StartsWith("--", StringComparison.Ordinal)).ToArray();

        if (targets.Length == 0)
        {
            Console.Error.WriteLine("错误：没有指定要处理的文件或目录。");
            return 1;
        }

        var files = new SortedSet<string>(StringComparer.Ordinal);
        foreach (var target in targets)
        {
            if (File.Exists(target))
            {
                files.Add(Path.GetFullPath(target));
            }
            else if (Directory.Exists(target))
            {
                foreach (var file in Directory.EnumerateFiles(target, "*.cs", SearchOption.AllDirectories))
                    files.Add(Path.GetFullPath(file));
            }
            else
            {
                Console.Error.WriteLine($"警告：路径不存在，已跳过：{target}");
            }
        }

        if (files.Count == 0)
        {
            Console.Error.WriteLine("错误：没有找到可处理的 .cs 文件。");
            return 1;
        }

        var changedCount = 0;
        var failedCount = 0;

        foreach (var file in files)
        {
            try
            {
                var original = await File.ReadAllTextAsync(file, Encoding.UTF8);
                var transformed = Transform(original);

                if (transformed == original)
                {
                    Console.WriteLine($"未变化：{file}");
                    continue;
                }

                if (createBackup)
                {
                    var backup = file + ".bak";
                    if (!File.Exists(backup))
                        File.Copy(file, backup);
                }

                await File.WriteAllTextAsync(file, transformed, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
                Console.WriteLine($"已转换：{file}");
                changedCount++;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"处理失败：{file}\n  {ex.Message}");
                failedCount++;
            }
        }

        Console.WriteLine($"完成：转换 {changedCount} 个，失败 {failedCount} 个，总计 {files.Count} 个。");
        return failedCount == 0 ? 0 : 2;
    }

    private static string Transform(string source)
    {
        source = RemoveMethod(source, "SwigDerivedClassHasMethod");
        source = EmptyPublicVirtualVoidMethods(source);
        source = RemoveDirectorConnectGuards(source);
        return source;
    }

    private static string RemoveMethod(string source, string methodName)
    {
        var searchFrom = 0;
        while (true)
        {
            var nameIndex = FindIdentifier(source, methodName, searchFrom);
            if (nameIndex < 0)
                return source;

            var openParen = SkipTriviaForward(source, nameIndex + methodName.Length);
            if (openParen >= source.Length || source[openParen] != '(')
            {
                searchFrom = nameIndex + methodName.Length;
                continue;
            }

            var closeParen = FindMatchingDelimiter(source, openParen, '(', ')');
            if (closeParen < 0)
                throw new InvalidDataException($"无法匹配方法 {methodName} 的参数括号。");

            var openBrace = SkipTriviaForward(source, closeParen + 1);
            if (openBrace >= source.Length || source[openBrace] != '{')
            {
                searchFrom = closeParen + 1;
                continue;
            }

            var closeBrace = FindMatchingDelimiter(source, openBrace, '{', '}');
            if (closeBrace < 0)
                throw new InvalidDataException($"无法匹配方法 {methodName} 的方法体。");

            var lineStart = FindLineStart(source, nameIndex);
            var removalStart = lineStart;
            var removalEnd = ConsumeFollowingBlankLine(source, closeBrace + 1);
            source = source.Remove(removalStart, removalEnd - removalStart);
            searchFrom = removalStart;
        }
    }

    private static string EmptyPublicVirtualVoidMethods(string source)
    {
        const string marker = "public virtual void";
        var searchFrom = 0;

        while (true)
        {
            var markerIndex = FindPhraseOutsideTrivia(source, marker, searchFrom);
            if (markerIndex < 0)
                return source;

            var openParen = source.IndexOf('(', markerIndex + marker.Length);
            if (openParen < 0)
                return source;

            var closeParen = FindMatchingDelimiter(source, openParen, '(', ')');
            if (closeParen < 0)
                throw new InvalidDataException("无法匹配 public virtual void 方法的参数括号。");

            var openBrace = SkipTriviaForward(source, closeParen + 1);
            if (openBrace >= source.Length || source[openBrace] != '{')
            {
                searchFrom = closeParen + 1;
                continue;
            }

            var closeBrace = FindMatchingDelimiter(source, openBrace, '{', '}');
            if (closeBrace < 0)
                throw new InvalidDataException("无法匹配 public virtual void 方法体。");

            var newline = DetectNewLine(source);
            var indent = GetLineIndent(source, markerIndex);
            var replacement = "{" + newline + indent + "}";
            source = source[..openBrace] + replacement + source[(closeBrace + 1)..];
            searchFrom = openBrace + replacement.Length;
        }
    }

    private static string RemoveDirectorConnectGuards(string source)
    {
        var searchFrom = 0;
        var openBrace = -1;

        while (true)
        {
            var methodIndex = FindIdentifier(source, "SwigDirectorConnect", searchFrom);
            if (methodIndex < 0)
                return source;

            var openParen = SkipTriviaForward(source, methodIndex + "SwigDirectorConnect".Length);
            if (openParen >= source.Length || source[openParen] != '(')
            {
                searchFrom = methodIndex + "SwigDirectorConnect".Length;
                continue;
            }

            var closeParen = FindMatchingDelimiter(source, openParen, '(', ')');
            if (closeParen < 0)
                throw new InvalidDataException("无法匹配 SwigDirectorConnect 的参数括号。");

            openBrace = SkipTriviaForward(source, closeParen + 1);
            if (openBrace < source.Length && source[openBrace] == '{')
                break;

            searchFrom = closeParen + 1;
        }

        var closeBrace = FindMatchingDelimiter(source, openBrace, '{', '}');
        if (closeBrace < 0)
            throw new InvalidDataException("无法匹配 SwigDirectorConnect 方法体。");

        var body = source[(openBrace + 1)..closeBrace];
        var lines = SplitLinesKeepingEndings(body);
        var output = new StringBuilder(body.Length);

        for (var i = 0; i < lines.Count; i++)
        {
            var line = lines[i];
            var trimmed = line.Content.Trim();

            if (trimmed.StartsWith("if (SwigDerivedClassHasMethod(", StringComparison.Ordinal))
            {
                if (i + 1 >= lines.Count)
                    throw new InvalidDataException("SwigDirectorConnect 中的 if 后缺少委托赋值语句。");

                var next = lines[++i];
                var assignment = next.Content.TrimStart();
                var ifIndent = line.Content[..(line.Content.Length - line.Content.TrimStart().Length)];
                output.Append(ifIndent).Append(assignment).Append(next.LineEnding);
                continue;
            }

            output.Append(line.Content).Append(line.LineEnding);
        }

        return source[..(openBrace + 1)] + output + source[closeBrace..];
    }

    private static int FindIdentifier(string text, string identifier, int startIndex)
    {
        var index = startIndex;
        while ((index = text.IndexOf(identifier, index, StringComparison.Ordinal)) >= 0)
        {
            if (!IsInsideCommentOrString(text, index) && (index == 0 || !IsIdentifierChar(text[index - 1])) && (index + identifier.Length == text.Length || !IsIdentifierChar(text[index + identifier.Length])))
                return index;

            index += identifier.Length;
        }

        return -1;
    }

    private static int FindPhraseOutsideTrivia(string text, string phrase, int startIndex)
    {
        var index = startIndex;
        while ((index = text.IndexOf(phrase, index, StringComparison.Ordinal)) >= 0)
        {
            if (!IsInsideCommentOrString(text, index))
                return index;
            index += phrase.Length;
        }
        return -1;
    }

    private static int FindMatchingDelimiter(string text, int openIndex, char open, char close)
    {
        var depth = 0;
        var state = LexState.Code;

        for (var i = openIndex; i < text.Length; i++)
        {
            var c = text[i];
            var next = i + 1 < text.Length ? text[i + 1] : '\0';

            switch (state)
            {
                case LexState.Code:
                    if (c == '/' && next == '/')
                    {
                        state = LexState.LineComment;
                        i++;
                        continue;
                    }
                    if (c == '/' && next == '*')
                    {
                        state = LexState.BlockComment;
                        i++;
                        continue;
                    }
                    if (c == '"')
                    {
                        state = LexState.String;
                        continue;
                    }
                    if (c == '\'')
                    {
                        state = LexState.Char;
                        continue;
                    }
                    if (c == open)
                        depth++;
                    else if (c == close && --depth == 0)
                        return i;
                    break;

                case LexState.LineComment:
                    if (c is '\r' or '\n')
                        state = LexState.Code;
                    break;

                case LexState.BlockComment:
                    if (c == '*' && next == '/')
                    {
                        state = LexState.Code;
                        i++;
                    }
                    break;

                case LexState.String:
                    if (c == '\\')
                        i++;
                    else if (c == '"')
                        state = LexState.Code;
                    break;

                case LexState.Char:
                    if (c == '\\')
                        i++;
                    else if (c == '\'')
                        state = LexState.Code;
                    break;
            }
        }

        return -1;
    }

    private static bool IsInsideCommentOrString(string text, int position)
    {
        var state = LexState.Code;
        for (var i = 0; i < position; i++)
        {
            var c = text[i];
            var next = i + 1 < position ? text[i + 1] : '\0';
            switch (state)
            {
                case LexState.Code:
                    if (c == '/' && next == '/')
                    {
                        state = LexState.LineComment;
                        i++;
                    }
                    else if (c == '/' && next == '*')
                    {
                        state = LexState.BlockComment;
                        i++;
                    }
                    else if (c == '"')
                        state = LexState.String;
                    else if (c == '\'')
                        state = LexState.Char;
                    break;
                case LexState.LineComment:
                    if (c is '\r' or '\n')
                        state = LexState.Code;
                    break;
                case LexState.BlockComment:
                    if (c == '*' && next == '/')
                    {
                        state = LexState.Code;
                        i++;
                    }
                    break;
                case LexState.String:
                    if (c == '\\')
                        i++;
                    else if (c == '"')
                        state = LexState.Code;
                    break;
                case LexState.Char:
                    if (c == '\\')
                        i++;
                    else if (c == '\'')
                        state = LexState.Code;
                    break;
            }
        }
        return state != LexState.Code;
    }

    private static int SkipTriviaForward(string text, int index)
    {
        while (index < text.Length)
        {
            if (char.IsWhiteSpace(text[index]))
            {
                index++;
                continue;
            }
            if (index + 1 < text.Length && text[index] == '/' && text[index + 1] == '/')
            {
                index += 2;
                while (index < text.Length && text[index] is not ('\r' or '\n'))
                    index++;
                continue;
            }
            if (index + 1 < text.Length && text[index] == '/' && text[index + 1] == '*')
            {
                var end = text.IndexOf("*/", index + 2, StringComparison.Ordinal);
                if (end < 0)
                    return text.Length;
                index = end + 2;
                continue;
            }
            break;
        }
        return index;
    }

    private static int FindLineStart(string text, int index)
    {
        while (index > 0 && text[index - 1] is not ('\r' or '\n'))
            index--;
        return index;
    }

    private static int ConsumeFollowingBlankLine(string text, int index)
    {
        if (index < text.Length && text[index] == '\r')
            index++;
        if (index < text.Length && text[index] == '\n')
            index++;

        var probe = index;
        while (probe < text.Length && text[probe] is ' ' or '\t')
            probe++;
        if (probe < text.Length && text[probe] == '\r')
            probe++;
        if (probe < text.Length && text[probe] == '\n')
            return probe + 1;
        return index;
    }

    private static string GetLineIndent(string text, int index)
    {
        var lineStart = FindLineStart(text, index);
        var i = lineStart;
        while (i < text.Length && text[i] is ' ' or '\t')
            i++;
        return text[lineStart..i];
    }

    private static string DetectNewLine(string text) => text.Contains("\r\n", StringComparison.Ordinal) ? "\r\n" : "\n";

    private static bool IsIdentifierChar(char c) => char.IsLetterOrDigit(c) || c == '_';

    private static List<LinePart> SplitLinesKeepingEndings(string text)
    {
        var result = new List<LinePart>();
        var start = 0;
        for (var i = 0; i < text.Length; i++)
        {
            if (text[i] == '\r' && i + 1 < text.Length && text[i + 1] == '\n')
            {
                result.Add(new LinePart(text[start..i], "\r\n"));
                start = ++i + 1;
            }
            else if (text[i] == '\n')
            {
                result.Add(new LinePart(text[start..i], "\n"));
                start = i + 1;
            }
        }
        if (start < text.Length)
            result.Add(new LinePart(text[start..], ""));
        return result;
    }

    private static void PrintUsage()
    {
        Console.WriteLine(
            """
用法：
  dotnet StripSwigDerivedChecks.cs -- <文件或目录> [更多路径] [--no-backup]

示例：
  dotnet StripSwigDerivedChecks.cs -- CThostFtdcMdSpi.cs
  dotnet StripSwigDerivedChecks.cs -- ./generated
  dotnet StripSwigDerivedChecks.cs -- ./generated --no-backup

默认行为：
  - 递归处理目录中的所有 .cs 文件
  - 首次修改文件时创建同名 .bak 备份
  - 清空 public virtual void 方法体
  - 删除 SwigDerivedClassHasMethod 方法
  - 去掉 SwigDirectorConnect 中相关的 if 判断，但保留委托绑定
"""
        );
    }

    private enum LexState
    {
        Code,
        LineComment,
        BlockComment,
        String,
        Char,
    }

    private readonly record struct LinePart(string Content, string LineEnding);
}
