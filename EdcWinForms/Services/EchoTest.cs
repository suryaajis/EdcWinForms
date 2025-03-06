using NLog;
using SDK_POS_ezAIO.ezpay.edc;

namespace EdcWinForms.Services
{
    class EchoTest
    {
        public static void echoTest()
        {
            Logger logger = LogManager.GetCurrentClassLogger();

            string machineModel = Constants.machineModel_AS350_v1_51;
            string transType = Constants.transactionType_EchoTest;
            string commPortName = "COM4";

            RequestDataBuilder requestDataBuilder = new RequestDataBuilder();
            RequestData requestData = requestDataBuilder
                .MachineModel(machineModel)
                .TransType(transType)
                .CommPortName(commPortName)
                .Logger(logger)
                .Build();

            ResponseData responseData = EDC.run(requestData);
        }
    }
}
