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

        private string partOfSpeech { get; set; }
        public string Name { get; set; }

        public posCounter(string partOfSpeech, string name)
        {
            this.partOfSpeech = partOfSpeech;
            this.Name = name;
        }

        public double calculate(List<string> posTags)
        {
            double counter = 0;
            foreach (string tag in posTags)
            {
                if (tag.StartsWith(partOfSpeech))
                {
                    counter++;
                }
            }
            return counter/posTags.Count;
        }

    }
}
