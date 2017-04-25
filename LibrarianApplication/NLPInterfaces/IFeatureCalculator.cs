﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLPInterfaces
{
    public interface IFeatureCalculator
    {
        double calculate(List<string> posTags);
        string Name { get; set; }
    }
}
