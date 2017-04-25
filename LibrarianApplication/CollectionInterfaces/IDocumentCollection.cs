using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInterfaces
{
    public interface IDocumentCollection
    {

        int count();
        void addDocument();
        void removeDocument();


    }
}
