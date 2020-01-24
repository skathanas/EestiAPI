using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Json;
using Newtonsoft.Json;

namespace EestiAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to facts about Estonia!");
            EstFacts();
        }

        public static void EstFacts()
        {
            string EstFactsUrl = "https://restcountries.eu/rest/v2/name/eesti";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(EstFactsUrl);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                info eeInfo = JsonConvert.DeserializeObject<info>(response);
                Console.WriteLine(eeInfo.name);
                Console.WriteLine(eeInfo.cioc);
                Console.WriteLine(eeInfo.domain);
                Console.WriteLine(eeInfo.capital);
                Console.WriteLine(eeInfo.region);
                Console.WriteLine(eeInfo.population);
                Console.WriteLine(eeInfo.language);
            }
        }

    }
}
