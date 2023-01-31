using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Constructor_Injection;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Lifetime_Manager;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Method_Injection;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Overrides;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Property_Injection;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Register_Resolve;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source
{
    public class UnityContainerExamples
    {
        public void Run()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------ Register & Resolve ---------------------------");
            Console.WriteLine();

            RegisterResolveExample rre = new RegisterResolveExample();
            rre.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Multiple Registration ---------------------------");
            Console.WriteLine();

            MultipleRegistrationExample mre = new MultipleRegistrationExample();
            mre.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Register Named Type ---------------------------");
            Console.WriteLine();

            RegisterNamedTypeExample rnte = new RegisterNamedTypeExample();
            rnte.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Register Instance ---------------------------");
            Console.WriteLine();

            RegisterInstanceExample rie = new RegisterInstanceExample();
            rie.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Constructor Injection ---------------------------");
            Console.WriteLine();

            ConstructorInjectionExample cie = new ConstructorInjectionExample();
            cie.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Constructor Injection with multiple Parameters ---------------------------");
            Console.WriteLine();

            CiMultipleParametersExample cimpe = new CiMultipleParametersExample();
            cimpe.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Constructor Injection with multiple Constructors ---------------------------");
            Console.WriteLine();

            CiMultipleConstructors cimc = new CiMultipleConstructors();
            cimc.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Constructor Injection with Primitive Type Paramter ---------------------------");
            Console.WriteLine();

            CiPrimitiveTypeParameterExample ciptpe = new CiPrimitiveTypeParameterExample();
            ciptpe.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Property Injection - Dependency Attributes ---------------------------");
            Console.WriteLine();

            DependencyAttributeExample dae = new DependencyAttributeExample();
            dae.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Property Injection - Named Mapping ---------------------------");
            Console.WriteLine();

            PiNamedMappingExample pinme = new PiNamedMappingExample();
            pinme.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Property Injection - Run-Time Configuration ---------------------------");
            Console.WriteLine();

            PiRunTimeConfigurationExample pirtce = new PiRunTimeConfigurationExample();
            pirtce.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Method Injection - Injection Method Attribute ---------------------------");
            Console.WriteLine();

            MiAttributeExample miae = new MiAttributeExample();
            miae.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Method Injection - Run-Time Configuration ---------------------------");
            Console.WriteLine();

            MiRunTimeConfigurationExample mirtce = new MiRunTimeConfigurationExample();
            mirtce.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Overrides - Parameter Override ---------------------------");
            Console.WriteLine();

            ParameterOverrideExample poe1 = new ParameterOverrideExample();
            poe1.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Overrides - Property Override ---------------------------");
            Console.WriteLine();

            PropertyOverrideExample poe2 = new PropertyOverrideExample();
            poe2.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Overrides - Dependency Override ---------------------------");
            Console.WriteLine();

            DependencyOverrideExample doe = new DependencyOverrideExample();
            doe.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Lifetime Manager - Transient Lifetime Manager ---------------------------");
            Console.WriteLine();

            TransientLifetimeManagerExample tlme = new TransientLifetimeManagerExample();
            tlme.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Overrides - Dependency Override ---------------------------");
            Console.WriteLine();

            LmContainerControlledLifetimeManager lmcclm = new LmContainerControlledLifetimeManager();
            lmcclm.Run();

            Console.WriteLine();
            Console.WriteLine("------------------------ Overrides - Dependency Override ---------------------------");
            Console.WriteLine();

            LmHierarchicalLifetimeManager lmhlm = new LmHierarchicalLifetimeManager();
            lmhlm.Run();
        }
    }
}
