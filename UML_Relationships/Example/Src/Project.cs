using System;
using System.Collections.Generic;
using System.Text;

namespace UML_Relationships.Example.Src
{
    public class Project
    {
        private bool _isSuccessful;
        private Manager _projManager;

        public Project(Manager projManager)
        {
            _projManager = projManager;
        }

        public bool GetIsSuccessful()
        {
            return _isSuccessful;
        }

        public void SetIsSuccessful(bool isSuccessful)
        {
            if (isSuccessful)
            {
                _isSuccessful = isSuccessful;
                _projManager.SetSalary(_projManager.GetSalary() + 1);
            }
            else
            {
                _isSuccessful = isSuccessful;
                if(!(_projManager.GetSalary() <= 2))
                {
                    _projManager.SetSalary(_projManager.GetSalary() - 1);
                }
            }
        }
    }
}
