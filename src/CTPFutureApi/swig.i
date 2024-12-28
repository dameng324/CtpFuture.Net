/* File : swig.i */

%module(directors="1") CTPFutureApi
%{ 
    #include "include/ThostFtdcUserApiDataType.h"
    #include "include/ThostFtdcUserApiStruct.h"
    #include "include/ThostFtdcTraderApi.h"
    #include "include/ThostFtdcMdApi.h"
%}
/* turn on director wrapping Callback */
%feature("director") CThostFtdcTraderSpi;
%feature("director") CThostFtdcMdSpi;

%include "include/ThostFtdcUserApiDataType.h"
%include "include/ThostFtdcUserApiStruct.h"
%include "include/ThostFtdcTraderApi.h"
%include "include/ThostFtdcMdApi.h"