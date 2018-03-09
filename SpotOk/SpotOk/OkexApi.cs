using SpotOk.Ok;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotOk
{
    public class OkexApi
    {
        static String api_key = "7f2cbe21-c5b8-41c9-a0a3-4162135488ce";  //OKCoin申请的apiKey
        static String secret_key = "71861FCBAC28C99D324AB943B6469610";  //OKCoin申请的secretKey
        static String url_prex = "https://www.okcoin.com"; //国内站账号配置 为 https://www.okcoin.cn

        public static void Kline()
        {
            //期货操作
            FutureRestApiV1 getRequest = new FutureRestApiV1(url_prex);
            FutureRestApiV1 postRequest = new FutureRestApiV1(url_prex, api_key, secret_key);

            var res = getRequest.future_kline("ltc_usd", "1min", "this_week", "1440", "");
            Console.WriteLine(res);
        }
    }
}
