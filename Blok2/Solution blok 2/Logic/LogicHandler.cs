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
        public event Action<JsonData> DataEvent;
        private readonly IData dataProvider;
        private JsonData jsonData;

        public LogicHandler(IData data)
        {
            dataProvider = data;
        }

        public void GetJsonData()
        {
            Task.Run(async () =>
             {
                //use Thread.Sleep to see the result of the task async in action (useable interface while sleeping). 
                //Thread.Sleep(3000);
                jsonData = await dataProvider.GetJsonDataFromAPIAsync();
                 DataEvent?.Invoke(jsonData);
             });
        }

        public async Task<List<CountryData>> GetDataByCountry(string country)
        {
            return await dataProvider.GetDataByCountryFromAPIAsync(country);
        }

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