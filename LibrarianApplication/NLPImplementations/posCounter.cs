using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NLPInterfaces;

namespace NLPImplementations
{
    public class posCounter : IFeatureCalculator
    {

        private String partOfSpeech;

        public static posCounter create(String partOfSpeech)
        {
            return new posCounter(partOfSpeech);
        }

        public posCounter(String partOfSpeech)
        {
            this.partOfSpeech = partOfSpeech;
        }

        public double calculate(List<string> posTags)
        {
            int counter = 0;
            foreach (String tag in posTags)
            {
                if (tag.StartsWith(partOfSpeech))
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}
