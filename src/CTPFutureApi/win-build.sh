#!/usr/bin/env bash
set -euo pipefail

SCRIPT_DIR="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
if [[ "$SCRIPT_DIR" != "$(pwd -P)" ]]; then
    echo "Error: This script must be run from its own directory: $SCRIPT_DIR" >&2
    exit 1
fi

cmake -S "$SCRIPT_DIR" -B "$SCRIPT_DIR/win-build" -G "Visual Studio 18 2026" -A x64
cmake --build "$SCRIPT_DIR/win-build" --config Release