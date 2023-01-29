using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.Dependent_Classes_Example
{
    public class DependentClassesExample
    {
        public void Run()
        {
            //IoC can also be applied when we create objects of a dependent class.
            //First of all, let's understand what we mean by dependency here.
            ClassA a = new ClassA();
            a.Task1();

            //In the above example, class A calls b.SomeMethod() to complete its task1.
            //Class A cannot complete its task without class B and so you can say that
            //"Class A is dependent on class B" or "class B is a dependency of class A".

            //In the object-oriented design approach, classes need to interact with each
            //other in order to complete one or more functionalities of an application, such
            //as in the above example - classes A and B.Class A creates and manages the life
            //time of an object of class B. Essentially, it controls the creation and life
            //time of objects of the dependency class.
        }
    }
}
