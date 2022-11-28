using System;
using UML_Relationships.Example.Src;
using UML_Relationships.Relationships.Src;

namespace UML_Relationships
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UML Relationships explained");
            Console.WriteLine();

            RelationshipsShowcase.RunUMLRelationshipsShowcase();

            Console.WriteLine();
            Console.WriteLine();

            // Relationship example
            Console.WriteLine("UML Relationship example");
            Manager manager = new Manager("e1m", 4, "Tony"); // Manager to worker -> one to many (Aggregation)
            Worker worker1 = new Worker("e1w", 2, "Arnold"); // Workers can exist independent of Manager
            Worker worker2 = new Worker("e2w", 2, "Rudolf");
            Worker worker3 = new Worker("e3w", 2, "Max");

            SwipeCard sCard = new SwipeCard("sc1"); // Manager will use the card in his methods but without holding its reference (heap address). There for manager has a association to swipecard!

            manager.AddSubordinate(worker1); // Add relationship (Aggregation), manager holds now references to workers (heap addresses). Worker is a reference type.
            manager.AddSubordinate(worker2);
            manager.AddSubordinate(worker3);

            Console.WriteLine("Try to check in in company. Check in?: " + manager.Logon(sCard)); // Manager uses his swipecard -> association
            Console.WriteLine("Try to check in in company. Check in?: " + manager.Logon(sCard));
            Console.WriteLine("Manager salary is: " + manager.GetSalary());
            manager.SetPerformance(true); // Manager has been created with reference to Project-Object -> _managerProj = new Project(this) -> the project exists as long as the manager exists.
                                          // If the manager gets deleted, the project will be too (Composition)
            Console.WriteLine("Manager salary is: " + manager.GetSalary());
            manager.SetPerformance(false); // Uses Project-Object in the method. (Composition)
            Console.WriteLine("Manager salary is: " + manager.GetSalary());
            manager.SetPerformance(false);
            manager.SetPerformance(false);
            manager.SetPerformance(false);
            Console.WriteLine("Manager salary is: " + manager.GetSalary());


        }
    }
}
