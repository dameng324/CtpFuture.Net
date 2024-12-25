using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CtpFuture.Net.Swig;

namespace CtpFuture;

public class CtpTdApi : CThostFtdcTraderSpi
{
    static CtpTdApi()
    {
        SwigStringHelper.Register();
    }

    public CtpTdApi(string pszFlowPath)
    {
        Api = CThostFtdcTraderApi.CreateFtdcTraderApi(pszFlowPath);
        Api.RegisterSpi(this);
        Api.SubscribePrivateTopic(THOST_TE_RESUME_TYPE.THOST_TERT_QUICK);
        Api.SubscribePublicTopic(THOST_TE_RESUME_TYPE.THOST_TERT_QUICK);
    }

    public static string GetVersion()
    {
        return CThostFtdcTraderApi.GetApiVersion();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            Api.Release();
            Api = null!;
        }
        base.Dispose(disposing);
    }

    public CThostFtdcTraderApi Api { get; private set; }

    // regex replace
    // public override void On([a-z]*)\((.*)\)
    // public delegate void $1Delegate ($2); public event $1Delegate? $1Event; public override void On$1($2)

    public delegate void FrontConnectedDelegate();
    public event FrontConnectedDelegate? OnFrontConnectedEvent;

    public IObservable<Unit> FrontConnectedAsObservable()
    {
        return Observable.FromEvent<FrontConnectedDelegate, Unit>(handler => () => handler(Unit.Default), h => OnFrontConnectedEvent += h, h => OnFrontConnectedEvent -= h);
    }

    public override void OnFrontConnected()
    {
        OnFrontConnectedEvent?.Invoke();
    }

    public IObservable<int> FrontDisconnectedAsObservable()
    {
        return Observable.FromEvent<FrontDisconnectedDelegate, int>(handler => (t) => handler(t), h => OnFrontDisconnectedEvent += h, h => OnFrontDisconnectedEvent -= h);
    }

    public delegate void FrontDisconnectedDelegate(int reason);
    public event FrontDisconnectedDelegate? OnFrontDisconnectedEvent;

    public override void OnFrontDisconnected(int reason)
    {
        OnFrontDisconnectedEvent?.Invoke(reason);
    }

    public IObservable<int> HeartBeatWarningAsObservable()
    {
        return Observable.FromEvent<HeartBeatWarningDelegate, int>(handler => (t) => handler(t), h => OnHeartBeatWarningEvent += h, h => OnHeartBeatWarningEvent -= h);
    }

    public delegate void HeartBeatWarningDelegate(int pTimeLapes);
    public event HeartBeatWarningDelegate? OnHeartBeatWarningEvent;

    public override void OnHeartBeatWarning(int pTimeLapes)
    {
        OnHeartBeatWarningEvent?.Invoke(pTimeLapes);
    }

    public IObservable<(CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspErrorAsObservable()
    {
        return Observable.FromEvent<RspErrorDelegate, (CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(handler => (p, n, b) => handler((p, n, b)), h => OnRspErrorEvent += h, h => OnRspErrorEvent -= h);
    }

    public delegate void RspErrorDelegate(CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspErrorDelegate? OnRspErrorEvent;

    public override void OnRspError(CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspErrorEvent?.Invoke(pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcRspUserLoginField? pRspUserLogin, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspUserLoginAsObservable()
    {
        return Observable.FromEvent<RspUserLoginDelegate, (CThostFtdcRspUserLoginField? pRspUserLogin, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspUserLoginEvent += h,
            h => OnRspUserLoginEvent -= h
        );
    }

    public delegate void RspUserLoginDelegate(CThostFtdcRspUserLoginField? pRspUserLogin, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspUserLoginDelegate? OnRspUserLoginEvent;

    public override void OnRspUserLogin(CThostFtdcRspUserLoginField? pRspUserLogin, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspUserLoginEvent?.Invoke(pRspUserLogin, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcUserLogoutField? pUserLogout, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspUserLogoutAsObservable()
    {
        return Observable.FromEvent<RspUserLogoutDelegate, (CThostFtdcUserLogoutField? pUserLogout, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspUserLogoutEvent += h,
            h => OnRspUserLogoutEvent -= h
        );
    }

    public delegate void RspUserLogoutDelegate(CThostFtdcUserLogoutField? pUserLogout, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspUserLogoutDelegate? OnRspUserLogoutEvent;

    public override void OnRspUserLogout(CThostFtdcUserLogoutField? pUserLogout, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspUserLogoutEvent?.Invoke(pUserLogout, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcInstrumentField? pInstrument, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspQryInstrumentAsObservable()
    {
        return Observable.FromEvent<RspQryInstrumentDelegate, (CThostFtdcInstrumentField? pInstrument, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQryInstrumentEvent += h,
            h => OnRspQryInstrumentEvent -= h
        );
    }

    public delegate void RspQryInstrumentDelegate(CThostFtdcInstrumentField? pInstrument, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQryInstrumentDelegate? OnRspQryInstrumentEvent;

    public override void OnRspQryInstrument(CThostFtdcInstrumentField? pInstrument, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQryInstrumentEvent?.Invoke(pInstrument, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcInvestorPositionField? pInvestorPosition, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspQryInvestorPositionAsObservable()
    {
        return Observable.FromEvent<RspQryInvestorPositionDelegate, (CThostFtdcInvestorPositionField? pInvestorPosition, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQryInvestorPositionEvent += h,
            h => OnRspQryInvestorPositionEvent -= h
        );
    }

    public delegate void RspQryInvestorPositionDelegate(CThostFtdcInvestorPositionField? pInvestorPosition, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQryInvestorPositionDelegate? OnRspQryInvestorPositionEvent;

    public override void OnRspQryInvestorPosition(CThostFtdcInvestorPositionField? pInvestorPosition, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQryInvestorPositionEvent?.Invoke(pInvestorPosition, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcInvestorPositionDetailField? pInvestorPositionDetail, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspQryInvestorPositionDetailAsObservable()
    {
        return Observable.FromEvent<RspQryInvestorPositionDetailDelegate, (CThostFtdcInvestorPositionDetailField? pInvestorPositionDetail, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQryInvestorPositionDetailEvent += h,
            h => OnRspQryInvestorPositionDetailEvent -= h
        );
    }

    public delegate void RspQryInvestorPositionDetailDelegate(CThostFtdcInvestorPositionDetailField? pInvestorPositionDetail, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQryInvestorPositionDetailDelegate? OnRspQryInvestorPositionDetailEvent;

    public override void OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField? pInvestorPositionDetail, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQryInvestorPositionDetailEvent?.Invoke(pInvestorPositionDetail, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<CThostFtdcOrderField?> RtnOrderAsObservable()
    {
        return Observable.FromEvent<RtnOrderDelegate, CThostFtdcOrderField?>(handler => (p) => handler(p), h => OnRtnOrderEvent += h, h => OnRtnOrderEvent -= h);
    }

    public delegate void RtnOrderDelegate(CThostFtdcOrderField? pOrder);
    public event RtnOrderDelegate? OnRtnOrderEvent;

    public override void OnRtnOrder(CThostFtdcOrderField? pOrder)
    {
        OnRtnOrderEvent?.Invoke(pOrder);
    }

    public IObservable<CThostFtdcTradeField?> RtnTradeAsObservable()
    {
        return Observable.FromEvent<RtnTradeDelegate, CThostFtdcTradeField?>(handler => (p) => handler(p), h => OnRtnTradeEvent += h, h => OnRtnTradeEvent -= h);
    }

    public delegate void RtnTradeDelegate(CThostFtdcTradeField? pTrade);
    public event RtnTradeDelegate? OnRtnTradeEvent;

    public override void OnRtnTrade(CThostFtdcTradeField? pTrade)
    {
        OnRtnTradeEvent?.Invoke(pTrade);
    }

    public IObservable<(CThostFtdcInputOrderField? pInputOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspOrderInsertAsObservable()
    {
        return Observable.FromEvent<RspOrderInsertDelegate, (CThostFtdcInputOrderField? pInputOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspOrderInsertEvent += h,
            h => OnRspOrderInsertEvent -= h
        );
    }

    public delegate void RspOrderInsertDelegate(CThostFtdcInputOrderField? pInputOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspOrderInsertDelegate? OnRspOrderInsertEvent;

    public override void OnRspOrderInsert(CThostFtdcInputOrderField? pInputOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspOrderInsertEvent?.Invoke(pInputOrder, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcInputOrderActionField? pInputOrderAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspOrderActionAsObservable()
    {
        return Observable.FromEvent<RspOrderActionDelegate, (CThostFtdcInputOrderActionField? pInputOrderAction, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspOrderActionEvent += h,
            h => OnRspOrderActionEvent -= h
        );
    }

    public delegate void RspOrderActionDelegate(CThostFtdcInputOrderActionField? pInputOrderAction, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspOrderActionDelegate? OnRspOrderActionEvent;

    public override void OnRspOrderAction(CThostFtdcInputOrderActionField? pInputOrderAction, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspOrderActionEvent?.Invoke(pInputOrderAction, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcOrderField? pOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)> RspQryOrderAsObservable()
    {
        return Observable.FromEvent<RspQryOrderDelegate, (CThostFtdcOrderField? pOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQryOrderEvent += h,
            h => OnRspQryOrderEvent -= h
        );
    }

    public delegate void RspQryOrderDelegate(CThostFtdcOrderField? pOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQryOrderDelegate? OnRspQryOrderEvent;

    public override void OnRspQryOrder(CThostFtdcOrderField? pOrder, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQryOrderEvent?.Invoke(pOrder, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcTradeField? pTrade, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspQryTradeAsObservable()
    {
        return Observable.FromEvent<RspQryTradeDelegate, (CThostFtdcTradeField? pTrade, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQryTradeEvent += h,
            h => OnRspQryTradeEvent -= h
        );
    }

    public delegate void RspQryTradeDelegate(CThostFtdcTradeField? pTrade, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQryTradeDelegate? OnRspQryTradeEvent;

    public override void OnRspQryTrade(CThostFtdcTradeField? pTrade, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQryTradeEvent?.Invoke(pTrade, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspQrySettlementInfoConfirmAsObservable()
    {
        return Observable.FromEvent<RspQrySettlementInfoConfirmDelegate, (CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQrySettlementInfoConfirmEvent += h,
            h => OnRspQrySettlementInfoConfirmEvent -= h
        );
    }

    public delegate void RspQrySettlementInfoConfirmDelegate(CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQrySettlementInfoConfirmDelegate? OnRspQrySettlementInfoConfirmEvent;

    public override void OnRspQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQrySettlementInfoConfirmEvent?.Invoke(pSettlementInfoConfirm, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcSettlementInfoField? pSettlementInfo, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspQrySettlementInfoAsObservable()
    {
        return Observable.FromEvent<RspQrySettlementInfoDelegate, (CThostFtdcSettlementInfoField? pSettlementInfo, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQrySettlementInfoEvent += h,
            h => OnRspQrySettlementInfoEvent -= h
        );
    }

    public delegate void RspQrySettlementInfoDelegate(CThostFtdcSettlementInfoField? pSettlementInfo, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQrySettlementInfoDelegate? OnRspQrySettlementInfoEvent;

    public override void OnRspQrySettlementInfo(CThostFtdcSettlementInfoField? pSettlementInfo, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQrySettlementInfoEvent?.Invoke(pSettlementInfo, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcTradingAccountField? pTradingAccount, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspQryTradingAccountAsObservable()
    {
        return Observable.FromEvent<RspQryTradingAccountDelegate, (CThostFtdcTradingAccountField? pTradingAccount, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQryTradingAccountEvent += h,
            h => OnRspQryTradingAccountEvent -= h
        );
    }

    public delegate void RspQryTradingAccountDelegate(CThostFtdcTradingAccountField? pTradingAccount, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQryTradingAccountDelegate? OnRspQryTradingAccountEvent;

    public override void OnRspQryTradingAccount(CThostFtdcTradingAccountField? pTradingAccount, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQryTradingAccountEvent?.Invoke(pTradingAccount, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<CThostFtdcInstrumentStatusField?> RtnInstrumentStatusAsObservable()
    {
        return Observable.FromEvent<RtnInstrumentStatusDelegate, CThostFtdcInstrumentStatusField?>(handler => (p) => handler(p), h => OnRtnInstrumentStatusEvent += h, h => OnRtnInstrumentStatusEvent -= h);
    }

    public delegate void RtnInstrumentStatusDelegate(CThostFtdcInstrumentStatusField? pInstrumentStatus);
    public event RtnInstrumentStatusDelegate? OnRtnInstrumentStatusEvent;

    public override void OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField? pInstrumentStatus)
    {
        OnRtnInstrumentStatusEvent?.Invoke(pInstrumentStatus);
    }

    public IObservable<(CThostFtdcInvestorField? pInvestor, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspQryInvestorAsObservable()
    {
        return Observable.FromEvent<RspQryInvestorDelegate, (CThostFtdcInvestorField? pInvestor, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQryInvestorEvent += h,
            h => OnRspQryInvestorEvent -= h
        );
    }

    public delegate void RspQryInvestorDelegate(CThostFtdcInvestorField? pInvestor, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQryInvestorDelegate? OnRspQryInvestorEvent;

    public override void OnRspQryInvestor(CThostFtdcInvestorField? pInvestor, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQryInvestorEvent?.Invoke(pInvestor, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcDepthMarketDataField? pDepthMarketData, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspQryDepthMarketDataAsObservable()
    {
        return Observable.FromEvent<RspQryDepthMarketDataDelegate, (CThostFtdcDepthMarketDataField? pDepthMarketData, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQryDepthMarketDataEvent += h,
            h => OnRspQryDepthMarketDataEvent -= h
        );
    }

    public delegate void RspQryDepthMarketDataDelegate(CThostFtdcDepthMarketDataField? pDepthMarketData, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQryDepthMarketDataDelegate? OnRspQryDepthMarketDataEvent;

    public override void OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField? pDepthMarketData, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQryDepthMarketDataEvent?.Invoke(pDepthMarketData, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcRspAuthenticateField? pRspAuthenticateField, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspAuthenticateAsObservable()
    {
        return Observable.FromEvent<RspAuthenticateDelegate, (CThostFtdcRspAuthenticateField? pRspAuthenticateField, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspAuthenticateEvent += h,
            h => OnRspAuthenticateEvent -= h
        );
    }

    public delegate void RspAuthenticateDelegate(CThostFtdcRspAuthenticateField? pRspAuthenticateField, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspAuthenticateDelegate? OnRspAuthenticateEvent;

    public override void OnRspAuthenticate(CThostFtdcRspAuthenticateField? pRspAuthenticateField, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspAuthenticateEvent?.Invoke(pRspAuthenticateField, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcInstrumentMarginRateField? pInstrumentMarginRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspQryInstrumentMarginRateAsObservable()
    {
        return Observable.FromEvent<RspQryInstrumentMarginRateDelegate, (CThostFtdcInstrumentMarginRateField? pInstrumentMarginRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQryInstrumentMarginRateEvent += h,
            h => OnRspQryInstrumentMarginRateEvent -= h
        );
    }

    public delegate void RspQryInstrumentMarginRateDelegate(CThostFtdcInstrumentMarginRateField? pInstrumentMarginRate, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQryInstrumentMarginRateDelegate? OnRspQryInstrumentMarginRateEvent;

    public override void OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField? pInstrumentMarginRate, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQryInstrumentMarginRateEvent?.Invoke(pInstrumentMarginRate, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcInstrumentCommissionRateField? pInstrumentCommissionRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspQryInstrumentCommissionRateAsObservable()
    {
        return Observable.FromEvent<RspQryInstrumentCommissionRateDelegate, (CThostFtdcInstrumentCommissionRateField? pInstrumentCommissionRate, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspQryInstrumentCommissionRateEvent += h,
            h => OnRspQryInstrumentCommissionRateEvent -= h
        );
    }

    public delegate void RspQryInstrumentCommissionRateDelegate(CThostFtdcInstrumentCommissionRateField? pInstrumentCommissionRate, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspQryInstrumentCommissionRateDelegate? OnRspQryInstrumentCommissionRateEvent;

    public override void OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField? pInstrumentCommissionRate, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspQryInstrumentCommissionRateEvent?.Invoke(pInstrumentCommissionRate, pRspInfo, nRequestId, bIsLast);
    }

    public IObservable<(CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)> RspSettlementInfoConfirmAsObservable()
    {
        return Observable.FromEvent<RspSettlementInfoConfirmDelegate, (CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm, CThostFtdcRspInfoField? pRspInfo, int nRequestID, bool bIsLast)>(
            handler => (p, i, n, b) => handler((p, i, n, b)),
            h => OnRspSettlementInfoConfirmEvent += h,
            h => OnRspSettlementInfoConfirmEvent -= h
        );
    }

    public delegate void RspSettlementInfoConfirmDelegate(CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast);
    public event RspSettlementInfoConfirmDelegate? OnRspSettlementInfoConfirmEvent;

    public override void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField? pSettlementInfoConfirm, CThostFtdcRspInfoField? pRspInfo, int nRequestId, bool bIsLast)
    {
        OnRspSettlementInfoConfirmEvent?.Invoke(pSettlementInfoConfirm, pRspInfo, nRequestId, bIsLast);
    }
}
