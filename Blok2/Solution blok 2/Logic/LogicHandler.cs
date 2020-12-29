using Datalayer;
using Globals;
using System;
using System.Collections.Generic;

namespace Logic
{
    public class LogicHandler : ILogic
    {
        private readonly IData data;
        public Func<JsonData, Dictionary<string, int>> DataDelegate { get; set; }

        public LogicHandler(IData data)
        {
            this.data = data;
        }
        public JsonData GetJsonData() => data.GetJsonDataFromAPI();

        public Dictionary<string, int> GetTotalsFromData(JsonData data)
        {
            int totalConfirmed = 0;
            int totalDeaths = 0;
            int totalRecovered = 0;
            int totalActive = 0;
            foreach (var caseData in data.Data)
            {
                totalConfirmed += caseData.Confirmed;
                totalDeaths += caseData.Deaths;
                totalRecovered += caseData.Recovered;
                totalActive += caseData.Active;
            }
            var values = new Dictionary<string, int>
            {
                { "totalConfirmed", totalConfirmed },
                { "totalDeaths", totalDeaths },
                { "totalRecovered", totalRecovered },
                { "totalActive", totalActive }
            };
            return values;
        }
    }
}