using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models
{
    public class Driver3
    {
        private ICar _car = null;

        [InjectionConstructor]
        public Driver3(ICar car)
        {
            _car = car;
        }

        public Driver3(string name)
        {
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }
    }
}
