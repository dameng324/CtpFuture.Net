#!/usr/bin/env bash

set -euo pipefail

SCRIPT_DIR="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"

LIB_DIR="$SCRIPT_DIR/../CTPFuture.Net/runtimes/linux-x64/native"

# 如果存在原始文件且还没有 lib 前缀，则重命名
if [[ -f "$LIB_DIR/thostmduserapi_se.so" && ! -f "$LIB_DIR/libthostmduserapi_se.so" ]]; then
    mv "$LIB_DIR/thostmduserapi_se.so" "$LIB_DIR/libthostmduserapi_se.so"
fi

if [[ -f "$LIB_DIR/thosttraderapi_se.so" && ! -f "$LIB_DIR/libthosttraderapi_se.so" ]]; then
    mv "$LIB_DIR/thosttraderapi_se.so" "$LIB_DIR/libthosttraderapi_se.so"
fi

if [[ "$SCRIPT_DIR" != "$(pwd -P)" ]]; then
    echo "Error: This script must be run from its own directory: $SCRIPT_DIR" >&2
    exit 1
fi

cmake -S "$SCRIPT_DIR" -B "$SCRIPT_DIR/linux-build" -DCMAKE_BUILD_TYPE=Release

cmake --build "$SCRIPT_DIR/linux-build" --parallel