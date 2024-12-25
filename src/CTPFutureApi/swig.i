/* File : swig.i */

%module(directors="1") CTPFutureApi
%{ 
    #define _WIN32
    #include "api_x64/ThostFtdcUserApiDataType.h"
    #include "api_x64/ThostFtdcUserApiStruct.h"
    #include "api_x64/ThostFtdcTraderApi.h"
    #include "api_x64/ThostFtdcMdApi.h"
%}
/* turn on director wrapping Callback */
%feature("director") CThostFtdcTraderSpi;
%feature("director") CThostFtdcMdSpi;

%include "api_x64/ThostFtdcUserApiDataType.h"
%include "api_x64/ThostFtdcUserApiStruct.h"
%include "api_x64/ThostFtdcTraderApi.h"
%include "api_x64/ThostFtdcMdApi.h"