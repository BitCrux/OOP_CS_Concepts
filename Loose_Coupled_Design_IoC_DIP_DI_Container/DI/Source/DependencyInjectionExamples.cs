using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Constructor_Injection;
using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Method_Injection;
using Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Property_Injection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source
{
    //https://www.tutorialsteacher.com/ioc/dependency-injection

    //In the previous step, related to DIP, we created and used abstraction to make the
    //classes loosely coupled.Here, we are going to implement Dependency Injection and strategy
    //pattern together to move the dependency object creation completely out of the class. This
    //is our third step in making the classes completely loose coupled.

    //Dependency Injection (DI) is a design pattern used to implement IoC. It allows the creation
    //of dependent objects outside of a class and provides those objects to a class through
    //different ways. Using DI, we move the creation and binding of the dependent objects outside
    //of the class that depends on them.

    //The Dependency Injection pattern involves 3 types of classes.

    //Client Class: The client class (dependent class) is a class which depends on the service class
    //Service Class: The service class (dependency) is a class that provides service to the client class.
    //Injector Class: The injector class injects the service class object into the client class.

    //The injector class creates an object of the service class, and injects that object to a client object.
    //In this way, the DI pattern separates the responsibility of creating an object of the service class
    //out of the client class.

    //Types of Dependency Injection

    //As you have seen above, the injector class injects the service(dependency) to the client(dependent). The injector
    //class injects dependencies broadly in three ways: through a constructor, through a property, or through a method.

    //Constructor Injection: In the constructor injection, the injector supplies the
    //service (dependency) through the client class constructor.

    //Property Injection: In the property injection(aka the Setter Injection), the injector
    //supplies the dependency through a public property of the client class.

    //Method Injection: In this type of injection, the client class implements an interface which declares the
    //method(s) to supply the dependency and the injector uses this interface to supply the dependency to the client class.

    //The problem with the previous examples is that we used DataAccessFactory inside the CustomerBusinessLogic class. So, suppose there
    //is another implementation of ICustomerDataAccess and we want to use that new class inside CustomerBusinessLogic. Then, we need
    //to change the source code of the CustomerBusinessLogic class as well. The Dependency injection pattern solves this problem by
    //injecting dependent objects via a constructor, a property, or an interface.
    public class DependencyInjectionExamples
    {
        public void Run()
        {
            ConstructorInjectionExample cie = new ConstructorInjectionExample();
            cie.Run();

            PropertyInjectionExample pie = new PropertyInjectionExample();
            pie.Run();

            MethodInjectionExample mie = new MethodInjectionExample();
            mie.Run();
        }
    }
}
