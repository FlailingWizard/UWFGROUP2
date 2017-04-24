using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPInterfaces
{
    public interface IPOSTagger
    {
        double tagPOS(List<string> posTags);
    }
}
