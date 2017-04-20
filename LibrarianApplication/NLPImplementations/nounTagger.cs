using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLPInterfaces;
namespace NLPImplementations
{
    public class nounTagger:IPOSTagger
    {
        public int tagPOS(List<string> posTags)
        {
            int counter = 0;
            for (int i = 0; i < posTags.Count(); i++)
            {
                if (posTags[i].Equals("NN"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("NNP"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("NNPS"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("NNS"))
                {
                    counter = counter +1;
                }

            }
            Console.WriteLine(counter);
            return counter;
        }
    }

}
