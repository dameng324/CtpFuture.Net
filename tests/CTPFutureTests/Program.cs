using System.Text.Json;
using CoupleTrader.Api.Trade.CTPFuture;
using CoupleTrader.Common;
using CoupleTrader.Common.Trading;
using CoupleTrader.Common.Utilities;
using Serilog;
using Serilog.Core;

namespace CTPFutureTests
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var json = """               
                    {
                    "IsEnable": false,
                    "DisplayName": "Simnow",
                    "TradeOrQuote": "Trade",
                    "ApiType": "CTP期货",
                    "ServerAddr": "tcp://218.202.237.33:10203",
                    "UserId": "066204",
                    "Password": "acies123!@#",
                    "GenericField": "CtpBrokerID=9999;UserProductInfo=Test;AuthCode=0000000000000000;AppID=simnow_client_test;"
                    }
                    """;
                Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
                var loginInfo = JsonSerializer.Deserialize(json, CoupleTraderJsonContext.Default.ApiLoginInfoField)!;

                var api = new CtpFutureTradeApi(loginInfo);
                await api.ConnectAndLoginAsync();
                Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} ConnectAndLoginAsync");

                //var marketCodes = await api.QryMarketCodesAsync();
                //Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} QryMarketCodesAsync");

                //var codeMargins = await api.ReqQryCodeMarginFeeAsync();
                //Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} ReqQryCodeMarginFeeAsync");

                //var orders = await api.QryOrderAsyncSafely();
                //Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} QryOrderAsyncSafely");

                //var trades = await api.QryTradeAsyncSafely();
                //Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} QryTradeAsyncSafely");

                //var funds = await api.QryTradingAccountAsyncSafely();
                //Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} QryTradingAccountAsyncSafely");

                //var positions = await api.QryInvestorPositionAsyncSafely();
                //Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} QryInvestorPositionAsyncSafely");

                var positiondetails = await api.QryInvestorPositionDetailsAsyncSafely();
                Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} QryInvestorPositionDetailsAsyncSafely");

                //api.OrderInsert(
                //    new CoupleTrader.Common.Data.InputOrderInfoField()
                //    {
                //        VolumeTotalOriginal = 1,
                //        Code = "ag2303",
                //        Direction = CoupleTrader.Common.Data.EnumDirectionType.Buy,
                //        ExchangeId = "SHFE",
                //        GenericField = new(),
                //        HedgeFlag = CoupleTrader.Common.Data.EnumHedgeFlagType.Speculation,
                //        LimitPrice = 5000,
                //        Offset = CoupleTrader.Common.Data.EnumOffsetFlagType.Open,
                //        OrderPriceType = CoupleTrader.Common.Data.EnumOrderPriceType.Limit,
                //        OrderRef = "11",
                //        UserId = loginInfo.UserId,
                //    }
                //);

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
