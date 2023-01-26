using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Memento.Source.Models
{
    //Caretaker
    //is responsible for the memento's safekeeping
    //never operates on or examines the contents of a memento.
    public class Caretaker
    {
        private Stack<Memento> _stateHistory;

        public Caretaker()
        {
            _stateHistory = new Stack<Memento>();
        }

        public void SaveState(Memento state)
        {
            Console.WriteLine("State of originator saved by caretaker in state history");
            _stateHistory.Push(state);
        }

        public void RestorePreviousState(Originator originator)
        {
            if (_stateHistory.Count == 0) return;
            originator.SetMemento(_stateHistory.Pop());
        }
    }
}
