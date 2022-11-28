using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Relationships.Relationships.Src
{
    public class CompositionRelationship
    {
        public void CallComposition()
        {
            Console.WriteLine();
            Console.WriteLine("Composition: I have been called with my method \"CallComposition\"!");
            Console.WriteLine("Composition: I have a stronger relationship than an aggregation and a assoziation.");
            Console.WriteLine("Composition: The instance of class \"RelationshipUser\" created me at its constructor call (new CompositionRelationship), therefore i am a composition!");
            Console.WriteLine("Composition: If the instance of \"RelationshipUser\" gets deleted, i will be deleted too!");
        }
    }

}
