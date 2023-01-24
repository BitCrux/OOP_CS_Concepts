using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Prototype.Source.Abstracts
{
    //declares an interface for cloning itself
    public abstract class Prototype
    {
        string id;
        // Constructor
        public Prototype(string id)
        {
            this.id = id;
        }
        // Gets id
        public string Id
        {
            get { return id; }
        }
        public abstract Prototype Clone();
    }
}
