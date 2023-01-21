using Design_Patterns.Behavioral_Patterns.Chain_of_Responsibility.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Chain_of_Responsibility.Source.Models
{
    // handles requests it is responsible for
    // can access its successor
    // if the ConcreteHandler can handle the request, it does so; otherwise it forwards the request to its successor
    public class ConcreteHandler3 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("{0} handled request {1}",
                    this.GetType().Name, request);
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }
}
