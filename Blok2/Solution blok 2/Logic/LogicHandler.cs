﻿using Datalayer;
using Globals;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class LogicHandler : Logics
    {
        public override Func<JsonData, Dictionary<string, int>> DataDelegate { get; set; }

        private readonly JsonData jsonData;

        public LogicHandler(IData data)
        {
            jsonData = data.GetJsonDataFromAPI();
        }

        public override JsonData GetJsonData() => jsonData;

        public override Dictionary<string, int> GetTotalsFromData(JsonData data)
        {
            return new Dictionary<string, int>
            {
                { "totalConfirmed", data.Data.Sum(c => c.Confirmed) },
                { "totalDeaths", data.Data.Sum(c => c.Deaths) },
                { "totalRecovered", data.Data.Sum(c => c.Recovered) },
                { "totalActive", data.Data.Sum(c => c.Active) }
            };
        }

        public override List<Case> GetSearchResults(string searchTerm)
        {
            return jsonData.Data.FindAll(c => c.Location.ToLower().Contains(searchTerm.ToLower()));
        }

        public override void UpdateItem(Case caseInfo)
        {
            jsonData.Data.OrderBy(c => c.Confirmed).Where(c => c.Location == caseInfo.Location).Select(item =>
            {
                item.Confirmed = caseInfo.Confirmed; item.Deaths = caseInfo.Deaths;
                item.Recovered = caseInfo.Recovered; item.Active = caseInfo.Active; return item;
            }).ToList();
        }
    }
}