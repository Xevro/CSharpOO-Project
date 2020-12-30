using Globals;
using System;
using System.Collections.Generic;

namespace Logic
{
    public abstract class Logics
    {
        public abstract JsonData GetJsonData();
        public abstract Func<JsonData, Dictionary<string, int>> DataDelegate { get; set; }
        public abstract Dictionary<string, int> GetTotalsFromData(JsonData data);
        public abstract List<Case> GetSearchResults(string searchTerm);
        public abstract void UpdateItem(Case caseInfo);
    }
}
