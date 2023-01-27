using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Stategy.Example.Abstracts
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}
