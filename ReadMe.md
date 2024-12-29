# CTPFuture.Net

[![NuGet](https://img.shields.io/nuget/v/CTPFuture.Net.svg)](https://www.nuget.org/packages/CTPFuture.Net)

CTPFuture.Net is a .NET library for the CTP Futures API. It is a wrapper of the CTP C++ API using swig.

Please read FAQ before using this library.[FAQ](#faq)


## Features

- Support both CTP Trade and CTP Market API
- Support .Net framework 4.5 and .Net Standard 2.0 and Modern .Net6 and .Net8
- Auto copy the native dlls to the output directory
- Native AOT support
- Solved the GB2312 encoding problem
- Both Windows and Linux supported.


## Installation

```bash
dotnet add package CTPFuture.Net
```

## Usage

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

## Build from source

### Prerequisites

- dotnet sdk 8.0 or later
- swig 4.3.0 or later, use `scoop install swig` to install swig on windows, do not use `winget`.
- cmake 3.31.3 or later.

### Build

1. Clone the repository and open the solution file `CTPFuture.sln` with Visual Studio 2022.
2. run the command in `CTPFutureApi/SwigGenerator.sh` to generate the cpp and C# wrapper code.
3. run `win-build.sh` for windows native build or `linux-build.sh` for linux native build.
4. Build the `CTPFuture.Net` C# project.

## FAQ

### How to use GB2312 encoding?

Add the following code before using the API

```csharp
SwigStringHelper.Register();
```

### The version of the CTP API?

v6.3.15_20190220 20:39:53

### dll doesn't copy to the output directory?

set `RuntimeIdentifier` to `win-x64` in the project file.

## License

MIT License