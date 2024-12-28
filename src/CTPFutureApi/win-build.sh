#!/usr/bin/bash

# 获取脚本所在目录的绝对路径
SCRIPT_DIR="$(cd "$(dirname "$0")" && pwd)"

# 获取当前工作目录
CURRENT_DIR="$(pwd)"

# 比较路径，如果不同则退出
if [ "$SCRIPT_DIR" != "$CURRENT_DIR" ]; then
    echo "Error: This script must be run from its own directory ($SCRIPT_DIR)."
    exit 1
fi

mkdir -p win-build
cd win-build
cmake .. -G "Visual Studio 17 2022"
cmake --build . --config Release

