using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Stategy.Source.Abstracts
{
    //declares an interface common to all supported algorithms.
    //Context uses this interface to call the algorithm defined by a ConcreteStrategy
    public abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }
}
