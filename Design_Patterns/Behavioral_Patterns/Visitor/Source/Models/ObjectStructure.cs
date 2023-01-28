using Design_Patterns.Behavioral_Patterns.Visitor.Source.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Visitor.Source.Models
{
    //can enumerate its elements
    //may provide a high-level interface to allow the visitor to visit its elements
    //may either be a Composite(pattern) or a collection such as a list or a set
    public class ObjectStructure
    {
        List<Element> elements = new List<Element>();
        public void Attach(Element element)
        {
            elements.Add(element);
        }
        public void Detach(Element element)
        {
            elements.Remove(element);
        }
        public void Accept(Abstracts.Visitor visitor)
        {
            foreach (Element element in elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
