using Globals;
using Newtonsoft.Json;
using System.Net;

namespace Datalayer
{
    public class DataLoader : IData
    {
        private readonly string url = "https://covid2019-api.herokuapp.com/v2/current";

        public JsonData GetJsonDataFromAPI()
        {
            var result = new WebClient().DownloadString(url);
            var data = JsonConvert.DeserializeObject<JsonData>(result);

            return data;
        }
    }
}
