using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionCreationInterface;

namespace CollectionCreationImplementation
{
    public class CreateCollection : ICreateCollection
    {
        public string createColl(String targetPath)
        {
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
                return targetPath;
            }
            
            return null;
        }
    }
}
