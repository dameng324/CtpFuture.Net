using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CtpFuture;

/// <summary>
///
/// </summary>
public static class SwigStringHelper
{
    private delegate string SwigStringDelegate(IntPtr message);

    private static readonly SwigStringDelegate StringDelegate = CreateString;

    [DllImport("CTPFutureApi", EntryPoint = "SWIGRegisterStringCallback_CTPFutureApi")]
    static extern void SWIGRegisterStringCallback_CTPFutureApi(SwigStringDelegate stringDelegate);

    // ReSharper disable once InconsistentNaming
#if NETFRAMEWORK
    private static Encoding GB2312 { get; } = Encoding.GetEncoding("GB2312");
#else
    private static Encoding GB2312 { get; } = CodePagesEncodingProvider.Instance.GetEncoding("GB2312")!;
#endif

    static
#if !NET45
    unsafe
#endif
    string CreateString(IntPtr ptr)
    {
        if (ptr == IntPtr.Zero)
            return string.Empty;

        int count = 0;
        while (Marshal.ReadByte(ptr, count++) != 0) { }
#if NET45
        var buffer = new byte[count];
        Marshal.Copy(ptr, buffer, 0, count);
        return GB2312.GetString(buffer);
#else
        return GB2312.GetString((byte*)ptr, count);
#endif
    }

    public static void Register()
    {
        SWIGRegisterStringCallback_CTPFutureApi(StringDelegate);
    }
}
