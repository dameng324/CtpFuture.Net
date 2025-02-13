//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.3.0
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CtpFuture.Net {

public class CThostFtdcExchangeExecOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeExecOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeExecOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcExchangeExecOrderActionField obj) {
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

  ~CThostFtdcExchangeExecOrderActionField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcExchangeExecOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string ExchangeID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderSysID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ExecOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ExecOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionDate {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionDate_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionTime {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderLocalID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ExecOrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ExecOrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ActionLocalID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderActionStatus {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_OrderActionStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_OrderActionStatus_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ActionType_get(swigCPtr);
      return ret;
    } 
  }

  public string BranchID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_BranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_BranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcExchangeExecOrderActionField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeExecOrderActionField() : this(CTPFutureApiPINVOKE.new_CThostFtdcExchangeExecOrderActionField(), true) {
  }

}

}
