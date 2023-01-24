using Design_Patterns.Behavioral_Patterns.Interpreter.Example;
using Design_Patterns.Behavioral_Patterns.Interpreter.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Interpreter.Source
{
    //https://www.dofactory.com/net/interpreter-design-pattern

    //Given a language, the Interpreter design pattern defines a representation for its grammar
    //along with an interpreter that uses the representation to interpret sentences in the language.

    //This structural code demonstrates the Interpreter patterns, which using a
    //defined grammer, provides the interpreter that processes parsed statements.
    public class InterpreterDemo
    {
        public void Run()
        {
            Client c = new Client();
            c.Run();

            Console.WriteLine("------------Real World Demo - Convert a Roman numeral to a decimal--------------");

            InterpreterExampleDemo ieDemo = new InterpreterExampleDemo();
            ieDemo.Run();
        }
    }
    //The classes and objects participating in this pattern include:

    //AbstractExpression
    //declares an interface for executing an operation

    //TerminalExpression
    //implements an Interpret operation associated with terminal symbols in the grammar.
    //an instance is required for every terminal symbol in the sentence.

    //NonterminalExpression
    //one such class is required for every rule R::= R1R2...Rn in the grammar
    //maintains instance variables of type AbstractExpression for each of the symbols R1 through Rn.
    //implements an Interpret operation for nonterminal symbols in the grammar.Interpret typically calls itself recursively on the variables representing R1 through Rn.

    //Context
    //contains information that is global to the interpreter

    //Client 
    //builds (or is given) an abstract syntax tree representing a particular sentence in the language that the grammar defines.
    //The abstract syntax tree is assembled from instances of the NonterminalExpression and TerminalExpression classes
    //invokes the Interpret operation
}
