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

public class CThostFtdcReqSyncKeyField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqSyncKeyField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqSyncKeyField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcReqSyncKeyField obj) {
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

  ~CThostFtdcReqSyncKeyField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcReqSyncKeyField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string TradeCode {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string Message {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_Message_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_Message_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcReqSyncKeyField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqSyncKeyField() : this(CTPFutureApiPINVOKE.new_CThostFtdcReqSyncKeyField(), true) {
  }

}

}