using System.Net.Http;
using System.Threading.Tasks;

namespace Datalayer
{
    public interface IData
    {
        public Task<string> RetrieveDataAsync();
    }
}
