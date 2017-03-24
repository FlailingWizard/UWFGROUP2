using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentDeletionInterface;
namespace DocumentDeletionImplementation
{
    public class DocumentDeletion: IDocumentDeletion
    {
       
        public string deleteDoc(String deletePath)
        {
            // Delete a file by using File class static method...
            if (System.IO.File.Exists(@deletePath))
            {
                try
                {
                    System.IO.File.Delete(@deletePath);
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }

            return deletePath;
        }
    }
}
