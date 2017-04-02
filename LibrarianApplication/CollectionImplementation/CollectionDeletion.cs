using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionInterfaces;

namespace CollectionImplementation
{
    public class CollectionDeletion : ICollectionDeletion
    {
        public String deleteCollection(String deletePath)
        {
            if (System.IO.Directory.Exists(@deletePath))
            {
                try
                {
                    System.IO.Directory.Delete(@deletePath, true);
                }

                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return deletePath;
        }
    }
}
