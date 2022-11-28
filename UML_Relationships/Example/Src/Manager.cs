using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Relationships.Example.Src
{
    public class Manager : Employee
    {
        private List<Worker> _subordinates;
        private Project _managerProj;

        public Manager(string id, double salary, string name)
        {
            base._id = id;
            base._salary = salary;
            base._name = name;
            _subordinates = new List<Worker>();
            _managerProj = new Project(this);
        }

        public void AddSubordinate(Worker sub)
        {
            _subordinates.Add(sub);
        }

        public bool Logon(SwipeCard sCard)
        {
            return sCard.Swipe(this, CompanyPremises.Instance);
        }

        public void SetPerformance(bool isGood)
        {
            _managerProj.SetIsSuccessful(isGood);
        }

    }
}
