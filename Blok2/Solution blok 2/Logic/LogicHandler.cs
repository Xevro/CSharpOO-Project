using Datalayer;
using Globals;
using System.Collections.Generic;

namespace Logic
{
    public class LogicHandler : ILogic
    {
        private readonly IData data;
        public delegate Dictionary<string, int> ShowValues(JsonData data);

        public LogicHandler(IData data)
        {
            this.data = data;
        }
        public JsonData GetJsonData()
        {
            return data.GetJsonDataFromAPI();
        }

        public Dictionary<string, int> GetTotalsFromData(JsonData data)
        {
            var totalConfirmed = 0;
            var totalDeaths = 0;
            var totalRecovered = 0;
            var totalActive = 0;
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