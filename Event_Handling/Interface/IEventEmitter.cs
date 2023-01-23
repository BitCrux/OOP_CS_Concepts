using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handling.Interface
{
    public interface IEventEmitter
    {
        event EventHandler<EventData> _fireEvent;
        void ReadInput(string input);
    }
}
