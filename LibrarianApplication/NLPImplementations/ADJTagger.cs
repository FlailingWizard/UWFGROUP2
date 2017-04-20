using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLPInterfaces;
namespace NLPImplementations
{
    public class ADJTagger:IPOSTagger
    {
        public int tagPOS(List<string> posTags)
        {
            int counter= 0;
            for(int i = 0; i < posTags.Count(); i++)
            {
                if (posTags[i].Equals("JJ"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("JJR"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("JJS"))
                {
                    counter = counter + 1;
                }
            }
            Console.WriteLine(counter);
            return counter;
        }
    }
}
