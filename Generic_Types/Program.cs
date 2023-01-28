using Generic_Types.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Types
{
    //Generic Types help us to implement functionality without restricting it to a specific
    //type.This is very useful in many ways.
    class Program
    {
        static void Main(string[] args)
        {
            StringImplementation stringImplementation = new StringImplementation();
            stringImplementation.HandleGenericType("string input");

            IntImplementation intImplementation = new IntImplementation();
            intImplementation.HandleGenericType(4711);

            GenericsExample gExample = new GenericsExample();
            Console.WriteLine(gExample.PropertyOfTypeT);
            gExample.MethodAcceptingT(true);
            gExample.MethodReturningT();

            Console.ReadKey();
        }
    }
}
