using Globals;
using System;
using System.Collections.Generic;

namespace Logic
{
    public interface ILogics
    {
        public JsonData GetJsonData();
        public Func<JsonData, Dictionary<string, int>> DataDelegate { get; set; }
        public List<CountryData> GetDataByCountry(string country);
        public Dictionary<string, int> GetTotalsFromData(JsonData data);
        public List<Case> GetSearchResults(string searchTerm);
        public void UpdateCase(Case caseInfo);
    }
}
