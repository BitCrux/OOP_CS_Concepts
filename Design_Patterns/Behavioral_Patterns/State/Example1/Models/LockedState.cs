using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State.Example1.Models
{
    public class LockedState : Abstracts.State
    {
        public LockedState(Phone phone) : base(phone) { }

        public override void OnHome()
        {
            _phone.State = new ReadyState(_phone);
            _phone.Unlock();
        }

        public override void OnOffOn()
        {
            _phone.State = new OffState(_phone);
            _phone.Lock();
        }
    }
}
