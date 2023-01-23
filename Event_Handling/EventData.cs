using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handling
{
    //Each emitted event provides an argument object. It is a good idea to provide all
    //useful information in this object instead of assuming a subscribed object will find
    //the associated information elsewhere.
    public class EventData : EventArgs //inherit from EventArgs
    {
        private string _inputData;
        //provide useful information to subscribers as read only
        public string InputData
        {
            get { return _inputData; }
        }

        public EventData(string inputData)
        {
            _inputData = inputData;
        }

    }
}
