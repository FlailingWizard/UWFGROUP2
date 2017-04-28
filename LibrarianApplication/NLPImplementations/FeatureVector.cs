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
        public List<IFeatureCalculator> calculators { get; }
        private string Text { get; set; }
        public bool calcDone { get; set; }

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
            this.Text = text;
            scalars = new List<double>();
            calcDone = false;
            calculators = new List<IFeatureCalculator>();
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
            // check to make sure the scalars for this vector are calculated
            if (!calcDone)
            {
                process();
            }

            // check if scalars for the other vector are calculated
            if (!compareVector.calcDone)
            {
                compareVector.process();
            }

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

        public List<double> process()
        {

            if (Text == "" || Text == null)
            {
                throw new ArgumentNullException("Text is empty or null");
            }

            NLPWrapper nlp = new NLPWrapper();

            List<string> realTags = nlp.analyzeText(Text);

            // send the tags to each feature calculator and put result in scalar list
            foreach (IFeatureCalculator featureCalc in calculators)
            {
                scalars.Add(featureCalc.calculate(realTags));
            }

            calcDone = true;
            return scalars;
        }
        public List<double> getScalars()
        {
            return scalars;
        }


        /// <summary>
        /// Creates the default feature calculator instances.
        /// </summary>
        private void createDefaultCalculators()
        {
            calculators.Add(new posCounter(partOfSpeechVerb, "V"));
            calculators.Add(new posCounter(partOfSpeechNoun, "N"));
            calculators.Add(new posCounter(partOfSpeechPronoun, "P"));
            calculators.Add(new posCounter(partOfSpeechConjugate, "C"));
            calculators.Add(new posCounter(partOfSpeechAdjective, "A"));
            calculators.Add(new posCounter(partOfSpeechAdverb, "AV"));

        }

    }
}
