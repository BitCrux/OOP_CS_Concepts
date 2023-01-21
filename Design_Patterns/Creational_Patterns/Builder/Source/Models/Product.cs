using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Builder.Source.Models
{
    // represents the complex object under construction. ConcreteBuilder builds the product's
    // internal representation and defines the process by which it's assembled

    // includes classes that define the constituent parts, including interfaces
    // for assembling the parts into the final result
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}
