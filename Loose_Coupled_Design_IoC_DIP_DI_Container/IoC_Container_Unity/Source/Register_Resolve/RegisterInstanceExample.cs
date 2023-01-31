using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Register_Resolve.Models;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Register_Resolve.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Register_Resolve
{
    public class RegisterInstanceExample
    {
        public void Run()
        {
            //Unity container allows us to register an existing instance using the RegisterInstance() method.
            //It will not create a new instance for the registered type and we will use the same instance every time.
            var container = new UnityContainer();
            ICar audi = new Audi();
            container.RegisterInstance<ICar>(audi);

            Driver driver1 = container.Resolve<Driver>();
            driver1.RunCar();
            driver1.RunCar();

            Driver driver2 = container.Resolve<Driver>();
            driver2.RunCar();
            //Thus, we can register and resolve different types using Unity container.
        }
    }
}
