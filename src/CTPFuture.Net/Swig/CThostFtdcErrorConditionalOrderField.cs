//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CtpFuture.Net.Swig {

public class CThostFtdcErrorConditionalOrderField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcErrorConditionalOrderField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcErrorConditionalOrderField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcErrorConditionalOrderField obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~CThostFtdcErrorConditionalOrderField() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPFutureApiPINVOKE.delete_CThostFtdcErrorConditionalOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderPriceType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public string CombOffsetFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_CombOffsetFlag_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_CombOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CombHedgeFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_CombHedgeFlag_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_CombHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LimitPrice {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_LimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_LimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTotalOriginal {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_VolumeTotalOriginal_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_VolumeTotalOriginal_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeCondition {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_TimeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_TimeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public string GTDDate {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_GTDDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_GTDDate_get(swigCPtr);
      return ret;
    } 
  }

  public char VolumeCondition {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_VolumeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_VolumeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public int MinVolume {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_MinVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_MinVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char ContingentCondition {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ContingentCondition_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ContingentCondition_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public char ForceCloseReason {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ForceCloseReason_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ForceCloseReason_get(swigCPtr);
      return ret;
    } 
  }

  public int IsAutoSuspend {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_IsAutoSuspend_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_IsAutoSuspend_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSubmitStatus {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderSubmitStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderSubmitStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSysID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderStatus {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderStatus_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTraded {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_VolumeTraded_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_VolumeTraded_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTotal {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_VolumeTotal_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_VolumeTotal_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveTime {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ActiveTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ActiveTime_get(swigCPtr);
      return ret;
    } 
  }

  public string SuspendTime {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_SuspendTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_SuspendTime_get(swigCPtr);
      return ret;
    } 
  }

  public string UpdateTime {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_UpdateTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_UpdateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveTraderID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ActiveTraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ActiveTraderID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string StatusMsg {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_StatusMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_StatusMsg_get(swigCPtr);
      return ret;
    } 
  }

  public int UserForceClose {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_UserForceClose_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_UserForceClose_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveUserID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ActiveUserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ActiveUserID_get(swigCPtr);
      return ret;
    } 
  }

  public int BrokerOrderSeq {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_BrokerOrderSeq_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_BrokerOrderSeq_get(swigCPtr);
      return ret;
    } 
  }

  public string RelativeOrderSysID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_RelativeOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_RelativeOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public int ZCETotalTradedVolume {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ZCETotalTradedVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ZCETotalTradedVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public int IsSwapOrder {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_IsSwapOrder_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_IsSwapOrder_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve3 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_reserve3_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_reserve3_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcErrorConditionalOrderField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcErrorConditionalOrderField() : this(CTPFutureApiPINVOKE.new_CThostFtdcErrorConditionalOrderField(), true) {
  }

}

}