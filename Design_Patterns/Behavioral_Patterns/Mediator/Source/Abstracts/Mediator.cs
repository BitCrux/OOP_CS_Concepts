using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Mediator.Source.Abstracts
{
    //defines an interface for communicating with Colleague objects
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
