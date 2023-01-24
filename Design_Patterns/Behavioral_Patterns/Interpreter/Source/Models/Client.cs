using Design_Patterns.Behavioral_Patterns.Interpreter.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Interpreter.Source.Models
{
    //builds (or is given) an abstract syntax tree representing a particular sentence in the language that the grammar defines.
    //The abstract syntax tree is assembled from instances of the NonterminalExpression and TerminalExpression classes

    //invokes the Interpret operation
    public class Client
    {
        public void Run()
        {
            Context context = new Context();
            // Usually a tree 
            List<AbstractExpression> list = new List<AbstractExpression>();
            // Populate 'abstract syntax tree' 
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            // Interpret
            foreach (AbstractExpression exp in list)
            {
                exp.Interpret(context);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
