using Globals;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Datalayer
{
    public class DataLoader : IData
    {
        private readonly string url = "https://covid2019-api.herokuapp.com/v2/current";
        private readonly string countryUrl = "https://api.covid19api.com/dayone/country/";

        public JsonData GetJsonDataFromAPI()
        {
            try
            {
                var result = new WebClient().DownloadString(url);
                var data = JsonConvert.DeserializeObject<JsonData>(result);
                return data;
            }
            catch (WebException)
            {
                throw new WebException();
            }
        }

        public async Task<List<CountryData>> GetDataByCountryFromAPIAsync(string country)
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("summary/json"));

                var task = await client.GetAsync(countryUrl + country).ConfigureAwait(false);
                var result = await task.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<CountryData>>(result);
            }
            catch (WebException)
            {
                throw new WebException();
            }
        }
    }
}