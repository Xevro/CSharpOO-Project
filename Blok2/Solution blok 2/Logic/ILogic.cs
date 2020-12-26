using Globals;
using System.Collections.Generic;

namespace Logic
{
    public interface ILogic
    {
        public JsonData GetJsonData();

        public delegate Dictionary<string, int> ShowValues(JsonData data);
        public Dictionary<string, int> GetTotalsFromData(JsonData data);
    }
}
