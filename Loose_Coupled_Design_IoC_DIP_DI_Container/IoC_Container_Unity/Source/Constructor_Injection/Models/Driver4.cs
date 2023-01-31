using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models
{
    public class Driver4
    {
        private ICar _car = null;
        private string _name = string.Empty;

        public Driver4(ICar car, string driverName)
        {
            _car = car;
            _name = driverName;
        }

        public void RunCar()
        {
            Console.WriteLine("{0} is running {1} - {2} mile ",
                            _name, _car.GetType().Name, _car.Run());
        }
    }
}
