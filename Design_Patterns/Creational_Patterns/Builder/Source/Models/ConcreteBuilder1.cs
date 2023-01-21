using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Creational_Patterns.Builder.Source.Abstracts;

namespace Design_Patterns.Creational_Patterns.Builder.Source.Models
{
    // constructs and assembles parts of the product by implementing the Builder interface
    // defines and keeps track of the representation it creates
    // provides an interface for retrieving the product
    public class ConcreteBuilder1 : Abstracts.Builder
    {
        private Product _product = new Product();
        public override void BuildPartA()
        {
            _product.Add("PartA");
        }
        public override void BuildPartB()
        {
            _product.Add("PartB");
        }
        public override Product GetResult()
        {
            return _product;
        }
    }
}
