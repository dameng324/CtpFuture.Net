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

public class CThostFtdcRspRepealField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcRspRepealField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcRspRepealField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcRspRepealField obj) {
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

  ~CThostFtdcRspRepealField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcRspRepealField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public int RepealTimeInterval {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_RepealTimeInterval_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_RepealTimeInterval_get(swigCPtr);
      return ret;
    } 
  }

  public int RepealedTimes {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_RepealedTimes_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_RepealedTimes_get(swigCPtr);
      return ret;
    } 
  }

  public char BankRepealFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankRepealFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankRepealFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BrokerRepealFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BrokerRepealFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BrokerRepealFlag_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateRepealSerial {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_PlateRepealSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_PlateRepealSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string BankRepealSerial {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankRepealSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankRepealSerial_get(swigCPtr);
      return ret;
    } 
  }

  public int FutureRepealSerial {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_FutureRepealSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_FutureRepealSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeCode {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TradeCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TradeCode_get(swigCPtr);
      return ret;
    } 
  }

  public string BankID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankID_get(swigCPtr);
      return ret;
    } 
  }

  public string BankBranchID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerBranchID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BrokerBranchID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BrokerBranchID_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeDate {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeTime {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TradeTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TradeTime_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSerial {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankSerial_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int PlateSerial {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_PlateSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_PlateSerial_get(swigCPtr);
      return ret;
    } 
  }

  public char LastFragment {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_LastFragment_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_LastFragment_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string CustomerName {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_CustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_CustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public char IdCardType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_IdCardType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_IdCardType_get(swigCPtr);
      return ret;
    } 
  }

  public string IdentifiedCardNo {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_IdentifiedCardNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_IdentifiedCardNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CustType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_CustType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_CustType_get(swigCPtr);
      return ret;
    } 
  }

  public string BankAccount {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankAccount_get(swigCPtr);
      return ret;
    } 
  }

  public string BankPassWord {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankPassWord_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankPassWord_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public int FutureSerial {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_FutureSerial_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_FutureSerial_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char VerifyCertNoFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_VerifyCertNoFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_VerifyCertNoFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeAmount {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TradeAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TradeAmount_get(swigCPtr);
      return ret;
    } 
  }

  public double FutureFetchAmount {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_FutureFetchAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_FutureFetchAmount_get(swigCPtr);
      return ret;
    } 
  }

  public char FeePayFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_FeePayFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_FeePayFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double CustFee {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_CustFee_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_CustFee_get(swigCPtr);
      return ret;
    } 
  }

  public double BrokerFee {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BrokerFee_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BrokerFee_get(swigCPtr);
      return ret;
    } 
  }

  public string Message {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_Message_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_Message_get(swigCPtr);
      return ret;
    } 
  }

  public string Digest {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_Digest_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_Digest_get(swigCPtr);
      return ret;
    } 
  }

  public char BankAccType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string DeviceID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_DeviceID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_DeviceID_get(swigCPtr);
      return ret;
    } 
  }

  public char BankSecuAccType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankSecuAccType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankSecuAccType_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerIDByBank {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BrokerIDByBank_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BrokerIDByBank_get(swigCPtr);
      return ret;
    } 
  }

  public string BankSecuAcc {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankSecuAcc_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankSecuAcc_get(swigCPtr);
      return ret;
    } 
  }

  public char BankPwdFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_BankPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char SecuPwdFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_SecuPwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_SecuPwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string OperNo {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_OperNo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_OperNo_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int TID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TID_get(swigCPtr);
      return ret;
    } 
  }

  public char TransferStatus {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TransferStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_TransferStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public string LongCustomerName {
    set {
      CTPFutureApiPINVOKE.CThostFtdcRspRepealField_LongCustomerName_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcRspRepealField_LongCustomerName_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcRspRepealField() : this(CTPFutureApiPINVOKE.new_CThostFtdcRspRepealField(), true) {
  }

}

}