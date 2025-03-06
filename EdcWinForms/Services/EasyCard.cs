using NLog;
using SDK_POS_ezAIO.ezpay.edc;

namespace EdcWinForms.Services
{
    class EasyCard
    {
        #region 悠遊卡電子票證購貨
        public static void easyCard_ESVCPurchase()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_EasyCard;
            string transType = Constants.transactionType_ESVCPurchase;
            string commPortName = "COM4";
            string transAmount = "100";
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

        #region 悠遊卡電子票證退貨
        public static void easyCard_ESVCRefund()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_EasyCard;
            string transType = Constants.transactionType_ESVCRefund;
            string commPortName = "COM4";
            string transAmount = "100";
            string posID = "A000123";
            string referenceNo = "20062200016439";

            RequestDataBuilder requestDataBuilder = new RequestDataBuilder();
            RequestData requestData = requestDataBuilder
                .MachineModel(machineModel)
                .HostID(hostID)
                .TransType(transType)
                .CommPortName(commPortName)
                .TransAmount(transAmount)
                .POSID(posID)
                .ReferenceNo(referenceNo)
                .Logger(logger)
                .Build();

            ResponseData responseData = EDC.run(requestData);
        }
        #endregion

        #region 悠遊卡電子票證餘額查詢
        public static void easyCard_ESVCBalanceInquiry()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_EasyCard;
            string transType = Constants.transactionType_ESVCBalanceInquiry;
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

        #region 悠遊卡結帳
        public static void easyCard_Settle()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string hostID = Constants.hostID_EasyCard;
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
