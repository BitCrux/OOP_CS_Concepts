using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Flyweight.Source.Models
{
    //creates and manages flyweight objects
    //ensures that flyweight are shared properly.When a client requests a flyweight,
    //the FlyweightFactory objects assets an existing instance or creates one, if none exists.
    public class FlyweightFactory
    {
        private Dictionary<string, Abstracts.Flyweight> _flyweights { get; set; } = new Dictionary<string, Abstracts.Flyweight>();
        // Constructor
        public FlyweightFactory()
        {
            _flyweights.Add("X", new ConcreteFlyweight());
            _flyweights.Add("Y", new ConcreteFlyweight());
            _flyweights.Add("Z", new ConcreteFlyweight());
        }
        public Abstracts.Flyweight GetFlyweight(string key)
        {
            return _flyweights[key];
        }
    }
}
