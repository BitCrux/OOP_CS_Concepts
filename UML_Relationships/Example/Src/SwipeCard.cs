using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Relationships.Example.Src
{
    public class SwipeCard
    {
        private string _id;
        public SwipeCard(string id)
        {
            _id = id;
        }

        public bool Swipe(Manager manager, CompanyPremises company)
        {
            return company.EnterPremises(manager);
        }
    }
}
