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

public class CThostFtdcInstrumentStatusField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInstrumentStatusField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInstrumentStatusField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcInstrumentStatusField obj) {
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

  ~CThostFtdcInstrumentStatusField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcInstrumentStatusField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string ExchangeID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string SettlementGroupID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_SettlementGroupID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_SettlementGroupID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char InstrumentStatus {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_InstrumentStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_InstrumentStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int TradingSegmentSN {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_TradingSegmentSN_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_TradingSegmentSN_get(swigCPtr);
      return ret;
    } 
  }

  public string EnterTime {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_EnterTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_EnterTime_get(swigCPtr);
      return ret;
    } 
  }

  public char EnterReason {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_EnterReason_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentStatusField_EnterReason_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInstrumentStatusField() : this(CTPFutureApiPINVOKE.new_CThostFtdcInstrumentStatusField(), true) {
  }

}

}
