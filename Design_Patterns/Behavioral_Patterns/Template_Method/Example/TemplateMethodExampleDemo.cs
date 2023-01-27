using Design_Patterns.Behavioral_Patterns.Template_Method.Example.Abstracts;
using Design_Patterns.Behavioral_Patterns.Template_Method.Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Template_Method.Example
{
    //This real-world code demonstrates a Template method named Run() which provides a
    //skeleton calling sequence of methods. Implementation of these steps are deferred
    //to the CustomerDataObject subclass which implements the Connect, Select, Process, and Disconnect methods.
    public class TemplateMethodExampleDemo
    {
        public void Run()
        {
            DataAccessor categories = new Categories();
            categories.Run(5);
            DataAccessor products = new Products();
            products.Run(3);
            // Wait for user
            Console.ReadKey();
        }
    }
}
