#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
cd "$SCRIPT_DIR"
EXPECTED_SWIG_VERSION="$(tr -d '\r\n' < "$SCRIPT_DIR/../../.swig-version")"
ACTUAL_SWIG_VERSION="$(swig -version | awk '/SWIG Version/ {print $3; exit}')"
if [[ "$ACTUAL_SWIG_VERSION" != "$EXPECTED_SWIG_VERSION" ]]; then
    echo "Error: Expected SWIG $EXPECTED_SWIG_VERSION but found $ACTUAL_SWIG_VERSION." >&2
    exit 1
fi

mkdir -p ../CTPFuture.Net/Swig/
swig -c++ -csharp -namespace CtpFuture.Net -outdir ../CTPFuture.Net/Swig/ swig.i
dotnet StripSwigDerivedChecks.cs -- --no-backup \
  "../CTPFuture.Net/Swig/CThostFtdcMdSpi.cs" \
  "../CTPFuture.Net/Swig/CThostFtdcTraderSpi.cs"
dotnet tool run csharpier format ../CTPFuture.Net/Swig
