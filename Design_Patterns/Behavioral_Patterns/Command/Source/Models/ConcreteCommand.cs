using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Command.Source.Models
{
    //defines a binding between a Receiver object and an action
    //implements Execute by invoking the corresponding operation(s) on Receiver
    public class ConcreteCommand : Abstracts.Command
    {
        // Constructor
        public ConcreteCommand(Receiver receiver) : base(receiver){ }

        public override void Execute()
        {
            receiver.Action();
        }
    }
}
