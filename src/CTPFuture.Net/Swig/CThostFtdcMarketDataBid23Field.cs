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

public class CThostFtdcMarketDataBid23Field : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMarketDataBid23Field(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMarketDataBid23Field obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcMarketDataBid23Field obj) {
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

  ~CThostFtdcMarketDataBid23Field() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcMarketDataBid23Field(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public double BidPrice2 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcMarketDataBid23Field_BidPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcMarketDataBid23Field_BidPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume2 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcMarketDataBid23Field_BidVolume2_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcMarketDataBid23Field_BidVolume2_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice3 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcMarketDataBid23Field_BidPrice3_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcMarketDataBid23Field_BidPrice3_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume3 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcMarketDataBid23Field_BidVolume3_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcMarketDataBid23Field_BidVolume3_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMarketDataBid23Field() : this(CTPFutureApiPINVOKE.new_CThostFtdcMarketDataBid23Field(), true) {
  }

}

}
