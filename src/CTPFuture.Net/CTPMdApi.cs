using System;
using System.IO;
using System.Runtime.InteropServices;
using CtpFuture.Net.Swig;

namespace CtpFuture;

public class CTPMdApi : CThostFtdcMdSpi
{
    static CTPMdApi()
    {
        SwigStringHelper.Register();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            api?.Release();
            api = null!;
        }
        base.Dispose(disposing);
    }

    public CTPMdApi(string pszFlowPath, bool bIsUsingUdp, bool bIsMulticast)
    {
        SwigStringHelper.Register();
        api = CThostFtdcMdApi.CreateFtdcMdApi(pszFlowPath, bIsUsingUdp, bIsMulticast);
        api.RegisterSpi(this);
    }

    public CThostFtdcMdApi api { get; private set; }

    public delegate void FrontConnected();
    public event FrontConnected? OnFrontConnectedEvent;

    public override void OnFrontConnected()
    {
        OnFrontConnectedEvent?.Invoke();
    }

    public delegate void FrontDisconnected(int reason);
    public event FrontDisconnected? OnFrontDisconnectedEvent;

    public override void OnFrontDisconnected(int reason)
    {
        OnFrontDisconnectedEvent?.Invoke(reason);
    }

    public delegate void HeartBeatWarning(int pTimeLapes);
    public event HeartBeatWarning? OnHeartBeatWarningEvent;

    public override void OnHeartBeatWarning(int pTimeLapes)
    {
        OnHeartBeatWarningEvent?.Invoke(pTimeLapes);
    }

    public delegate void RspError(CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public event RspError? OnRspErrorEvent;

    public override void OnRspError(CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
    {
        OnRspErrorEvent?.Invoke(pRspInfo, nRequestID, bIsLast);
    }

    public delegate void RspUserLogin(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public event RspUserLogin? OnRspUserLoginEvent;

    public override void OnRspUserLogin(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
    {
        OnRspUserLoginEvent?.Invoke(pRspUserLogin, pRspInfo, nRequestID, bIsLast);
    }

    public delegate void RspUserLogout(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public event RspUserLogout? OnRspUserLogoutEvent;

    public override void OnRspUserLogout(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
    {
        OnRspUserLogoutEvent?.Invoke(pUserLogout, pRspInfo, nRequestID, bIsLast);
    }

    public delegate void RspSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public event RspSubMarketData? OnRspSubMarketDataEvent;

    public override void OnRspSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
    {
        OnRspSubMarketDataEvent?.Invoke(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
    }

    public delegate void RspUnSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public event RspUnSubMarketData? OnRspUnSubMarketDataEvent;

    public override void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
    {
        OnRspUnSubMarketDataEvent?.Invoke(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
    }

    public delegate void RspQryMulticastInstrument(CThostFtdcMulticastInstrumentField pMulticastInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public event RspQryMulticastInstrument? OnRspQryMulticastInstrumentEvent;

    public override void OnRspQryMulticastInstrument(CThostFtdcMulticastInstrumentField pMulticastInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
    {
        OnRspQryMulticastInstrumentEvent?.Invoke(pMulticastInstrument, pRspInfo, nRequestID, bIsLast);
    }

    public delegate void RspSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public event RspSubForQuoteRsp? OnRspSubForQuoteRspEvent;

    public override void OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
    {
        OnRspSubForQuoteRspEvent?.Invoke(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
    }

    public delegate void RspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
    public event RspUnSubForQuoteRsp? OnRspUnSubForQuoteRspEvent;

    public override void OnRspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
    {
        OnRspUnSubForQuoteRspEvent?.Invoke(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
    }

    public delegate void RtnDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData);
    public event RtnDepthMarketData? OnRtnDepthMarketDataEvent;

    public override void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData)
    {
        OnRtnDepthMarketDataEvent?.Invoke(pDepthMarketData);
    }

    public delegate void RtnForQuoteRsp(CThostFtdcForQuoteRspField pForQuoteRsp);
    public event RtnForQuoteRsp? OnRtnForQuoteRspEvent;

    public override void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField pForQuoteRsp)
    {
        OnRtnForQuoteRspEvent?.Invoke(pForQuoteRsp);
    }
}

public static class SwigWrapperExtension
{
    public static int SubscribeMarketData(this CThostFtdcMdApi api, string[] ppInstrumentID)
    {
        int ret = CThostFtdcMdApi_SubscribeMarketData(CThostFtdcMdApi.getCPtr(api), ppInstrumentID, ppInstrumentID.Length);
        return ret;
    }

    public static int UnSubscribeMarketData(this CThostFtdcMdApi api, string[] ppInstrumentID)
    {
        int ret = CThostFtdcMdApi_UnSubscribeMarketData(CThostFtdcMdApi.getCPtr(api), ppInstrumentID, ppInstrumentID.Length);
        return ret;
    }

    [DllImport("CTPFutureMdApi", EntryPoint = "CSharp_CTPQuotefSwig_CThostFtdcMdApi_SubscribeMarketData___")]
    public static extern int CThostFtdcMdApi_SubscribeMarketData(global::System.Runtime.InteropServices.HandleRef jarg1, string[] jarg2, int jarg3);

    [DllImport("CTPFutureMdApi", EntryPoint = "CSharp_CTPQuotefSwig_CThostFtdcMdApi_UnSubscribeMarketData___")]
    public static extern int CThostFtdcMdApi_UnSubscribeMarketData(global::System.Runtime.InteropServices.HandleRef jarg1, string[] jarg2, int jarg3);
}
