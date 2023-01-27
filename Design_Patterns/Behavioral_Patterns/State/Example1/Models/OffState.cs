using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State.Example1.Models
{
    public class OffState : Abstracts.State
    {
        public OffState(Phone phone) : base(phone) { }

        public override void OnHome()
        {
            _phone.State = new LockedState(_phone);
            _phone.TurnOn();
        }

        public override void OnOffOn()
        {
            _phone.State = new LockedState(_phone);
            _phone.TurnOn();
        }
    }
}
