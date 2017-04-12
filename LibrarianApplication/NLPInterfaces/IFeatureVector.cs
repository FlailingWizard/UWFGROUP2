using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPInterfaces
{
    public interface IFeatureVector
    {
        int count();
        void addValue(double value);
        double getValue(int index);
        double magnitude();
        double similarity(IFeatureVector compareVector);
    }
}
