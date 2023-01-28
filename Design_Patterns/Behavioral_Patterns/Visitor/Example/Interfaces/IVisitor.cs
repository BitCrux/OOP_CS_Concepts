using Design_Patterns.Behavioral_Patterns.Visitor.Example.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Visitor.Example.Interfaces
{
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
