using Datalayer;
using Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicHandler : ILogics
    {
        public Func<JsonData, Dictionary<string, int>> DataDelegate { get; set; }

        private readonly JsonData jsonData;
        private readonly IData dataProvider;

        public LogicHandler(IData data)
        {
            jsonData = data.GetJsonDataFromAPI();
            dataProvider = data;
        }

        public async Task<List<CountryData>> GetDataByCountry(string country)
        {
            return await dataProvider.GetDataByCountryFromAPIAsync(country);
        }

        public JsonData GetJsonData() => jsonData;

        public Dictionary<string, int> GetTotalsFromData(JsonData data)
        {
            return new Dictionary<string, int>
            {
                { "totalConfirmed", data.Data.Sum(c => c.Confirmed) },
                { "totalDeaths", data.Data.Sum(c => c.Deaths) },
                { "totalRecovered", data.Data.Sum(c => c.Recovered) },
                { "totalActive", data.Data.Sum(c => c.Active) }
            };
        }

        //Add other delegate
        /* public Dictionary<string, int> get...(JsonData data)
        {
            return new Dictionary<string, int>
            {
                { "totalConfirmed", data.Data.Sum(c => c.Confirmed) },
                { "totalDeaths", data.Data.Sum(c => c.Deaths) },
                { "totalRecovered", data.Data.Sum(c => c.Recovered) },
                { "totalActive", data.Data.Sum(c => c.Active) }
            };
        }*/

        public List<Case> GetSearchResults(string searchTerm)
        {
            return (from c in jsonData.Data
                    where c.Location.ToLower().Contains(searchTerm.ToLower())
                    select c).ToList();
            //return jsonData.Data.FindAll(c => c.Location.ToLower().Contains(searchTerm.ToLower()));
        }

        public void UpdateCase(Case caseInfo)
        {
            jsonData.Data.OrderBy(c => c.Confirmed).Where(c => c.Location == caseInfo.Location).Select(item =>
            {
                item.Confirmed = caseInfo.Confirmed; item.Deaths = caseInfo.Deaths;
                item.Recovered = caseInfo.Recovered; item.Active = caseInfo.Active; return item;
            }).ToList();
        }
    }
}