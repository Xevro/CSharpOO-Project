using Globals;
using Globals.Exceptions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace Datalayer
{
    public class DataLoader : IData
    {
        private readonly string url = "https://covid2019-api.herokuapp.com/v2/current";
        private readonly string baseUrl = "https://api.covid19api.com/dayone/country/";

        public JsonData GetJsonDataFromAPI()
        {
            var result = new WebClient().DownloadString(url);
            var data = JsonConvert.DeserializeObject<JsonData>(result);
            return data;
        }

        public List<CountryData> GetDataByCountryFromAPI(string country)
        {
            try
            {
                var result = new WebClient().DownloadString(baseUrl + country);
                var data = JsonConvert.DeserializeObject<List<CountryData>>(result);
                return data;
            }
            catch (WebException)
            {
                throw new WebException();
            }
        }
    }
}