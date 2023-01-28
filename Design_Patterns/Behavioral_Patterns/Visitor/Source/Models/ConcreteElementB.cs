using Design_Patterns.Behavioral_Patterns.Visitor.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Visitor.Source.Models
{
    //implements an Accept operation that takes a visitor as an argument
    public class ConcreteElementB : Element
    {
        public override void Accept(Abstracts.Visitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
        public void OperationB()
        {
        }
    }
}
