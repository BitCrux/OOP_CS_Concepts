using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Memento.Source.Models
{
    //creates a memento containing a snapshot of its current internal state.
    //uses the memento to restore its internal state
    public class Originator
    {
        string state;
        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State = " + state);
            }
        }
        // Creates memento 
        public Memento CreateMemento()
        {
            return (new Memento(state));
        }
        // Restores original state
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }
}
