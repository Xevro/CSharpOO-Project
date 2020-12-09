using System;
using System.Collections.Generic;
using System.Text;

namespace Globals
{
    public interface IDataProvider
    {
        void ExportToJSON(List<Product> products);
        List<Product> ImportFromJSON();

    }
}
