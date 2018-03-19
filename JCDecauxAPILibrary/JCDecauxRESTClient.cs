using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace JCDecauxAPILibrary
{
    public class JCDecauxRESTClient
    {
        private const string APIKEY = "9113d95374ccfca8d785e1f8093fb1444f068e68";
        private const string PATH = "https://api.jcdecaux.com/vls/v1/";

        private string FetchData(string endPoint, Dictionary<string, string> param)
        {
            param["apiKey"] = APIKEY;
            string paramString = "?" + String.Join("&", param.Select(i => $"{i.Key}={i.Value}"));

            var request = WebRequest.Create(PATH + endPoint + paramString);
            var response = request.GetResponse();
            Console.WriteLine((response as HttpWebResponse).StatusDescription);
            Stream dataStream = response.GetResponseStream();
            var reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            Console.WriteLine(responseFromServer);
            reader.Close();
            response.Close();
            return responseFromServer;
        }

        private T DecodeData<T>(string jsonData)
        {
            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        private T RequestData<T>(string endPoint, Dictionary<string, string> param = null)
        {
            return DecodeData<T>(FetchData(endPoint, param ?? new Dictionary<string, string>()));
        }

        public List<JCDecauxContract> GetContracts()
        {
            return RequestData<List<JCDecauxContract>>("contracts");
        }

        public List<JCDecauxStation> GetStations(JCDecauxContract contract)
        {
            return RequestData<List<JCDecauxStation>>("stations", new Dictionary<string, string> { { "contract", contract.name } });
        }
    }
}