using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.Dependent_Classes_Example;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.Independent_Classes_Example;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.NTier_Architecture_Example.Bad_Design_Tight_Coupled;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.NTier_Architecture_Example.Good_Design_Loose_Coupled;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source
{
    //Inversion of Control(IoC) is a design principle(although, some people refer to it as a pattern).
    //As the name suggests, it is used to invert different kinds of controls in object-oriented design
    //to achieve loose coupling.Here, controls refer to any additional responsibilities a class has, other
    //than its main responsibility.This include control over the flow of an application, and control over
    //the flow of an object creation or dependent object creation and binding.
    //IoC is all about inverting the control.

    //The IoC principle helps in designing loosely coupled classes which make them testable, maintainable and extensible.
    public class IoCExamples
    {
        public void Run()
        {
            DependentClassesExample dce = new DependentClassesExample();
            dce.Run();

            IndependentClassesExample ice = new IndependentClassesExample();
            ice.Run();

            BadDesignTightCoupledExample bdtce = new BadDesignTightCoupledExample();
            bdtce.Run();

            GoodDesignLooseCoupledExample gdlce = new GoodDesignLooseCoupledExample();
            gdlce.Run();

        }
    }
}
