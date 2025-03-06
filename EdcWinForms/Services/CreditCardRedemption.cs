using NLog;
using SDK_POS_ezAIO.ezpay.edc;

namespace EdcWinForms.Services
{
    class CreditCardRedemption
    {
        #region 信用卡紅利扣抵銷售
        public static void creditCardRedemption_Sale()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Redemption;
            string transType = Constants.transactionType_Sale;
            string commPortName = "COM4";
            string transAmount = "500";
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

        #region 信用卡紅利扣抵退貨
        public static void creditCardRedemption_Refund()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Redemption;
            string transType = Constants.transactionType_Refund;
            string commPortName = "COM4";
            string transAmount = "500";
            string tradeNo = "21010404235051232";
            string posID = "A000123";

            RequestDataBuilder requestDataBuilder = new RequestDataBuilder();
            RequestData requestData = requestDataBuilder
                .MachineModel(machineModel)
                .HostID(hostID)
                .TransType(transType)
                .CommPortName(commPortName)
                .TransAmount(transAmount)
                .TradeNo(tradeNo)
                .POSID(posID)
                .Logger(logger)
                .Build();

            ResponseData responseData = EDC.run(requestData);
        }
        #endregion

        #region 信用卡(結帳)(對信用卡、紅利、分期和銀聯進行結帳)
        public static void creditCardRedemption_Settle()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Redemption;
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

        #region 信用卡紅利扣抵退貨取消
        public static void creditCardRedemption_VoidRefund()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Redemption;
            string transType = Constants.transactionType_VoidRefund;
            string commPortName = "COM4";
            string receiptNo = "000079";
            string posID = "A000123";

            RequestDataBuilder requestDataBuilder = new RequestDataBuilder();
            RequestData requestData = requestDataBuilder
                .MachineModel(machineModel)
                .HostID(hostID)
                .TransType(transType)
                .CommPortName(commPortName)
                .POSID(posID)
                .ReceiptNo(receiptNo)
                .Logger(logger)
                .Build();

            ResponseData responseData = EDC.run(requestData);
        }
        #endregion
    }
}
