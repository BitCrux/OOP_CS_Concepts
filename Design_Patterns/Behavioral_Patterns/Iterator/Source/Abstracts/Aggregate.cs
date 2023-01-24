using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Iterator.Source.Abstracts
{
    //defines an interface for creating an Iterator object
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
