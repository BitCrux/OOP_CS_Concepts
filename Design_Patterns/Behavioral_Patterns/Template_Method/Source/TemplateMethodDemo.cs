using Design_Patterns.Behavioral_Patterns.Template_Method.Example;
using Design_Patterns.Behavioral_Patterns.Template_Method.Source.Abstracts;
using Design_Patterns.Behavioral_Patterns.Template_Method.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Template_Method.Source
{
    //https://www.dofactory.com/net/template-method-design-pattern

    //The Template Method design pattern defines the skeleton of an algorithm in an operation, deferring
    //some steps to subclasses. This pattern lets subclasses redefine certain steps of an algorithm
    //without changing the algorithm‘s structure.

    //This structural code ddemonstrates the Template Method which provides a skeleton calling sequence of methods.
    //One or more steps can be deferred to subclasses which implement these steps without changing the overall calling sequence.
    public class TemplateMethodDemo
    {
        public void Run()
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();
            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
            // Wait for user
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("-------------------------- template method example demo--------------------------");
            Console.WriteLine();
            TemplateMethodExampleDemo tmeDemo = new TemplateMethodExampleDemo();
            tmeDemo.Run();
        }
    }
    //The classes and objects participating in this pattern include:

    //AbstractClass
    //defines abstract primitive operations that concrete subclasses define to implement steps of an algorithm
    //implements a template method defining the skeleton of an algorithm.The template method calls primitive
    //operations as well as operations defined in AbstractClass or those of other objects.
    
    //ConcreteClass  (CustomerDataObject)
    //implements the primitive operations to carry out subclass-specific steps of the algorithm

}
