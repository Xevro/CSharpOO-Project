using System.Collections.Generic;

namespace Globals
{
    public interface IDataProvider
    {
        void ExportToJSON(List<Product> products);
        List<Product> ImportFromJSON();
        public void DirectoryInfo();
        public void FileInfo();
    }
}
