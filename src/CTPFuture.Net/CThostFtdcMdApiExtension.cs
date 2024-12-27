using System.Runtime.InteropServices;
using CtpFuture.Net;

namespace CtpFuture;

public static class CThostFtdcMdApiExtension
{
    public static int SubscribeMarketData(this CThostFtdcMdApi api, string[] instrumentId)
    {
        int ret = CThostFtdcMdApi_SubscribeMarketData(CThostFtdcMdApi.getCPtr(api), instrumentId, instrumentId.Length);
        return ret;
    }

    public static int UnSubscribeMarketData(this CThostFtdcMdApi api, string[] instrumentId)
    {
        int ret = CThostFtdcMdApi_UnSubscribeMarketData(CThostFtdcMdApi.getCPtr(api), instrumentId, instrumentId.Length);
        return ret;
    }

    [global::System.Runtime.InteropServices.DllImport("CTPFutureApi", EntryPoint="CSharp_CtpFuturefNet_CThostFtdcMdApi_SubscribeMarketData___")]
    public static extern int CThostFtdcMdApi_SubscribeMarketData(global::System.Runtime.InteropServices.HandleRef jarg1, string[] jarg2, int jarg3);

    [global::System.Runtime.InteropServices.DllImport("CTPFutureApi", EntryPoint="CSharp_CtpFuturefNet_CThostFtdcMdApi_UnSubscribeMarketData___")]
    public static extern int CThostFtdcMdApi_UnSubscribeMarketData(global::System.Runtime.InteropServices.HandleRef jarg1, string[] jarg2, int jarg3);
}