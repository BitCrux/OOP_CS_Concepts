using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Chain_of_Responsibility.Source.Abstracts
{
    // defines an interface for handling the requests
    // (optional) implements the successor link
    public abstract class Handler
    {
        protected Handler _successor;
        public void SetSuccessor(Handler successor)
        {
            _successor = successor;
        }
        public abstract void HandleRequest(int request);
    }
}
