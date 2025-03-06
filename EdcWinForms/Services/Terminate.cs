using NLog;
using SDK_POS_ezAIO.ezpay.edc;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EdcWinForms.Services
{
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        CreditCardSale creditCard = new CreditCardSale();
    //        Task<ResponseData> result1 = new Task<ResponseData>(CreditCardSale.DoCreditCardSale);
    //        Thread thread1 = new Thread(result1.Start);
    //        thread1.Start();

    //        // 開始計時
    //        long runTime = getSystemTime();

    //        // 模擬觸發70(終止交易)的時間，先用距離發動交易的時間58秒舉例(秒數可<59但不可>=59)，因大於等於59秒卡機自己會回覆連線逾時的訊息
    //        Thread.Sleep(58000);

    //        // 距離發動交易的時間小於59秒(卡機畫面的等待時間約60秒)才觸發70(終止交易)，若大於等於59秒時就不會有動作，卡機自己會回覆連線逾時的訊息
    //        long stopTime = getSystemTime();
    //        if (stopTime - runTime < 59 * 1000)
    //        {
    //            Terminate terminate = new Terminate();
    //            Task<ResponseData> result2 = new Task<ResponseData>(terminate.DoTerminate);
    //            Thread thread2 = new Thread(result2.Start);
    //            thread2.Start();
    //            Console.WriteLine("creditcard 返回結果:" + result1.Result.toString());
    //            Console.WriteLine("terminate 返回結果:" + result2.Result.toString());
    //        }

    //        Console.ReadKey();
    //    }

    //    public static long getSystemTime()
    //    {
    //        return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;
    //    }
    //}
    
    //#region 這裡用信用卡購貨舉例，但可替換成上述其他適用於中止的交易，如信用卡退貨、信用卡預先授權等
    //public class CreditCardSale {
    //    public static ResponseData DoCreditCardSale()
    //    {
    //        Logger logger = LogManager.GetCurrentClassLogger();

    //        RequestDataBuilder requestDataBuilder = new RequestDataBuilder();
    //        RequestData requestData = new RequestData();
    //        ResponseData responseData = new ResponseData();

    //        string machineModel = Constants.machineModel_AS350_v1_51;
    //        string hostID = Constants.hostID_CreditCard;
    //        string transType = Constants.transactionType_Sale;
    //        string commPortName = "COM4";
    //        string transAmount = "100";
    //        string posID = "A000123";

    //        requestData = requestDataBuilder
    //            .MachineModel(machineModel)
    //            .HostID(hostID)
    //            .TransType(transType)
    //            .CommPortName(commPortName)
    //            .TransAmount(transAmount)
    //            .POSID(posID)
    //            .Logger(logger)
    //            .Build();

    //        responseData = EDC.run(requestData);

    //        return responseData;
    //    }
    //}
    //#endregion

    //#region 70 (終止交易)
    //public class Terminate {
    //    public ResponseData DoTerminate()
    //    {
    //        Logger logger = LogManager.GetCurrentClassLogger();

    //        RequestDataBuilder requestDataBuilder = new RequestDataBuilder();
    //        RequestData requestData_terminate = new RequestData();
    //        ResponseData resData_terminate = new ResponseData();

    //        string machineModel = Constants.machineModel_AS350_v1_51;
    //        string transType = Constants.transactionType_Terminate;
    //        string commPortName = "COM4";

    //        requestData_terminate = requestDataBuilder
    //                .MachineModel(machineModel)
    //                .TransType(transType)
    //                .CommPortName(commPortName)
    //                .Logger(logger)
    //                .Build();

    //        resData_terminate = EDC.run(requestData_terminate);

    //        return resData_terminate;
    //    }
    //}
    //#endregion
}
