using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            EventEmitter eventEmitter = new EventEmitter();
            EventConsumer eventConsumer = new EventConsumer(eventEmitter);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Enter \"fire\" to fire a event!");
                string input = Console.ReadLine();
                if (input.Equals("q"))
                {
                    eventConsumer.Cleanup();
                    return;
                }
                eventEmitter.ReadInput(input);
            }
        }
    }
}
