using Design_Patterns.Behavioral_Patterns.Mediator.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Mediator.Source.Models
{
    //each Colleague class knows its Mediator object
    //each colleague communicates with its mediator whenever it would have otherwise communicated with another colleague
    public class ConcreteColleague1 : Colleague
    {
        // Constructor
        public ConcreteColleague1(Abstracts.Mediator mediator) : base(mediator){ }
        public void Send(string message)
        {
            mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: "
                + message);
        }
    }
}
