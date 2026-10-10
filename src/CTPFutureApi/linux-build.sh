#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
if [[ "$SCRIPT_DIR" != "$(pwd -P)" ]]; then
    echo "Error: This script must be run from its own directory: $SCRIPT_DIR" >&2
    exit 1
fi

LIB_DIR="$SCRIPT_DIR/../CTPFuture.Net/runtimes/linux-x64/native"
for library in thostmduserapi_se thosttraderapi_se; do
    if [[ -f "$LIB_DIR/$library.so" && ! -f "$LIB_DIR/lib$library.so" ]]; then
        mv "$LIB_DIR/$library.so" "$LIB_DIR/lib$library.so"
    fi
done

cmake -S "$SCRIPT_DIR" -B "$SCRIPT_DIR/linux-build" -DCMAKE_BUILD_TYPE=Release
cmake --build "$SCRIPT_DIR/linux-build" --parallel