using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models
{
    public class Driver2
    {
        private ICar _car = null;
        private ICarKey _key = null;

        public Driver2(ICar car, ICarKey key)
        {
            _car = car;
            _key = key;
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} with {1} - {2} mile ", _car.GetType().Name, _key.GetType().Name, _car.Run());
        }
    }
}
