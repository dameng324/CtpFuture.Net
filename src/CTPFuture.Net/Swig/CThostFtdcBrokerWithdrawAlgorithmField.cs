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

public class CThostFtdcBrokerWithdrawAlgorithmField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcBrokerWithdrawAlgorithmField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcBrokerWithdrawAlgorithmField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcBrokerWithdrawAlgorithmField obj) {
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

  ~CThostFtdcBrokerWithdrawAlgorithmField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcBrokerWithdrawAlgorithmField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public char WithdrawAlgorithm {
    set {
      CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_WithdrawAlgorithm_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_WithdrawAlgorithm_get(swigCPtr);
      return ret;
    } 
  }

  public double UsingRatio {
    set {
      CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_UsingRatio_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_UsingRatio_get(swigCPtr);
      return ret;
    } 
  }

  public char IncludeCloseProfit {
    set {
      CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_IncludeCloseProfit_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_IncludeCloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public char AllWithoutTrade {
    set {
      CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_AllWithoutTrade_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_AllWithoutTrade_get(swigCPtr);
      return ret;
    } 
  }

  public char AvailIncludeCloseProfit {
    set {
      CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_AvailIncludeCloseProfit_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_AvailIncludeCloseProfit_get(swigCPtr);
      return ret;
    } 
  }

  public int IsBrokerUserEvent {
    set {
      CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_IsBrokerUserEvent_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_IsBrokerUserEvent_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageRatio {
    set {
      CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_FundMortgageRatio_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_FundMortgageRatio_get(swigCPtr);
      return ret;
    } 
  }

  public char BalanceAlgorithm {
    set {
      CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_BalanceAlgorithm_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcBrokerWithdrawAlgorithmField_BalanceAlgorithm_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcBrokerWithdrawAlgorithmField() : this(CTPFutureApiPINVOKE.new_CThostFtdcBrokerWithdrawAlgorithmField(), true) {
  }

}

}