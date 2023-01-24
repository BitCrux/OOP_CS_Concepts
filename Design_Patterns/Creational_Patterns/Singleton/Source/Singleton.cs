using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Singleton.Source
{
    //defines an Instance operation that lets clients access its unique instance. Instance is a class operation.
    //responsible for creating and maintaining its own unique instance.

    //Nothing in this code prevents two threads from accessing this piece of code at the same time!!!
    //(And return two different instances of the same singleton class.)
    public sealed class Singleton
    {
        private static Singleton _instance;
        private string _data;
        public string Data
        {
            get { return _data; }
        }

        // Constructor is 'private'
        private Singleton(string data)
        {
            _data = data;
        }
        public static Singleton Instance(string data)
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (_instance == null)
            {
                _instance = new Singleton(data);
            }
            return _instance;
        }
    }
}
