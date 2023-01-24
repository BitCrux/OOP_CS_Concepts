using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Iterator.Source.Models
{
    //implements the Iterator interface.
    //keeps track of the current position in the traversal of the aggregate.
    public class ConcreteIterator : Abstracts.Iterator
    {
        ConcreteAggregate aggregate;
        int current = 0;
        // Constructor
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        // Gets first iteration item
        public override object First()
        {
            return aggregate[0];
        }
        // Gets next iteration item
        public override object Next()
        {
            object ret = null;
            if (current < aggregate.Count - 1)
            {
                ret = aggregate[++current];
            }
            return ret;
        }
        // Gets current iteration item
        public override object CurrentItem()
        {
            return aggregate[current];
        }
        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return current >= aggregate.Count;
        }
    }
}
