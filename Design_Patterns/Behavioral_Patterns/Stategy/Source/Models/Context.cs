using Design_Patterns.Behavioral_Patterns.Stategy.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Stategy.Source.Models
{
    //is configured with a ConcreteStrategy object
    //maintains a reference to a Strategy object
    //may define an interface that lets Strategy access its data.
    public class Context
    {
        Strategy strategy;
        // Constructor
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}
