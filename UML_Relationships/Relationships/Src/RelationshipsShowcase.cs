using System;
using System.Collections.Generic;
using System.Text;
using UML_Relationships.Relationships.Interfaces;

namespace UML_Relationships.Relationships.Src
{

    // https://www.c-sharpcorner.com/UploadFile/ff2f08/association-aggregation-and-composition/
    // https://stackoverflow.com/questions/12604031/c-sharp-code-for-association-aggregation-composition
    public static class RelationshipsShowcase
    {
        public static void RunUMLRelationshipsShowcase()
        {
            IRelationshipUser relationshipUser = new RelationshipUser();
            AssociationRelationship association = new AssociationRelationship();
            AggregationRelationship aggregation = new AggregationRelationship();

            relationshipUser.UseAssociation(association);
            relationshipUser.UseAggregation(aggregation);
            relationshipUser.UseAggregation();
            relationshipUser.UseComposition();
            
        }
    }

}
