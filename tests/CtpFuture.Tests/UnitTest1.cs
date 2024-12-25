using System;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text.Json;
using System.Threading.Tasks;
using CtpFuture.Net.Swig;

namespace CtpFuture.Tests;

public class UnitTest1
{
    [Test]
    public async Task TestTradeLogin()
    {
        int requestId = 1;
        var ctpTdApi = new CtpTdApi("");
        ctpTdApi.Api.RegisterFront("tcp://180.168.146.187:10131");
        TaskCompletionSource tcs = new();
        ctpTdApi.OnFrontConnectedEvent += () =>
        {
            TestContext.Current?.OutputWriter.WriteLine("连接成功");
            ctpTdApi.Api.ReqAuthenticate(
                new Net.Swig.CThostFtdcReqAuthenticateField
                {
                    AppID = "simnow_client_test",
                    AuthCode = "0000000000000000",
                    BrokerID = "9999",
                    UserID = userId,
                    UserProductInfo = "Test",
                },
                requestId++
            );
        };
        ctpTdApi.OnRspAuthenticateEvent += delegate(CThostFtdcRspAuthenticateField? pRspAuthenticateField, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
        {
            TestContext.Current?.OutputWriter.WriteLine($"认证成功:{pRspAuthenticateField?.UserID}");

            ctpTdApi.Api.ReqUserLogin(
                new Net.Swig.CThostFtdcReqUserLoginField
                {
                    UserID = userId,
                    Password = password,
                    BrokerID = "9999",
                    UserProductInfo = "Test",
                },
                requestId++
            );
        };
        ctpTdApi.OnRspUserLoginEvent += (CThostFtdcRspUserLoginField? pRspUserLogin, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast) =>
        {
            TestContext.Current?.OutputWriter.WriteLine($"登录成功:{pRspUserLogin?.TradingDay}");
            tcs.SetResult();
        };

        TestContext.Current?.OutputWriter.WriteLine("初始化");
        ctpTdApi.Api.Init();
        await tcs.Task;
    }
}
