using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Decorator.Source.Abstracts
{
    //maintains a reference to a Component object and defines an interface that conforms to Component's interface.
    public abstract class Decorator : Component
    {
        protected Component component;
        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
