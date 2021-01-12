using Globals;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Datalayer
{
    public interface IData
    {
        public Task<JsonData> GetJsonDataFromAPIAsync();
        public Task<List<CountryData>> GetDataByCountryFromAPIAsync(string country);
    }
}
