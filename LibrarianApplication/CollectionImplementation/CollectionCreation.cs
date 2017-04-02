using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionInterfaces;

namespace CollectionImplementation
{
    public class CollectionCreation : ICollectionCreation
    {
        public string createColl(String targetPath)
        {
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
                return targetPath;
            }
            else if (System.IO.Directory.Exists(targetPath))
            {
                return targetPath;
            }
            return null;
        }
    }
}
