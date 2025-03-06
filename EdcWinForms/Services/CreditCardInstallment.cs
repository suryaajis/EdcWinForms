using NLog;
using SDK_POS_ezAIO.ezpay.edc;

namespace EdcWinForms.Services
{
    class CreditCardInstallment
    {
        #region 信用卡分期付款銷售
        public static void creditCardInstallment_Sale()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Installment;
            string transType = Constants.transactionType_Sale;
            string commPortName = "COM4";
            string transAmount = "1200";
            string installmentPeriod = "3";
            string posID = "A000123";

            RequestDataBuilder requestDataBuilder = new RequestDataBuilder();
            RequestData requestData = requestDataBuilder
                .MachineModel(machineModel)
                .HostID(hostID)
                .TransType(transType)
                .CommPortName(commPortName)
                .TransAmount(transAmount)
                .InstallmentPeriod(installmentPeriod)
                .POSID(posID)
                .Logger(logger)
                .Build();

            ResponseData responseData = EDC.run(requestData);
        }
        #endregion

        #region 信用卡分期付款退貨
        public static void creditCardInstallment_Refund()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Installment;
            string transType = Constants.transactionType_Refund;
            string commPortName = "COM4";
            string transAmount = "1200";
            string tradeNo = "21010404122531872";
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
        public static void creditCardInstallment_Settle()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Installment;
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

        #region 信用卡分期退貨取消
        public static void creditCardInstallment_VoidRefund()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_Installment;
            string transType = Constants.transactionType_VoidRefund;
            string commPortName = "COM4";
            string receiptNo = "000076";
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
