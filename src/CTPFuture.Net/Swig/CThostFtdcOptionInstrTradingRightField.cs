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

public class CThostFtdcOptionInstrTradingRightField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcOptionInstrTradingRightField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcOptionInstrTradingRightField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcOptionInstrTradingRightField obj) {
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

  ~CThostFtdcOptionInstrTradingRightField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcOptionInstrTradingRightField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string reserve1 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public char TradingRight {
    set {
      CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_TradingRight_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_TradingRight_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcOptionInstrTradingRightField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcOptionInstrTradingRightField() : this(CTPFutureApiPINVOKE.new_CThostFtdcOptionInstrTradingRightField(), true) {
  }

}

}