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

public class CThostFtdcSyncDelaySwapFrozenField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcSyncDelaySwapFrozenField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcSyncDelaySwapFrozenField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcSyncDelaySwapFrozenField obj) {
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

  ~CThostFtdcSyncDelaySwapFrozenField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcSyncDelaySwapFrozenField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string DelaySwapSeqNo {
    set {
      CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_DelaySwapSeqNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_DelaySwapSeqNo_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string FromCurrencyID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_FromCurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_FromCurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double FromRemainSwap {
    set {
      CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_FromRemainSwap_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_FromRemainSwap_get(swigCPtr);
      return ret;
    } 
  }

  public int IsManualSwap {
    set {
      CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_IsManualSwap_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcSyncDelaySwapFrozenField_IsManualSwap_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcSyncDelaySwapFrozenField() : this(CTPFutureApiPINVOKE.new_CThostFtdcSyncDelaySwapFrozenField(), true) {
  }

}

}