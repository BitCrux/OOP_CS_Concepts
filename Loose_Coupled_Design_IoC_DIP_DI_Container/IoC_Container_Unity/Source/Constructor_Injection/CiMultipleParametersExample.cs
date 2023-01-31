using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection
{
    public class CiMultipleParametersExample
    {
        public void Run()
        {
            //ou can also inject multiple parameters in the constructor.
            var container = new UnityContainer();

            container.RegisterType<ICar, Audi>();
            container.RegisterType<ICarKey, AudiKey>();

            var driver = container.Resolve<Driver2>();
            driver.RunCar();
        }
    }
}
