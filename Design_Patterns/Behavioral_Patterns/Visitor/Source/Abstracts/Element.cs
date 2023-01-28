using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Visitor.Source.Abstracts
{
    //defines an Accept operation that takes a visitor as an argument.
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
