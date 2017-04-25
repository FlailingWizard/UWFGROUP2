using System;
using System.Collections.Generic;
using System.Linq;
using NLPInterfaces;
using DocumentInterfaces;

namespace NLPImplementations
{

    /// <summary>
    /// This implements a specialized vector used to compare the features of documents to each other. 
    /// An occurence ratio of parts of speech is used by default, but you can add additional
    /// </summary>
    public class FeatureVector : IFeatureVector
    {

        // Constants (used for creating default calculators)
        private const string partOfSpeechVerb = "VB";
        private const string partOfSpeechNoun = "NN";
        private const string partOfSpeechPronoun = "PR";
        private const string partOfSpeechConjugate = "CC";
        private const string partOfSpeechAdjective = "JJ";
        private const string partOfSpeechAdverb = "RB";

        private List<double> scalars;
        private List<IFeatureCalculator> calculators;
        private bool calcDone;

        // accessors       
        public int scalarCount()
        {
            return scalars.Count();
        }

        public void addScalarValue(double value)
        {
            scalars.Add(value);
        }

        public double getScalarValue(int index)
        {
            return scalars[index];
        }

        public int featureCount()
        {
            return calculators.Count;
        }

        public void addFeatureCalculator(IFeatureCalculator featureCalculator)
        {
            calculators.Add(featureCalculator);
        }

        // default constructor
        
        public FeatureVector(string text)
        {
            scalars = new List<double>();
            calcDone = false;
            createDefaultCalculators();
        }

        // public methods
        public double magnitude()
        {
            // returns the magnitude of this vector
            double sums = 0;
            foreach (double num in scalars)
            {
                sums += Math.Pow(num, 2);
            }
            return Math.Sqrt(sums);
        }

        public double similarity(IFeatureVector compareVector)
        {

            // check if both vectors have the same number of elements
            if (compareVector.scalarCount() != this.scalarCount())
            {
                throw new ArgumentOutOfRangeException("vectors must have same number of elements");
            }

            double dotProduct = 0;

            // calculate dot product
            for (int i = 0; i < compareVector.scalarCount(); i++)
            {
                dotProduct += scalars[i] + compareVector.getScalarValue(i);
            }

            // calculate magnitudeproduct
            double magProduct = magnitude() * compareVector.magnitude();
            if (magProduct == 0) // protect against divide-by-zero
            {
                throw new ArgumentOutOfRangeException("magnitude can't be zero");
            }

            double angle = dotProduct / magProduct;
            return angle;
        }

        // private methods
        public void process(string text)
        {
            NLPWrapper nlp = new NLPWrapper();

            List<string> realTags = nlp.analyzeText(text);

            // send the tags to each feature calculator and put result in scalar list
            foreach (IFeatureCalculator featureCalc in calculators)
            {
                scalars.Add(featureCalc.calculate(realTags));
            }

            calcDone = true;
        }


        /// <summary>
        /// Creates the default feature calculator instances.
        /// </summary>
        private void createDefaultCalculators()
        {
            calculators.Add(posCounter.create(partOfSpeechVerb));
            calculators.Add(posCounter.create(partOfSpeechNoun));
            calculators.Add(posCounter.create(partOfSpeechPronoun));
            calculators.Add(posCounter.create(partOfSpeechConjugate));
            calculators.Add(posCounter.create(partOfSpeechAdjective));
            calculators.Add(posCounter.create(partOfSpeechAdverb));

        }

    }
}
