using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns.Structural_Patterns.Proxy.Source.Models;

namespace Design_Patterns.Structural_Patterns.Proxy.Source
{
    //https://www.dofactory.com/net/proxy-design-pattern

    //The Proxy design pattern provides a surrogate or placeholder for another object to control access to it.

    //This structural code demonstrates the Proxy pattern which provides a representative
    //object (proxy) that controls access to another similar object.
    public class ProxyDemo
    {
        public void Run()
        {
            Client c = new Client();
            c.Run();
        }
    }
    //The classes and objects participating in this pattern include:

    //Proxy
    //maintains a reference that lets the proxy access the real subject. Proxy may refer to a Subject if the RealSubject and Subject interfaces are the same.
    //provides an interface identical to Subject's so that a proxy can be substituted for for the real subject.
    //controls access to the real subject and may be responsible for creating and deleting it.
    //other responsibilites depend on the kind of proxy:
        //remote proxies are responsible for encoding a request and its arguments and for sending the encoded request to the real subject in a different address space.
        //virtual proxies may cache additional information about the real subject so that they can postpone accessing it.
        //For example, the ImageProxy from the Motivation caches the real images's extent.
        //protection proxies check that the caller has the access permissions required to perform a request.

    //Subject
    //defines the common interface for RealSubject and Proxy so that a Proxy can be used anywhere a RealSubject is expected.

    //RealSubject
    //defines the real object that the proxy represents.
}
