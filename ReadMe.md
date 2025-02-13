# CTPFuture.Net

[![NuGet](https://img.shields.io/nuget/v/CTPFuture.Net.svg)](https://www.nuget.org/packages/CTPFuture.Net)

CTPFuture.Net是一个用于CTP期货API的.NET库。它使用swig技术，将CTP的C++ API封装成.NET库。可以通过nuget一键安装，支持Windows和Linux。

## 主要功能

- 支持交易接口和行情接口
- 支持旧的.Net Framework 4.5和.Net Standard 2.0，以及.NET6和.NET8
- 编译时会自动将依赖的dll拷贝到输出目录
- 支持Native AOT编译，避免代码被反编译
- 同时支持Windows和Linux。Mac/IOS/Android理论上也可以支持，但是我这边没有环境可以测试。

## 常见问题

### 包里CTP API的版本号是多少？

v6.3.15_20190220 20:39:53

### Dll文件没有自动拷贝到输出目录

默认情况下编译后会拷贝到runtimes/目录下以适应不同的操作系统。如果你的程序只在特定的操作系统下运行，可以在项目csproj配置文件中配置特定的RuntimeIdentifier。
- Windows: `<RuntimeIdentifier>win-x64</RuntimeIdentifier>`
- Linux: `<RuntimeIdentifier>linux-x64</RuntimeIdentifier>`

```csharp
SwigStringHelper.Register();
```

## 安装

使用 dotnet 命令安装

```bash
dotnet add package CTPFuture.Net
```

PackageReference

```xml
<PackageReference Include="CTPFuture.Net" Version="6.3.15.3" />
```

## 用法

```csharp
using System;
using CtpFuture.Net;

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
```

## 打赏

如果这个项目有帮助到你，请随意打赏

![img.png](img.png)

## License

MIT License