#!/bin/bash
mkdir -p ../CtpFuture.Net/Swig && swig -c++ -csharp -namespace CtpFuture.Net -outdir ../CtpFuture.Net/Swig/ swig.i
dotnet StripSwigDerivedChecks.cs -- --no-backup  ../CTPFuture.Net/Swig/CThostFtdcMdSpi.cs ../CTPFuture.Net/Swig/CThostFtdcTraderSpi.cs