using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentDeletionInterface
{
    public interface IDocumentDeletion
    {
        String deleteDoc(String deletePath);
    }
}
