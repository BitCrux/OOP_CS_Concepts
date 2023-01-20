using Design_Patterns.Creational_Patterns.Abstract_Factory.Source;
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
            AbstractFactoryDemo afDemo = new AbstractFactoryDemo();
            afDemo.Run();
        }
    }
}
