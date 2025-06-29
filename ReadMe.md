# CTPFuture.Net

[![NuGet 版本](https://img.shields.io/nuget/v/CTPFuture.Net.svg)](https://www.nuget.org/packages/CTPFuture.Net)
[![构建状态](https://img.shields.io/github/actions/workflow/status/dameng324/CtpFuture.Net/publish.yml)](https://github.com/dameng324/CTPFuture.Net/actions)
[![平台](https://img.shields.io/badge/platform-windows%20%7C%20linux-blue)](#)
[![下载量](https://img.shields.io/nuget/dt/CTPFuture.Net.svg)](https://www.nuget.org/packages/CTPFuture.Net)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

> 现代化的 CTP 期货 API .NET 封装库，跨平台，基于 swig 技术集成 C++，支持 Windows 和 Linux。

---

## ✨ 功能特性

- 支持交易与行情接口
- 兼容 .NET Framework 4.5、.NET Standard 2.0、.NET 6、.NET 8
- 自动拷贝依赖 DLL 至输出目录
- 支持 Native AOT 编译，提升安全性
- 跨平台支持：Windows、Linux（Mac/iOS/Android 理论可用）

---

## 🚀 快速开始

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

// simnow 前置地址
api.RegisterFront("tcp://180.168.146.187:10131");
api.Init();
api.Join();

public class TraderSpiImpl : CThostFtdcTraderSpi
{
    private CThostFtdcTraderApi api;
    public void SetApi(CThostFtdcTraderApi api) => this.api = api;
    public override void OnFrontConnected() => Console.WriteLine("OnFrontConnected");
    // ...实现其他回调...
}
```

---

## 📦 安装

通过 NuGet 安装：

```bash
dotnet add package CTPFuture.Net
```

或在 `.csproj` 文件中添加：

```xml
<PackageReference Include="CTPFuture.Net" Version="6.3.15.3" />
```

---

## ❓ 常见问题

- **CTP API 版本号？**  
  v6.3.15_20190220 20:39:53

- **DLL 未自动拷贝？**  
  默认 DLL 会拷贝到 `runtimes/` 目录以适配多平台。如仅需特定平台，建议在 `.csproj` 设置 `<RuntimeIdentifier>`：

  - Windows: `<RuntimeIdentifier>win-x64</RuntimeIdentifier>`
  - Linux: `<RuntimeIdentifier>linux-x64</RuntimeIdentifier>`

---

## 📝 文档

- [API 文档](doc/ctp_docs.zip)
- [更新日志](https://github.com/ctpnet/CTPFuture.Net/releases)

---

## 🤝 贡献指南

欢迎提交 PR、Issue 或建议。详情请参考 [CONTRIBUTING.md](CONTRIBUTING.md)（如有）。

---

## 💬 社区与支持

- [GitHub Issues](https://github.com/ctpnet/CTPFuture.Net/issues)
- 邮箱：your@email.com

---

## ☕ 打赏

如果本项目对你有帮助，欢迎打赏支持：

![img.png](img.png)

---

## 许可证

MIT License