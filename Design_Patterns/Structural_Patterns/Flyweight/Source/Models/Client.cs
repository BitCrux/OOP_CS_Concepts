using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Flyweight.Source.Models
{
    //maintains a reference to flyweight(s).
    //computes or stores the extrinsic state of flyweight(s).
    public class Client
    {
        public void Run()
        {
            // Arbitrary extrinsic state
            Context contextWithExtrinsicState = new Context(22);
            FlyweightFactory factory = new FlyweightFactory();

            //Work with different flyweight instances
            Abstracts.Flyweight fx = factory.GetFlyweight("X");
            contextWithExtrinsicState.ExtrinsicState -= 1;
            fx.Operation(contextWithExtrinsicState);
            Abstracts.Flyweight fy = factory.GetFlyweight("Y");
            contextWithExtrinsicState.ExtrinsicState -= 1;
            fy.Operation(contextWithExtrinsicState);
            Abstracts.Flyweight fz = factory.GetFlyweight("Z");
            contextWithExtrinsicState.ExtrinsicState -= 1;
            fz.Operation(contextWithExtrinsicState);

            UnsharedConcreteFlyweight fu = new
                UnsharedConcreteFlyweight();
            contextWithExtrinsicState.ExtrinsicState -= 1;
            fu.Operation(contextWithExtrinsicState);

            // Wait for user
            Console.ReadKey();
        }
    }
}
