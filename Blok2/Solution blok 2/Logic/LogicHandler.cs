using Datalayer;
using Globals;

namespace Logic
{
    public class LogicHandler : ILogic
    {
        private readonly IData data;
        public delegate int ShowValues(JsonData data);

        public LogicHandler(IData data)
        {
            this.data = data;
        }
        public JsonData GetJsonData()
        {
            return data.GetJsonDataFromAPI();
        }

        public int ShowTotalConfirmed(JsonData data)
        {
            var totalConfirmed = 0;
            foreach (var caseData in data.Data)
            {
                totalConfirmed += caseData.Confirmed;
            }
            return totalConfirmed;
        }

        public int ShowTotaldeaths(JsonData data)
        {
            var totalDeaths = 0;
            foreach (var caseData in data.Data)
            {
                totalDeaths += caseData.Deaths;
            }
            return totalDeaths;
        }

        public int ShowTotalrecovered(JsonData data)
        {
            var totalRecovered = 0;
            foreach (var caseData in data.Data)
            {
                totalRecovered += caseData.Recovered;
            }
            return totalRecovered;
        }

        public int ShowTotalActive(JsonData data)
        {
            var totalActive = 0;
            foreach (var caseData in data.Data)
            {
                totalActive += caseData.Active;
            }
            return totalActive;
        }
    }
}