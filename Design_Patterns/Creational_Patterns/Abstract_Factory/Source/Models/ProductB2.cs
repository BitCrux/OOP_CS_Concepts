using Design_Patterns.Creational_Patterns.Abstract_Factory.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Abstract_Factory.Source.Models
{
    // defines a product object to be created by the corresponding concrete factory
    // implements the AbstractProduct interface
    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
              " interacts with " + a.GetType().Name);
        }
    }
}
