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

public class CThostFtdcForQuoteField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcForQuoteField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcForQuoteField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcForQuoteField obj) {
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

  ~CThostFtdcForQuoteField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcForQuoteField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ForQuoteRef {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ForQuoteRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ForQuoteRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string ForQuoteLocalID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ForQuoteLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ForQuoteLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public char ForQuoteStatus {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ForQuoteStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ForQuoteStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string StatusMsg {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_StatusMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_StatusMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveUserID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ActiveUserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_ActiveUserID_get(swigCPtr);
      return ret;
    } 
  }

  public int BrokerForQutoSeq {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_BrokerForQutoSeq_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_BrokerForQutoSeq_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public string IPAddress {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_IPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_IPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      CTPFutureApiPINVOKE.CThostFtdcForQuoteField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcForQuoteField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcForQuoteField() : this(CTPFutureApiPINVOKE.new_CThostFtdcForQuoteField(), true) {
  }

}

}
