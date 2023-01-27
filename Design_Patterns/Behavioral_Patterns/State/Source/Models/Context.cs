using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State.Source.Models
{
    //defines the interface of interest to clients
    //maintains an instance of a ConcreteState subclass that defines the current state.
    public class Context
    {
        Abstracts.State state;
        // Constructor
        public Context(Abstracts.State state)
        {
            this.State = state;
        }
        // Gets or sets the state
        public Abstracts.State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State: " + state.GetType().Name);
            }
        }
        public void Request()
        {
            state.Handle(this);
        }
    }
}
