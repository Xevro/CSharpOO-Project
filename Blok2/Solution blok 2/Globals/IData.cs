using Globals;
using System.Collections.Generic;

namespace Datalayer
{
    public interface IData
    {
        public JsonData GetJsonDataFromAPI();
        public List<CountryData> GetDataByCountryFromAPI(string country);
    }
}
