using Design_Patterns.Structural_Patterns.Composite.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Composite.Source.Models
{
    //represents leaf objects in the composition.A leaf has no children.
    //defines behavior for primitive objects in the composition.
    public class Leaf : Component
    {
        // Constructor
        public Leaf(string name): base(name){ }

        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }
        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
