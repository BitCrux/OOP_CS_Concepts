using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State.Example1.Models
{
    public class ReadyState : Abstracts.State
    {
        public ReadyState(Phone phone) : base(phone) { }

        public override void OnHome()
        {
            _phone.Home();
        }

        public override void OnOffOn()
        {
            _phone.State = new OffState(_phone);
            _phone.Lock();
        }
    }
}
