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

public class CThostFtdcUserRightsAssignField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcUserRightsAssignField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcUserRightsAssignField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcUserRightsAssignField obj) {
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

  ~CThostFtdcUserRightsAssignField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcUserRightsAssignField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcUserRightsAssignField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcUserRightsAssignField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcUserRightsAssignField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcUserRightsAssignField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public int DRIdentityID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcUserRightsAssignField_DRIdentityID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcUserRightsAssignField_DRIdentityID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcUserRightsAssignField() : this(CTPFutureApiPINVOKE.new_CThostFtdcUserRightsAssignField(), true) {
  }

}

}