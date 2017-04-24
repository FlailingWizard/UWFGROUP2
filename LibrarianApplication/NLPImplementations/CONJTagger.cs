using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLPInterfaces;
namespace NLPImplementations
{
    class CONJTagger:IPOSTagger
    {
        public double tagPOS(List<string> posTags)
        {
            double counter = 0;
            for (int i = 0; i < posTags.Count(); i++)
            {
                if (posTags[i].Equals("CC"))
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
