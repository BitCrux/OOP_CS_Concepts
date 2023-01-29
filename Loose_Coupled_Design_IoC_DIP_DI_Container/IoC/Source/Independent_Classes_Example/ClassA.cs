using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.Independent_Classes_Example
{
    public class ClassA
    {
        ClassB b;

        public ClassA()
        {
            b = Factory.GetObjectOfB();
        }

        public void Task1()
        {
            // do something here..
            b.SomeMethod();
            // do something here..
        }
    }
}
