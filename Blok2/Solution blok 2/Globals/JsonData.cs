using System.Collections.Generic;

namespace Globals
{
    public class JsonData : Case
    {
        public List<Case> Data { get; private set; }
        public string Dt { get; private set; }
        public string Ts { get; private set; }

        public JsonData(List<Case> data, string date, string timestamp) : base("", 0, 0, 0, 0)
        {
            Data = data;
            Dt = date;
            Ts = timestamp;
        }
    }
}
