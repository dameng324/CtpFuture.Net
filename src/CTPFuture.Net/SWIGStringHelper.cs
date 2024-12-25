using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CtpFuture;

internal static class SwigStringHelper
{
    private delegate string SwigStringDelegate(IntPtr message);

    private static readonly SwigStringDelegate StringDelegate = CreateString;

    [DllImport("CTPFutureApi", EntryPoint = "SWIGRegisterStringCallback_CTPFutureApi")]
    static extern void SWIGRegisterStringCallback_CTPFutureApi(SwigStringDelegate stringDelegate);

    // ReSharper disable once InconsistentNaming
    private static Encoding GB2312 { get; } = CodePagesEncodingProvider.Instance.GetEncoding("GB2312")!;

    static unsafe string CreateString(IntPtr ptr)
    {
        if (ptr == IntPtr.Zero)
            return string.Empty;

        int count = 0;
        while (Marshal.ReadByte(ptr, count++) != 0) { }
        return GB2312.GetString((byte*)ptr, count);
    }

    public static void Register()
    {
        SWIGRegisterStringCallback_CTPFutureApi(StringDelegate);
    }
}
