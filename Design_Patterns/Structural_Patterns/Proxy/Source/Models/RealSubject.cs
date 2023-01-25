using Design_Patterns.Structural_Patterns.Proxy.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Proxy.Source.Models
{
    //defines the real object that the proxy represents.
    public class RealSubject : Subject 
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
}
