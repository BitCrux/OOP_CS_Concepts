using Design_Patterns.Behavioral_Patterns.Interpreter.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Interpreter.Source.Models
{
    //implements an Interpret operation associated with terminal symbols in the grammar.
    //an instance is required for every terminal symbol in the sentence.
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }
}
