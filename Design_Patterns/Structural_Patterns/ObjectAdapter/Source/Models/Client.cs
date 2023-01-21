using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.ObjectAdapter.Source.Models
{
    // collaborates with objects conforming to the Target interface.
    public class Client
    {
        public void UseTarget()
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();
            // Wait for user
            Console.ReadKey();
        }
    }
}
