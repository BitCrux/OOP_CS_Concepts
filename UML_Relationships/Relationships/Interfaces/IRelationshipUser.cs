using System;
using System.Collections.Generic;
using System.Text;
using UML_Relationships.Relationships.Src;

namespace UML_Relationships.Relationships.Interfaces
{
    public interface IRelationshipUser
    {
        public void UseAssociation(AssociationRelationship association);

        public void UseAggregation(AggregationRelationship aggregation);

        public void UseAggregation();

        public void UseComposition();
    }
}
