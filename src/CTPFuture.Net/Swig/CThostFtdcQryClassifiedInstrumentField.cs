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

public class CThostFtdcQryClassifiedInstrumentField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryClassifiedInstrumentField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryClassifiedInstrumentField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcQryClassifiedInstrumentField obj) {
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

  ~CThostFtdcQryClassifiedInstrumentField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcQryClassifiedInstrumentField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string InstrumentID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string ProductID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_ProductID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_ProductID_get(swigCPtr);
      return ret;
    } 
  }

  public char TradingType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_TradingType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_TradingType_get(swigCPtr);
      return ret;
    } 
  }

  public char ClassType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_ClassType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcQryClassifiedInstrumentField_ClassType_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryClassifiedInstrumentField() : this(CTPFutureApiPINVOKE.new_CThostFtdcQryClassifiedInstrumentField(), true) {
  }

}

}
