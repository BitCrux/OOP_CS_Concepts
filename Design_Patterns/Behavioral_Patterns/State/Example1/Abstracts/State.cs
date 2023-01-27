using Design_Patterns.Behavioral_Patterns.State.Example1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State.Example1.Abstracts
{
    public abstract class State
    {
        protected Phone _phone;

        public State(Phone phone)
        {
            _phone = phone;
        }

        public abstract void OnHome();
        public abstract void OnOffOn();
    }
}
