using NLog;
using SDK_POS_ezAIO.ezpay.edc;

namespace EdcWinForms.Services
{
    class Wallet
    {
        #region 電子錢包銷售
        public static void wallet_Sale()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Wallet;
            string transType = Constants.transactionType_Sale;
            string commPortName = "COM4";
            string transAmount = "200";
            string posID = "A000123";

            RequestDataBuilder requestDataBuilder = new RequestDataBuilder();
            RequestData requestData = requestDataBuilder
                .MachineModel(machineModel)
                .HostID(hostID)
                .TransType(transType)
                .CommPortName(commPortName)
                .TransAmount(transAmount)
                .POSID(posID)
                .Logger(logger)
                .Build();

            ResponseData responseData = EDC.run(requestData);
        }
        #endregion

        #region 電子錢包退貨
        public static void wallet_Refund()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Wallet;
            string transType = Constants.transactionType_Refund;
            string commPortName = "COM4";
            string tradeNo = "21010415473469935";
            string posID = "A000123";

            RequestDataBuilder requestDataBuilder = new RequestDataBuilder();
            RequestData requestData = requestDataBuilder
                .MachineModel(machineModel)
                .HostID(hostID)
                .TransType(transType)
                .CommPortName(commPortName)
                .TradeNo(tradeNo)
                .POSID(posID)
                .Logger(logger)
                .Build();

            ResponseData responseData = EDC.run(requestData);
        }
        #endregion

        #region 電子錢包交易查詢
        public static void wallet_WalletInquiry()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Wallet;
            string transType = Constants.transactionType_WalletInquiry;
            string commPortName = "COM4";
            string tradeNo = "21010415463335772";
            string posID = "A000123";

            RequestDataBuilder requestDataBuilder = new RequestDataBuilder();
            RequestData requestData = requestDataBuilder
                .MachineModel(machineModel)
                .HostID(hostID)
                .TransType(transType)
                .CommPortName(commPortName)
                .TradeNo(tradeNo)
                .POSID(posID)
                .Logger(logger)
                .Build();

            ResponseData responseData = EDC.run(requestData);
        }
        #endregion

        #region 電子錢包結帳
        public static void wallet_Settle()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Wallet;
            string transType = Constants.transactionType_Settle;
            string commPortName = "COM4";
            string posID = "A000123";

            RequestDataBuilder requestDataBuilder = new RequestDataBuilder();
            RequestData requestData = requestDataBuilder
                .MachineModel(machineModel)
                .HostID(hostID)
                .TransType(transType)
                .CommPortName(commPortName)
                .POSID(posID)
                .Logger(logger)
                .Build();

            ResponseData responseData = EDC.run(requestData);
        }
        #endregion
    }
}
