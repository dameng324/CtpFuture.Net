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

public class CThostFtdcInvestorWithdrawAlgorithmField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorWithdrawAlgorithmField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorWithdrawAlgorithmField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcInvestorWithdrawAlgorithmField obj) {
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

  ~CThostFtdcInvestorWithdrawAlgorithmField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcInvestorWithdrawAlgorithmField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public char InvestorRange {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorRange_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorRange_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public double UsingRatio {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_UsingRatio_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_UsingRatio_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double FundMortgageRatio {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_FundMortgageRatio_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorWithdrawAlgorithmField_FundMortgageRatio_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorWithdrawAlgorithmField() : this(CTPFutureApiPINVOKE.new_CThostFtdcInvestorWithdrawAlgorithmField(), true) {
  }

}

}