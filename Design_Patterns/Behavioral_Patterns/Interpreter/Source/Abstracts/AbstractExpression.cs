using Design_Patterns.Behavioral_Patterns.Interpreter.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Interpreter.Source.Abstracts
{
    //declares an interface for executing an operation
    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
}
