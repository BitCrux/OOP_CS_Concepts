using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Relationships.Relationships.Src
{
    public class AggregationRelationship
    {
        public void CallAggregation()
        {
            Console.WriteLine();
            Console.WriteLine("Aggregation: I have been called with my method \"CallAggregation\" !");
            Console.WriteLine("Aggregation: I have a stronger relationship than an assoziation.");
            Console.WriteLine("Aggregation: The instance of class \"RelationshipUser\" holds a reference of me in its variable \"AggregationRelationship _aggregation\" and therefore i am a aggregation.");
            Console.WriteLine("Aggregation: The reference is saved in the Stack and points to the address in the Heap, where my instance is saved!");
            Console.WriteLine("Aggregation: Even if the instance of \"RelationshipUser\" gets deleted, i will still exist!");
        }
    }
}
