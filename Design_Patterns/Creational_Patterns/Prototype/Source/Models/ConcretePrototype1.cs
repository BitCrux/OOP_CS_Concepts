using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Prototype.Source.Models
{
    //implements an operation for cloning itself
    class ConcretePrototype1 : Abstracts.Prototype
    {
        // Constructor
        public ConcretePrototype1(string id) : base(id){ }
        // Returns a shallow copy -> Careful, you are working with the reference of the original!
        public override Abstracts.Prototype Clone()
        {
            return (Abstracts.Prototype)this.MemberwiseClone();
        }
    }
}
