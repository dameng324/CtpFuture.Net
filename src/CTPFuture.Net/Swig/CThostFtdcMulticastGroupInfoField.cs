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

public class CThostFtdcMulticastGroupInfoField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMulticastGroupInfoField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMulticastGroupInfoField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcMulticastGroupInfoField obj) {
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

  ~CThostFtdcMulticastGroupInfoField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcMulticastGroupInfoField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string GroupIP {
    set {
      CTPFutureApiPINVOKE.CThostFtdcMulticastGroupInfoField_GroupIP_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcMulticastGroupInfoField_GroupIP_get(swigCPtr);
      return ret;
    } 
  }

  public int GroupPort {
    set {
      CTPFutureApiPINVOKE.CThostFtdcMulticastGroupInfoField_GroupPort_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcMulticastGroupInfoField_GroupPort_get(swigCPtr);
      return ret;
    } 
  }

  public string SourceIP {
    set {
      CTPFutureApiPINVOKE.CThostFtdcMulticastGroupInfoField_SourceIP_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcMulticastGroupInfoField_SourceIP_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMulticastGroupInfoField() : this(CTPFutureApiPINVOKE.new_CThostFtdcMulticastGroupInfoField(), true) {
  }

}

}
