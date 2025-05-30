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

public class CThostFtdcLinkManField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcLinkManField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcLinkManField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcLinkManField obj) {
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

  ~CThostFtdcLinkManField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcLinkManField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char PersonType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_PersonType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_PersonType_get(swigCPtr);
      return ret;
    } 
  }

  public char IdentifiedCardType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_IdentifiedCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_IdentifiedCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public string PersonName {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_PersonName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_PersonName_get(swigCPtr);
      return ret;
    } 
  }

  public string Telephone {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_Telephone_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_Telephone_get(swigCPtr);
      return ret;
    } 
  }

  public string Address {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_Address_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_Address_get(swigCPtr);
      return ret;
    } 
  }

  public string ZipCode {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_ZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_ZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public int Priority {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_Priority_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_Priority_get(swigCPtr);
      return ret;
    } 
  }

  public string UOAZipCode {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_UOAZipCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_UOAZipCode_get(swigCPtr);
      return ret;
    } 
  }

  public string PersonFullName {
    set {
      CTPFutureApiPINVOKE.CThostFtdcLinkManField_PersonFullName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcLinkManField_PersonFullName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcLinkManField() : this(CTPFutureApiPINVOKE.new_CThostFtdcLinkManField(), true) {
  }

}

}
