using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Relationships.Relationships.Src
{
    public class AssociationRelationship
    {
        public void CallAssociation()
        {
            Console.WriteLine();
            Console.WriteLine("Association: I have been called with my method \"CallAssociation\" !");
            Console.WriteLine("Association: I am fully independent, \"RelationshipUser\" does not hold a reference of me and therefore i am only a association.");
        }
    }
}