using System.Collections.Generic;

namespace Globals
{
    public class JsonData : ICase
    {
        public List<Case> Data { get; set; }
        public string Dt { get; set; }
        public string Ts { get; set; }

        public JsonData(List<Case> data, string date, string timestamp)
        {
            Data = data;
            Dt = date;
            Ts = timestamp;
        }
    }
}
