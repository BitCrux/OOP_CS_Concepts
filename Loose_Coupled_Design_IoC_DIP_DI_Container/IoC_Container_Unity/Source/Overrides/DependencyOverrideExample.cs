using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Overrides.Models;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Overrides.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Resolution;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Overrides
{
    //The DependencyOverride class can be used to override the type of dependency and its
    //value, irrespective of whether dependencies are provided through a
    //constructor, a property or a method.

    //You can override a registered method injection and provide a different
    //parameter value when you resolve it.
    public class DependencyOverrideExample
    {
        public void Run()
        {
            var container = new UnityContainer().RegisterType<ICar, BMW>();

            var driver1 = container.Resolve<Driver>();
            driver1.RunCar();

            //Override the dependency
            var driver2 = container.Resolve<Driver>(new DependencyOverride<ICar>(new Audi()));
            driver2.RunCar();
        }
    }
}
