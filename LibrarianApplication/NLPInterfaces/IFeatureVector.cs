using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPInterfaces
{
    public interface IFeatureVector
    {

        bool calcDone { get; set; }
        List<IFeatureCalculator> calculators { get; }
        int scalarCount();
        void addScalarValue(double value);
        double getScalarValue(int index);

        int featureCount();
        void addFeatureCalculator(IFeatureCalculator featureCalculator);

        double magnitude();
        double similarity(IFeatureVector compareVector);

        List<double> process();
    }
}
