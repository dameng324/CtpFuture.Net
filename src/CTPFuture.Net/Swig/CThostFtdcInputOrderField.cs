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

public class CThostFtdcInputOrderField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInputOrderField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInputOrderField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcInputOrderField obj) {
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

  ~CThostFtdcInputOrderField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcInputOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve1 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderPriceType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_OrderPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_OrderPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public string CombOffsetFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_CombOffsetFlag_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_CombOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CombHedgeFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_CombHedgeFlag_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_CombHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LimitPrice {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_LimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_LimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTotalOriginal {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_VolumeTotalOriginal_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_VolumeTotalOriginal_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeCondition {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_TimeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_TimeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public string GTDDate {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_GTDDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_GTDDate_get(swigCPtr);
      return ret;
    } 
  }

  public char VolumeCondition {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_VolumeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_VolumeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public int MinVolume {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_MinVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_MinVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char ContingentCondition {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_ContingentCondition_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_ContingentCondition_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public char ForceCloseReason {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_ForceCloseReason_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_ForceCloseReason_get(swigCPtr);
      return ret;
    } 
  }

  public int IsAutoSuspend {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_IsAutoSuspend_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_IsAutoSuspend_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int UserForceClose {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_UserForceClose_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_UserForceClose_get(swigCPtr);
      return ret;
    } 
  }

  public int IsSwapOrder {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_IsSwapOrder_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_IsSwapOrder_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInputOrderField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInputOrderField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputOrderField() : this(CTPFutureApiPINVOKE.new_CThostFtdcInputOrderField(), true) {
  }

}

}