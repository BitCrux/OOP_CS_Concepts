using Design_Patterns.Structural_Patterns.Proxy.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Proxy.Source.Models
{
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
    public class Proxy : Subject
    {
        private RealSubject realSubject;
        public override void Request()
        {
            // Use 'lazy initialization'
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}
