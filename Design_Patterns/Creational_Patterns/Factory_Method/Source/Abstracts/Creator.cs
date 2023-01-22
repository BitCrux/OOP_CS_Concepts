using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Factory_Method.Source.Abstracts
{
    //declares the factory method, which returns an object of type Product.Creator may also define a 
    //default implementation of the factory method that returns a default ConcreteProduct object.
    //may call the factory method to create a Product object.
    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}
