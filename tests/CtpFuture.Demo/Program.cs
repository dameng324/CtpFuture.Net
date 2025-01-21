using System;
using CtpFuture;
using CtpFuture.Net;

//SwigStringHelper.Register();

Console.WriteLine(CThostFtdcTraderApi.GetApiVersion());
Console.WriteLine(CThostFtdcMdApi.GetApiVersion());
QuoteTest();
void QuoteTest()
{
    var spi = new QuoteSpiImpl();
    var api = CThostFtdcMdApi.CreateFtdcMdApi();
    spi.SetApi(api);
    api.RegisterSpi(spi);
    
    api.RegisterFront("tcp://180.168.146.187:10211");
    api.RegisterFront("tcp://180.168.146.187:10212");
    api.Init();
    api.Join();
}
void TradeTest()
{
    
    var spi = new TraderSpiImpl();
    var api = CThostFtdcTraderApi.CreateFtdcTraderApi();
    spi.SetApi(api);
    api.RegisterSpi(spi);
    api.SubscribePrivateTopic(THOST_TE_RESUME_TYPE.THOST_TERT_QUICK);
    api.SubscribePublicTopic(THOST_TE_RESUME_TYPE.THOST_TERT_QUICK);
    
    //simnow front address
    api.RegisterFront("tcp://180.168.146.187:10131");
    api.Init();
    api.Join();
}

public class TraderSpiImpl : CThostFtdcTraderSpi
{
    private CThostFtdcTraderApi api;

    public void SetApi(CThostFtdcTraderApi api)
    {
        this.api = api;
    }

    public override void OnFrontConnected()
    {
        Console.WriteLine("OnFrontConnected");
        var ret = api.ReqAuthenticate(
            new CThostFtdcReqAuthenticateField
            {
                BrokerID = "9999",
                UserID = "xxxx",
                UserProductInfo = "Test",
                AuthCode = "0000000000000000",
                AppID = "simnow_client_test",
            },
            1
        );
        if (ret != 0)
        {
            Console.WriteLine("ReqAuthenticate failed ret=" + ret);
        }
        Console.WriteLine("ReqAuthenticate...");
    }

    public override void OnRspAuthenticate(CThostFtdcRspAuthenticateField? pRspAuthenticateField, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
    {
        Console.WriteLine("OnRspAuthenticate: " + pRspInfo?.ErrorMsg?? "");
        if (pRspInfo?.ErrorID == 0)
        {
            var ret = api.ReqUserLogin(
                new CThostFtdcReqUserLoginField
                {
                    BrokerID = "9999",
                    UserID = "xxxx",
                    Password = "xxxx",
                    UserProductInfo = "Test",
                    
                },
                2
            );
            if (ret != 0)
            {
                Console.WriteLine("ReqUserLogin failed ret=" + ret);
            }
            Console.WriteLine("ReqUserLogin...");
        }
    }

    public override void OnRspUserLogin(CThostFtdcRspUserLoginField? pRspUserLogin, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
    {
        Console.WriteLine($"OnRspUserLogin: ErrorId：{pRspInfo?.ErrorID} {pRspInfo.ErrorMsg}");
    }
}
public class QuoteSpiImpl : CThostFtdcMdSpi
{
    private CThostFtdcMdApi api;

    public void SetApi(CThostFtdcMdApi api)
    {
        this.api = api;
    }

    public override void OnFrontConnected()
    {
        Console.WriteLine("OnFrontConnected");
        var ret = api.ReqUserLogin(
            new CThostFtdcReqUserLoginField
            {
                BrokerID = "9999",
                UserID = "xxxx",
                Password = "xxxx",
            },
            1
        );
        if (ret != 0)
        {
            Console.WriteLine("ReqUserLogin failed ret=" + ret);
        }
        Console.WriteLine("ReqUserLogin...");
    }

    public override void OnRspUserLogin(CThostFtdcRspUserLoginField? pRspUserLogin, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)
    {
        Console.WriteLine($"OnRspUserLogin: ErrorId：{pRspInfo?.ErrorID} {pRspInfo.ErrorMsg}");
        api.SubscribeMarketData(["IF2502","IF2503"]);
    }

    public override void OnFrontDisconnected(int nReason)
    {
        Console.WriteLine("OnFrontDisconnected: " + nReason);
    }

    public override void OnRspError(CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
    {
        Console.WriteLine("OnRspError: " + pRspInfo.ErrorMsg);
    }

    public override void OnHeartBeatWarning(int nTimeLapse)
    {
        Console.WriteLine("OnHeartBeatWarning: " + nTimeLapse);
    }

    public override void OnRspSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID,
        bool bIsLast)
    {
        Console.WriteLine("OnRspSubMarketData: ");
    }

    public override void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData)
    {
        
    }

    public override void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField pForQuoteRsp)
    {
        
    }

    public override void OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID,
        bool bIsLast)
    {
        
    }
}