using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Property_Injection.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Property_Injection.Models
{
    public class Driver1
    {
        public Driver1()
        {
        }

        [Dependency]
        public ICar Car { get; set; }

        public void RunCar()
        {
            Console.WriteLine("Running {0} - {1} mile ", this.Car.GetType().Name, this.Car.Run());
        }
    }
}
