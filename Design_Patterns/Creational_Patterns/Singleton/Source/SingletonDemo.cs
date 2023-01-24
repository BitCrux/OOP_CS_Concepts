using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Singleton.Source
{
    //https://www.dofactory.com/net/singleton-design-pattern

    //The Singleton design pattern ensures a class has only one instance and provide a global point of access to it.

    //This structural code demonstrates the Singleton pattern which assures only a single instance (the singleton) of the class can be created.
    public class SingletonDemo
    {
        public void Run()
        {
            // Constructor is private -- cannot use new
            Singleton s1 = Singleton.Instance("my data");
            Singleton s2 = Singleton.Instance("my new data"); // A instance already exist with "my data", it will not use the new data "my new data"!
            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
                Console.WriteLine("s1 data: " + s1.Data);
                Console.WriteLine("s2 data: " + s2.Data);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
    //The classes and objects participating in this pattern include:

    //Singleton
    //defines an Instance operation that lets clients access its unique instance. Instance is a class operation.
    //responsible for creating and maintaining its own unique instance.
}
