using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Iterator.Source.Models
{
    public class Client
    {
        public void Run()
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";
            // Create Iterator and provide aggregate
            Abstracts.Iterator i = a.CreateIterator();
            Console.WriteLine("Iterating over collection:");
            object item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
