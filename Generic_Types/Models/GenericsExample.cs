using Generic_Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Types.Models
{
    //For each concrete implementation, the generic type T must be of the same concrete type!
    public class GenericsExample : IGenericsExample<bool>
    {
        public bool PropertyOfTypeT
        {
            get;
        }

        public void MethodAcceptingT(bool input)
        {
            Console.WriteLine("GenericsExample.MethodAcceptingT() has been called.");
            Console.WriteLine("Input is of type: " + input.GetType());
        }

        public bool MethodReturningT()
        {
            bool returnType = true;
            Console.WriteLine("GenericsExample.MethodReturningT() has been called.");
            Console.WriteLine("Return is of type: " + returnType.GetType());
            return returnType;
        }
    }
}
