using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLPInterfaces;

namespace NLPImplementations
{
    public class adverbTagger:IPOSTagger
    {
        public int tagPOS(List<string> posTags)
        {
            int counter = 0;
            for (int i = 0; i < posTags.Count(); i++)
            {
                if (posTags[i].Equals("RB"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("RBR"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("RBS"))
                {
                    counter = counter + 1;
                }
            }
            Console.WriteLine(counter);
            return counter;
        }
    }

}
