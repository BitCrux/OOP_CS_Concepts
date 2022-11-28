using System;
using System.Collections.Generic;
using System.Text;
using UML_Relationships.Relationships.Interfaces;

namespace UML_Relationships.Relationships.Src
{
    public class RelationshipUser : IRelationshipUser
    {
        private AggregationRelationship _aggregation;
        private CompositionRelationship _composition;

        public RelationshipUser()
        {
            _composition = new CompositionRelationship();
        }

        public void UseAssociation(AssociationRelationship association)
        {
            Console.WriteLine();
            Console.WriteLine("RelationshipUser: I use the instance of class \"AssociationRelationship\" to call its method \"CallAggregation\".");
            association.CallAssociation();
        }

        public void UseAggregation(AggregationRelationship aggregation)
        {
            Console.WriteLine();
            Console.WriteLine("RelationshipUser: I use the instance of class \"AggregationRelationship\" to assign it to my declaration \"AggregationRelationship _aggregation\" to define it. (definition of variables)");
            _aggregation = aggregation;
            Console.WriteLine("RelationshipUser: I use the variable which holds a reference to the instance of class \"AssociationRelationship\" to call its method \"CallAggregation\".");
            _aggregation.CallAggregation();
        }

        public void UseAggregation()
        {
            if (_aggregation != null)
            {
                UseAggregation(_aggregation);
                return;
            }
            Console.WriteLine();
            Console.WriteLine("The variable \"_aggregation\" is not defined, use the method \"UseAggregation(AggregationRelationship aggregation)\" to define it and to call its methods!");
        }

        public void UseComposition()
        {
            Console.WriteLine();
            Console.WriteLine("RelationshipUser: At my creation (constructor call) i created a instance of class \"CompositionRelationship\" to assign it to my declaration \"CompositionRelationship _composition\" to define it. (definition of variables)");
            Console.WriteLine("RelationshipUser: I use the variable \"CompositionRelationship _composition\" to call its method \"CallComposition\".");
            _composition.CallComposition();
        }

    }
}
