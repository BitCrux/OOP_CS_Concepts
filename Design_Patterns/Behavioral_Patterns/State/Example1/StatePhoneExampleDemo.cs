using Design_Patterns.Behavioral_Patterns.State.Example1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State.Example
{
    public class StatePhoneExampleDemo
    {
        public void Run()
        {
            Phone p = new Phone();
            p.State.OnHome();
            p.State.OnHome();
            p.State.OnHome();
            p.State.OnHome();

            p.State.OnOffOn();
            p.State.OnOffOn();
            p.State.OnOffOn();
            p.State.OnOffOn();
        }
    }
}
