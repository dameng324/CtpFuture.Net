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

public class CThostFtdcQryQuoteField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcQryQuoteField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcQryQuoteField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcQryQuoteField obj) {
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

  ~CThostFtdcQryQuoteField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcQryQuoteField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteSysID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_QuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_QuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTimeStart {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_InsertTimeStart_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_InsertTimeStart_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTimeEnd {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_InsertTimeEnd_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_InsertTimeEnd_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcQryQuoteField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcQryQuoteField() : this(CTPFutureApiPINVOKE.new_CThostFtdcQryQuoteField(), true) {
  }

}

}
