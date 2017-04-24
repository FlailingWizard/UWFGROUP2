using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLPInterfaces;
namespace NLPImplementations
{
    public class pronounTagger:IPOSTagger
    {
        public double tagPOS(List<string> posTags)
        {
            double counter = 0;
            for (int i = 0; i < posTags.Count(); i++)
            {
                if (posTags[i].Equals("PRP"))
                {
                    counter = counter + 1;
                }
                else if (posTags[i].Equals("PRP$"))
                {
                    counter = counter + 1;
                }

            }
            Console.WriteLine(counter);
            counter = counter / (posTags.Count());
            return counter;
        }
    }

}
