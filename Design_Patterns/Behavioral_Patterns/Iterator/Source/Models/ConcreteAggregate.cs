using Design_Patterns.Behavioral_Patterns.Iterator.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Iterator.Source.Models
{
    //implements the Iterator creation interface to return an instance of the proper ConcreteIterator
    public class ConcreteAggregate : Aggregate
    {
        List<object> items = new List<object>();
        public override Abstracts.Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        // Get item count
        public int Count
        {
            get { return items.Count; }
        }
        // Indexer
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
