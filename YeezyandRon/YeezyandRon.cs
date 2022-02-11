using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace YeezyandRonConsoleUI
{
    public class KanyeSwanson
    {
        public static void YeQuote()
        {

            var client = new HttpClient();

            var kanyeURL = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();


            client = new HttpClient();
            //client

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine("What are your thoughts Kanye?");
            Console.WriteLine();
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine();
            var myResponse = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("What say you Ron?");
            Console.WriteLine();
            Console.WriteLine($"Ron: '{ronQuote}'");
            Console.WriteLine();
            myResponse = Console.ReadLine();

            while (myResponse != "Enough")
            {
                RonQuote();
                YeQuote();
            }
        }

        public static void RonQuote()
        {
        }
    }
}