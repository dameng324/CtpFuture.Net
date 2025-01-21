// using System;
// using System.Runtime.InteropServices;
// using System.Text;
//
// namespace CtpFuture.Net;
//
// /// <summary>
// ///
// /// </summary>
// public static class SwigStringHelper
// {
//     public delegate string SWIGStringDelegate(string message);
//     static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);
//
//     [global::System.Runtime.InteropServices.DllImport("CTPFutureApi", EntryPoint="SWIGRegisterStringCallback_CTPFutureApi")]
//     public static extern void SWIGRegisterStringCallback_CTPFutureApi(SWIGStringDelegate stringDelegate);
//
//     [global::System.Runtime.InteropServices.DllImport("CTPFutureApi", EntryPoint="SWIG_csharp_string_size")]
//     private static extern int SWIG_csharp_string_size(global::System.IntPtr str);
//     // ReSharper disable once InconsistentNaming
// #if NETFRAMEWORK
//     private static Encoding GB2312 { get; } = Encoding.GetEncoding("GB2312");
// #else
//     private static Encoding GB2312 { get; } = CodePagesEncodingProvider.Instance.GetEncoding("GB2312")!;
// #endif
//
//     static
// #if !NET45
//     unsafe
// #endif
//     string CreateString(IntPtr ptr)
//     {
//         if (ptr == IntPtr.Zero)
//             return string.Empty;
//
//         int count = SWIG_csharp_string_size(ptr);
// #if NET45
//         var buffer = new byte[count];
//         Marshal.Copy(ptr, buffer, 0, count);
//         return GB2312.GetString(buffer);
// #else
//         return GB2312.GetString((byte*)ptr, count);
// #endif
//     }
//
//     public static void Register()
//     {
//         SWIGRegisterStringCallback_CTPFutureApi(StringDelegate);
//     }
// }
