using Globals;

namespace Logic
{
    public interface ILogic
    {
        public JsonData GetJsonData();

        public delegate int ShowValues(JsonData data);
        public int ShowTotalConfirmed(JsonData data);
        public int ShowTotaldeaths(JsonData data);
        public int ShowTotalrecovered(JsonData data);
        public int ShowTotalActive(JsonData data);
    }
}
