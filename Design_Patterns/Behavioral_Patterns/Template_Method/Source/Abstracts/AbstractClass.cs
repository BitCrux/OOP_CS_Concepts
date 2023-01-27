using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Template_Method.Source.Abstracts
{
    //defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm
    //implements a template method defining the skeleton of an algorithm.The template method calls primitive
    //operations as well as operations defined in AbstractClass or those of other objects.
    public abstract class AbstractClass
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();
        // The "Template method"
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            Console.WriteLine("");
        }
    }
}
