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

public class CThostFtdcInvestorPositionDetailField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInvestorPositionDetailField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInvestorPositionDetailField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(CThostFtdcInvestorPositionDetailField obj) {
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

  ~CThostFtdcInvestorPositionDetailField() {
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
          CTPFutureApiPINVOKE.delete_CThostFtdcInvestorPositionDetailField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public string reserve1 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_reserve1_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_reserve1_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public string OpenDate {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_OpenDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_OpenDate_get(swigCPtr);
      return ret;
    } 
  }

  public string TradeID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_TradeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_TradeID_get(swigCPtr);
      return ret;
    } 
  }

  public int Volume {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_Volume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_Volume_get(swigCPtr);
      return ret;
    } 
  }

  public double OpenPrice {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_OpenPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_OpenPrice_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public char TradeType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_TradeType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_TradeType_get(swigCPtr);
      return ret;
    } 
  }

  public string reserve2 {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_reserve2_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_reserve2_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByDate {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseProfitByTrade {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseProfitByTrade_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseProfitByTrade_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfitByDate {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_PositionProfitByDate_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_PositionProfitByDate_get(swigCPtr);
      return ret;
    } 
  }

  public double PositionProfitByTrade {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_PositionProfitByTrade_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_PositionProfitByTrade_get(swigCPtr);
      return ret;
    } 
  }

  public double Margin {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_Margin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_Margin_get(swigCPtr);
      return ret;
    } 
  }

  public double ExchMargin {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_ExchMargin_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_ExchMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByMoney {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_MarginRateByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_MarginRateByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double MarginRateByVolume {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_MarginRateByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_MarginRateByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double LastSettlementPrice {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_LastSettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_LastSettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double SettlementPrice {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_SettlementPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_SettlementPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int CloseVolume {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double CloseAmount {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseAmount_set(swigCPtr, value);
    } 
    get {
      double ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_CloseAmount_get(swigCPtr);
      return ret;
    } 
  }

  public int TimeFirstVolume {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_TimeFirstVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_TimeFirstVolume_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestUnitID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_InvestUnitID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_InvestUnitID_get(swigCPtr);
      return ret;
    } 
  }

  public char SpecPosiType {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_SpecPosiType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_SpecPosiType_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string CombInstrumentID {
    set {
      CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_CombInstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPFutureApiPINVOKE.CThostFtdcInvestorPositionDetailField_CombInstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInvestorPositionDetailField() : this(CTPFutureApiPINVOKE.new_CThostFtdcInvestorPositionDetailField(), true) {
  }

}

}