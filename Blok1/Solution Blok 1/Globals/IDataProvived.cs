using System;
using System.Collections.Generic;
using System.Text;

namespace Globals
{
    public interface IDataProvived
    {
        void ExportToJSON(List<Product> products, string path);
        List<Product> ImportFromJSON(string path);
    }
}
