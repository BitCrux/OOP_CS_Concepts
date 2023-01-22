using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Command.Source.Models
{
    //creates a ConcreteCommand object and sets its receiver
    public class Client
    {
        public void Run()
        {
            // Create receiver, command, and invoker
            Receiver receiver = new Receiver();
            Abstracts.Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();
            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            // Wait for user
            Console.ReadKey();
        }
    }
}
