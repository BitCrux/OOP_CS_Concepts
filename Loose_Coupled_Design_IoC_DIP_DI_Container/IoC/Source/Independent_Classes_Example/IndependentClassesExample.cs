using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.Independent_Classes_Example
{
    public class IndependentClassesExample
    {
        public void Run()
        {
            //The IoC principle suggests to invert the control. This means to delegate the
            //control to another class. In other words, invert the dependency creation
            //control from class A to another class, as shown below.
            ClassA a = new ClassA();
            a.Task1();

            //As you can see above, class A uses Factory class to get an object of class B. Thus, we
            //have inverted the dependent object creation from class A to Factory. Class A no longer
            //creates an object of class B, instead it uses the factory class to get the object of class B.
        }
    }
}
