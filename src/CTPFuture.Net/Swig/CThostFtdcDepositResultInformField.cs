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

public class CThostFtdcDepositResultInformField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcDepositResultInformField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcDepositResultInformField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcDepositResultInformField obj) {
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

  ~CThostFtdcDepositResultInformField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcDepositResultInformField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string DepositSeqNo {
    set {
      CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_DepositSeqNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_DepositSeqNo_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public double Deposit {
    set {
      CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_Deposit_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_Deposit_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string ReturnCode {
    set {
      CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_ReturnCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_ReturnCode_get(swigCPtr);
      return ret;
    } 
  }

  public string DescrInfoForReturnCode {
    set {
      CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_DescrInfoForReturnCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcDepositResultInformField_DescrInfoForReturnCode_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcDepositResultInformField() : this(CTPFutureApiPINVOKE.new_CThostFtdcDepositResultInformField(), true) {
  }

}

}
