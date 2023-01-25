using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Proxy.Source.Abstracts
{
    //defines the common interface for RealSubject and Proxy so that a Proxy can be used anywhere a RealSubject is expected.
    public abstract class Subject
    {
        public abstract void Request();
    }
}
