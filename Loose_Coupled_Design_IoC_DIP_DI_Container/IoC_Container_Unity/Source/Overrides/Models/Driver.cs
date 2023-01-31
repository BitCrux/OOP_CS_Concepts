using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Overrides.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Overrides.Models
{
    public class Driver
    {
        private ICar _car = null;
        public ICar Car
        {
            get { return _car; }
            set { _car = value; }
        }

        public Driver(ICar car)
        {
            _car = car;
        }

        public Driver()
        {
            
        }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
        }
    }
}
