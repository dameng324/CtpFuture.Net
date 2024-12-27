using System;
using CtpFuture;
using CtpFuture.Net;

SwigStringHelper.Register();

Console.WriteLine(CThostFtdcTraderApi.GetApiVersion());
Console.WriteLine(CThostFtdcMdApi.GetApiVersion());

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
