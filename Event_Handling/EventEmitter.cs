using Event_Handling.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handling
{
    //A class that emits events has to declare this.
    public class EventEmitter : IEventEmitter
    {
        //Use the event keyword to declare an event
        //Use the EventHandler type with the type of your event argument as the type of your event handler
        public event EventHandler<EventData> _fireEvent = delegate { }; //Declare an event handler and initialize with an empty list of delegates

        public void ReadInput(string input)
        {
            if (input.Equals("fire"))
            {
                performAction_CheckInput(input);
            }
        }

        private void performAction_CheckInput(string input)
        {
            _fireEvent(this, new EventData(input)); //Fire the event
        }
    }
}
