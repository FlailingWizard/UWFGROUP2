using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentInterfaces;

namespace CollectionInterfaces
{
    public interface IDocumentCollection
    {

        int count();
        void addDocument(IDocument document);
        void removeDocument(IDocument document);


    }
}
