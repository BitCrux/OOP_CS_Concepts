using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Visitor.Source.Models
{
    //implements each operation declared by Visitor. Each operation implements a fragment of the
    //algorithm defined for the corresponding class or object in the structure.
    //ConcreteVisitor provides the context for the algorithm and stores its local state.
    //This state often accumulates results during the traversal of the structure.
    public class ConcreteVisitor1 : Abstracts.Visitor
    {
        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visited by {1}",
                concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visited by {1}",
                concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
