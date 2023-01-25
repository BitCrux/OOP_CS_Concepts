using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Facade.Source
{
    //knows which subsystem classes are responsible for a request.
    //delegates client requests to appropriate subsystem objects.
    public class Facade
    {
        SubSystem1 one;
        SubSystem2 two;
        SubSystem3 three;
        SubSystem4 four;
        public Facade()
        {
            one = new SubSystem1();
            two = new SubSystem2();
            three = new SubSystem3();
            four = new SubSystem4();
        }
        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }
        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
