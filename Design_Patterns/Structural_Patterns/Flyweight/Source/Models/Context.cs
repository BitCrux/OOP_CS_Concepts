using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Flyweight.Source.Models
{
    public class Context
    {
        private int _extrinsicState;
        public int ExtrinsicState
        {
            get { return _extrinsicState; }
            set { _extrinsicState = value; }
        }

        public Context(int extrinsicState)
        {
            _extrinsicState = extrinsicState;
        }
    }
}
