using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLPInterfaces;
namespace NLPImplementations
{
    public class verbTagger:IPOSTagger
    {
        public int tagPOS(List<string> posTags)
        {
            int counter = 0;
            for (int i = 0; i < posTags.Count(); i++)
            {
                if (posTags[i].Equals("VB"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("VBD"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("VBG"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("VBN"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("VBP"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("VBZ"))
                {
                    counter = counter + 1;
                }
            }
            Console.WriteLine(counter);
            return counter;
        }
    }

}
