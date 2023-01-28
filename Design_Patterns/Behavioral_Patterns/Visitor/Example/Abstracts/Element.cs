using Design_Patterns.Behavioral_Patterns.Visitor.Example.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Visitor.Example.Abstracts
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
