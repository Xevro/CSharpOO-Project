using Datalayer;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Logic
{
    public class LogicHandler : ILogic
    {
        private readonly IData data;

        public LogicHandler(IData data)
        {
            this.data = data;
        }

        public async Task load()
        {
            var x = await data.RetrieveDataAsync();
            Debug.WriteLine(x.ToString());
        }
    }
}
