using Design_Patterns.Behavioral_Patterns.Observer.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Observer.Source
{
    //https://www.dofactory.com/net/observer-design-pattern

    //The Observer design pattern defines a one-to-many dependency between objects so that when
    //one object changes state, all its dependents are notified and updated automatically.

    //This structural code demonstrates the Observer pattern in which registered
    //objects are notified of and updated with a state change.
    public class ObserverDemo
    {
        public void Run()
        {
            // Configure Observer pattern
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "X"));
            s.Attach(new ConcreteObserver(s, "Y"));
            s.Attach(new ConcreteObserver(s, "Z"));
            // Change subject and notify observers
            s.SubjectState = "ABC";
            s.Notify();
            // Wait for user
            Console.ReadKey();
        }
    }
    //The classes and objects participating in this pattern include:

    //Subject
    //knows its observers. Any number of Observer objects may observe a subject
    //provides an interface for attaching and detaching Observer objects.

    //ConcreteSubject
    //stores state of interest to ConcreteObserver
    //sends a notification to its observers when its state changes

    //Observer
    //defines an updating interface for objects that should be notified of changes in a subject.

    //ConcreteObserver
    //maintains a reference to a ConcreteSubject object
    //stores state that should stay consistent with the subject's
    //implements the Observer updating interface to keep its state consistent with the subject's
}
