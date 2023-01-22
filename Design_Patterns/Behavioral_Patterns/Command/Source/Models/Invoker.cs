using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Command.Source.Models
{
    //asks the command to carry out the request
    public class Invoker
    {
        Abstracts.Command command;
        public void SetCommand(Abstracts.Command command)
        {
            this.command = command;
        }
        public void ExecuteCommand()
        {
            command.Execute();
        }
    }
}
