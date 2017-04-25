using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NLPInterfaces;

namespace DocumentInterfaces
{
    public interface IDocument
    {

        string Name { get; }
        void delete();
        IFeatureVector vector { get; set; }

    }
}
