using Datalayer;
using Globals;

namespace Logic
{
    public class LogicHandler : ILogic
    {
        private readonly IData data;

        public LogicHandler(IData data)
        {
            this.data = data;
        }

        public JsonData GetJsonData()
        {
            return data.GetJsonDataFromAPI();
        }
    }
}