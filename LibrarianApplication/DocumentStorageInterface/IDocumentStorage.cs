using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentStorageInterface
{
    public interface IDocumentStorage
    {
        String storeDoc(String fileName, String sourcePath, String targetPath);
    }
}
