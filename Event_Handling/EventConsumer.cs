using Event_Handling.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handling
{
    //To be notified when an event is fired, an class has to subscribe to the event.
    public class EventConsumer : IEventConsumer
    {
        private readonly IEventEmitter _eventEmitter;

        public EventConsumer(IEventEmitter eventEmitter)
        {
            _eventEmitter = eventEmitter;
            _eventEmitter._fireEvent += _eventEmitter_PerformAction; //Subscribe to an event using the += operator
        }

        //Do not forget this, it will lead to a memory leak!
        public void Cleanup()
        {
            _eventEmitter._fireEvent -= _eventEmitter_PerformAction; //Unsubscribe to an event using the -= operator
        }

        private void _eventEmitter_PerformAction(object sender, EventData eventData)
        {
            Console.WriteLine("Event has been fired with input \"{0}\"!", eventData.InputData);
        }
    }
}
