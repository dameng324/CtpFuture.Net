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

public class CThostFtdcInstrumentMarginRateAdjustField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInstrumentMarginRateAdjustField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInstrumentMarginRateAdjustField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcInstrumentMarginRateAdjustField obj) {
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

  ~CThostFtdcInstrumentMarginRateAdjustField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcInstrumentMarginRateAdjustField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string InstrumentID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByMoney {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByVolume {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_LongMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByMoney {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByVolume {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_ShortMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int IsRelative {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_IsRelative_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInstrumentMarginRateAdjustField_IsRelative_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInstrumentMarginRateAdjustField() : this(CTPFutureApiPINVOKE.new_CThostFtdcInstrumentMarginRateAdjustField(), true) {
  }

}

}
