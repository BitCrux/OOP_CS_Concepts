﻿using Design_Patterns.Behavioral_Patterns.Memento.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Memento.Source
{
    //https://www.dofactory.com/net/memento-design-pattern

    //The Memento design pattern without violating encapsulation, captures and externalizes an
    //object‘s internal state so that the object can be restored to this state later.

    //This structural code demonstrates the Memento pattern which temporary
    //saves and restores another object's internal state.
    public class MementoDemo
    {
        public void Run()
        {
            Originator o = new Originator();
            o.State = "On";
            // Store internal state
            Caretaker c = new Caretaker();
            c.SaveState(o.CreateMemento());
            // Continue changing originator
            o.State = "Off";
            // Restore saved state
            c.RestorePreviousState(o);
            // Wait for user
            Console.ReadKey();
        }
    }
    //The classes and objects participating in this pattern include:

    //Memento
    //stores internal state of the Originator object. The memento may store as much or as little of
    //the originator's internal state as necessary at its originator's discretion.
    //protect against access by objects of other than the originator.Mementos have effectively two
    //interfaces.Caretaker sees a narrow interface to the Memento -- it can only pass the memento to the
    //other objects.Originator, in contrast, sees a wide interface, one that lets it access all the data
    //necessary to restore itself to its previous state.Ideally, only the originator that produces the
    //memento would be permitted to access the memento's internal state.
    
    //Originator
    //creates a memento containing a snapshot of its current internal state.
    //uses the memento to restore its internal state

    //Caretaker
    //is responsible for the memento's safekeeping
    //never operates on or examines the contents of a memento.
}
