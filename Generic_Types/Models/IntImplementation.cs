using Generic_Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Types.Models
{
    //We can then define a concrete
    //type for the implementation.
    public class IntImplementation : IGenericInterface<int>
    {
        public void HandleGenericType(int input)
        {
            Console.WriteLine("IntImplementation.HandleGenericType() has been called.");
            Console.WriteLine("Input is: " + input);
        }
    }
}
