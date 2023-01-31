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
    public class MultipleRegistrationExample
    {
        public void Run()
        {
            //Unity container will inject the last registered type if you register multiple
            //mappings of the same type.

            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, BMW>();
            container.RegisterType<ICar, Audi>();

            Driver driver = container.Resolve<Driver>();
            driver.RunCar();

            //In the above example, ICar is mapped to both BMW and Audi. However, Unity will inject
            //Audi every time because it has been registered last.
        }
    }
}
