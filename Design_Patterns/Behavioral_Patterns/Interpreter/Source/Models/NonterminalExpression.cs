using Design_Patterns.Behavioral_Patterns.Interpreter.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Interpreter.Source.Models
{
    //one such class is required for every rule R ::= R1R2...Rn in the grammar
    //maintains instance variables of type AbstractExpression for each of the symbols R1 through Rn.
    //implements an Interpret operation for nonterminal symbols in the grammar.Interpret typically calls itself recursively on the variables representing R1 through Rn.
    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }
}
