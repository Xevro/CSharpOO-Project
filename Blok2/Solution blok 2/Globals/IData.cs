using Globals;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Datalayer
{
    public interface IData
    {
        public JsonData GetJsonDataFromAPI();
        public Task<List<CountryData>> GetDataByCountryFromAPIAsync(string country);
    }
}
