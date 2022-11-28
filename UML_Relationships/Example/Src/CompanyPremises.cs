using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Relationships.Example.Src
{
    public sealed class CompanyPremises
    {
        private List<Employee> _checkedInEmployees = new List<Employee>();
        private static CompanyPremises _instance = null;

        public static CompanyPremises Instance
        {
            get{
                if(_instance == null)
                {
                    _instance = new CompanyPremises();
                }
                return _instance;
            }
        }

        public bool EnterPremises(Employee employee)
        {
            if (!_checkedInEmployees.Contains(employee))
            {
                _checkedInEmployees.Add(employee);
                return true;
            }
            return false;
        }
    }
}
