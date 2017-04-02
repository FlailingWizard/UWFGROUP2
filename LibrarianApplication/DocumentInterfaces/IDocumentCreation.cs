using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentInterfaces
{
    public interface IDocumentCreation
    {
        String storeDoc(String fileName, String sourcePath, String targetPath);
    }
}
