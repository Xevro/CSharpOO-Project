using Globals;
using System;
using System.Collections.Generic;

namespace Logic
{
    public interface ILogic
    {
        public JsonData GetJsonData();
        public Func<JsonData, Dictionary<string, int>> DataDelegate { get; set; }
        public Dictionary<string, int> GetTotalsFromData(JsonData data);
        public List<Case> GetSearchResults(string searchTerm);
        public void UpdateItem(Case caseInfo);
    }
}
