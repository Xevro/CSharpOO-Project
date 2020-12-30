using Datalayer;
using Globals;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Logic
{
    public class LogicHandler : ILogic
    {
        //private readonly IData data;
        public Func<JsonData, Dictionary<string, int>> DataDelegate { get; set; }
        private readonly JsonData jsonData;

        public LogicHandler(IData data)
        {
            //this.data = data;
            jsonData = data.GetJsonDataFromAPI();
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

        public List<Case> GetSearchResults(string searchTerm)
        {
            var results = jsonData.Data.FindAll(c => c.Location.ToLower().Contains(searchTerm.ToLower()));
            return results;
        }

        public void UpdateItem(Case caseInfo)
        {
            //jsonData.Data.Where(c => c.Location == caseInfo.Location).Select(item => { item = caseInfo; return item; }).ToList();
            jsonData.Data.Where(c => c.Location == caseInfo.Location).Select(item => { item.Confirmed = caseInfo.Confirmed; item.Deaths = caseInfo.Deaths;
                item.Recovered = caseInfo.Recovered; item.Active = caseInfo.Active; return item; }).ToList();
            //foreach (var d in jsonData.Data)
              //  {
             //   Debug.WriteLine(d.Location);
               // Debug.WriteLine(d.Confirmed);
           // }
            
        }
    }
}