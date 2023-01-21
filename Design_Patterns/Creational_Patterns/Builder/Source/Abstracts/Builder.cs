using Design_Patterns.Creational_Patterns.Builder.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Builder.Source.Abstracts
{
    // specifies an abstract interface for creating parts of a Product object
    public abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
}
