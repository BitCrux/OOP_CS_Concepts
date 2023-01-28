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
    public class StringImplementation : IGenericInterface<string>
    {
        public void HandleGenericType(string input)
        {
            Console.WriteLine("StringImplementation.HandleGenericType() has been called.");
            Console.WriteLine("Input is: " + input);
        }
    }
}
