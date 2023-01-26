using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Observer.Source.Abstracts
{
    //defines an updating interface for objects that should be notified of changes in a subject.
    public abstract class Observer
    {
        public abstract void Update();
    }
}
