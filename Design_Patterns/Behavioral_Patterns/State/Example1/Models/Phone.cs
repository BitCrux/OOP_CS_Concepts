using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State.Example1.Models
{
    public class Phone
    {
        private Abstracts.State _state;
        public Abstracts.State State
        {
            get { return _state; }
            set { _state = value; }
        }

        public Phone()
        {
            _state = new OffState(this);
        }

        public void Lock()
        {
            Console.WriteLine("Locking phone and turning off the screen");
        }

        public void Home()
        {
            Console.WriteLine("Going to home-screen");
        }

        public void Unlock()
        {
            Console.WriteLine("Unlocking the phone to home");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning screen on, device still locked");
        }
    }
}
