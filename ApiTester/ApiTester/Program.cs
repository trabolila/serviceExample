using BlackPanther.Objects.BaseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ApiTester
{ 
    public class Program
    {
        public static string ApiUrl = "http://localhost:4973/api/";

        private static HttpClient client;

        public static void Main(string[] args)
        {
            string ApiController = "payu";


            client = new HttpClient();

            PayUSoapContent content = new PayUSoapContent
            {
                Api = "",
                SafeKey = Guid.NewGuid(),
                TransactionType = 5,
                Stage = false,
                CancelUrl = "",
                Merchant = new Merchant
                {
                    Email = "test@test.com",
                    MerchantReference = "",
                    Mobile = "",
                    FirstName = "Test",
                    LastName = "Test"
                },
                Basket = new Basket
                {
                    AmountInCents = 20000,
                    CurrencyCode = "ZAR",
                    Description = "This is a test Basket"
                },
                SupportedPaymentMethod = "EWallet"
            };

           

            


        }
    }
}
