using System;
using System.Collections.Generic;
using System.Linq;
using NLPInterfaces;

namespace NLPImplementations
{
    public class FeatureVector : IFeatureVector
    {
        private List<double> scalars;
        
        public int count()
        {
            return scalars.Count();
        }

        public void addValue(double value)
        {
            scalars.Add(value);
        }

        public double getValue(int index)
        {
            return scalars[index];
        }

        public FeatureVector()
        {
            scalars = new List<double>();
        }

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
            if (compareVector.count() != this.count())
            {
                throw new ArgumentOutOfRangeException("vectors must have same number of elements");
            }

            double dotProduct = 0;

            //calculate dot product
            for (int i = 0; i < compareVector.count(); i++)
            {
                dotProduct += scalars[i] + compareVector.getValue(i);
            }

            //calculate magnitudeproduct
            double magProduct = magnitude() * compareVector.magnitude();
            if (magProduct == 0) // protect against divide-by-zero
            {
                throw new ArgumentOutOfRangeException("magnitude can't be zero");
            }

            double angle = dotProduct / magProduct;
            return angle;
        }

    }
}
