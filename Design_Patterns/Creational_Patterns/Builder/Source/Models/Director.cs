using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Builder.Source.Models
{
    // constructs an object using the Builder interface
    public class Director
    {
        public void Construct(Abstracts.Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
