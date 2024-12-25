using System.Reactive.Linq;
using System.Reactive.Threading.Tasks;
using System.Text.Json;
using CoupleTrader.Api.Quote.CTPFuture;
using CoupleTrader.Common;
using CoupleTrader.Common.Trading;
using CoupleTrader.Common.Utilities;

namespace CTPFutureTests
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var json = """
                {
                	"IsEnable": true,
                	"DisplayName": "Simnow",
                	"TradeOrQuote": "Trade",
                	"ApiType": "CTP期货",
                "ServerAddr": "tcp://180.168.146.187:10131",
                	"UserId": "104155",
                	"Password": "13409323394",
                	"GenericField": "CtpBrokerID=9999;UserProductInfo=Test;AuthCode=0000000000000000;AppID=simnow_client_test;"
                }
                """;
            var loginInfo = JsonSerializer.Deserialize(json, CoupleTrader.Common.CoupleTraderJsonContext.Default.ApiLoginInfoField)!;
            var api = new CtpFutureQuoteApi(loginInfo);
            await api.ConnectAndLoginAsync();
            Console.WriteLine($"Logined");
            await Task.Delay(1050);
            var task = api.DataArriveAsObservable().Take(1).ToTask();
            api.SubMarketData("ag2501", "ag2503");
            await task;
        }
    }
}
