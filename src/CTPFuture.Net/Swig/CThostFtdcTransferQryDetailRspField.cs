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

public class CThostFtdcTransferQryDetailRspField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTransferQryDetailRspField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTransferQryDetailRspField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcTransferQryDetailRspField obj) {
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

  ~CThostFtdcTransferQryDetailRspField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcTransferQryDetailRspField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string TradeDate {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeCode {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public int FutureSerial {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_FutureSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_FutureSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string FutureID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_FutureID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_FutureID_get(swigCPtr);
      return ret;
    } 
  }

  public string FutureAccount {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_FutureAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_FutureAccount_get(swigCPtr);
      return ret;
    } 
  }

  public int BankSerial {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_BankSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBrchID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_BankBrchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_BankBrchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string CertCode {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_CertCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_CertCode_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyCode {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_CurrencyCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_CurrencyCode_get(swigCPtr);
      return ret;
    } 
  }

  public double TxAmount {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_TxAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_TxAmount_get(swigCPtr);
      return ret;
    } 
  }

  public char Flag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_Flag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcTransferQryDetailRspField_Flag_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTransferQryDetailRspField() : this(CTPFutureApiPINVOKE.new_CThostFtdcTransferQryDetailRspField(), true) {
  }

}

}