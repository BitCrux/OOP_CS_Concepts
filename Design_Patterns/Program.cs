using Design_Patterns.Creational_Patterns.Abstract_Factory.Source;
using Design_Patterns.Structural_Patterns.ObjectAdapter.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactoryDemo afDemo = new AbstractFactoryDemo();
            //afDemo.Run();

            ObjectAdapterDemo oaDemo = new ObjectAdapterDemo();
            oaDemo.Run();
        }
    }
}
