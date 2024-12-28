cmake_minimum_required(VERSION 3.10)
project(CTPFutureApi)

# 设置C++标准
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED True)

# 包含目录
# include_directories(${CMAKE_SOURCE_DIR}/include)

# 源文件
set(SOURCES
    ${CMAKE_SOURCE_DIR}/swig_wrap.cxx
)

# 生成动态库
add_library(CTPFutureApi SHARED ${SOURCES})

# 第三方库位置
if(WIN32)
    set(LIB_PATH ${CMAKE_SOURCE_DIR}/../CTPFuture.Net/runtimes/win-x64/native)
else(UNIX)
    set(LIB_PATH ${CMAKE_SOURCE_DIR}/../CTPFuture.Net/runtimes/linux-x64/native)
endif()
    
message(STATUS "LIB_PATH: ${LIB_PATH}")

# 链接第三方库
target_link_directories(CTPFutureApi PRIVATE ${LIB_PATH})
target_link_libraries(CTPFutureApi PRIVATE
    thostmduserapi_se
    thosttraderapi_se
)

# 输出目录
set_target_properties(CTPFutureApi PROPERTIES
    LIBRARY_OUTPUT_DIRECTORY ${LIB_PATH}
    RUNTIME_OUTPUT_DIRECTORY ${LIB_PATH}
    LIBRARY_OUTPUT_DIRECTORY_RELEASE ${LIB_PATH}
    RUNTIME_OUTPUT_DIRECTORY_RELEASE ${LIB_PATH}
)

message(STATUS "Building for: ${CMAKE_SYSTEM_NAME}")
