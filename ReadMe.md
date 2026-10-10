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
- 兼容 .NET Framework 4.5、.NET Standard 2.0、.NET 8、.NET 10
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

---

## ❓ 常见问题

- **CTP API 版本号？**  
  v6.7.11_20250617 16:22:00.10369

- **DLL 未自动拷贝？**  
  默认 DLL 会拷贝到 `runtimes/` 目录以适配多平台。如仅需特定平台，建议在 `.csproj` 设置 `<RuntimeIdentifier>`：

  - Windows: `<RuntimeIdentifier>win-x64</RuntimeIdentifier>`
  - Linux: `<RuntimeIdentifier>linux-x64</RuntimeIdentifier>`

---

## 📝 文档

- [API 文档](doc/ctp_docs.zip)
- [更新日志](https://github.com/ctpnet/CTPFuture.Net/releases)

---

---

## 💬 社区与支持

- [GitHub Issues](https://github.com/dameng324/CTPFuture.Net/issues)

---

## ☕ 打赏

如果本项目对你有帮助，欢迎打赏支持：

![img.png](img.png)

---

## 许可证

MIT License

## Build

### Requirements

Use the .NET SDK pinned in `global.json` and restore the repository tools:

```bash
dotnet tool restore
```

SWIG must match the version in `.swig-version` (currently 4.5.1). CI runs SWIG generation on Ubuntu 24.04 and builds the Windows wrapper and NuGet package on windows-latest. Windows native builds use CMake 4.3 or later with Visual Studio 2026.

### Regenerate SWIG bindings

Generated C# and C++ files are not tracked in Git. CI regenerates them before compiling. Before each local solution build, regenerate the bindings from the pinned SWIG version:

```bash
cd src/CTPFutureApi
dotnet tool restore
bash ./SwigGenerate.sh
cd ../..
```

The script runs this repository's C# post-processing and formatting steps.

### Build the solution

```bash
dotnet build CtpFuture.Net.slnx --configuration Release
```

### Build native wrappers

Build the Windows wrapper from Git Bash and the Linux wrapper from WSL2. Run these commands from `src/CTPFutureApi`:

```bash
bash ./win-build.sh
bash ./linux-build.sh
```


### GitHub Actions

Pull requests and pushes to `main` run `.github/workflows/ci.yml`. It calls `.github/workflows/build.yml` to generate SWIG bindings on Linux, build the Windows wrapper, and pack the NuGet package; the `.nupkg` is uploaded as a 30-day workflow artifact. All workflow run steps use Bash, including Git Bash on Windows. `.github/workflows/publish.yml` calls the same build workflow, then publishes to NuGet for a `vX.Y.Z` tag or a manual run from `main` with a supplied version; tag publishing also creates a GitHub Release.
