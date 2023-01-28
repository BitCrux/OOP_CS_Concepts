using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Visitor.Example.Models
{
    public class Clerk : Employee
    {
        // Constructor
        public Clerk() : base("Kevin", 25000.0, 14){ }
    }
}
