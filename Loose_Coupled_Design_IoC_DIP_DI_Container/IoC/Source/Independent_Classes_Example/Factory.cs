using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.Independent_Classes_Example
{
    public class Factory
    {
        public static ClassB GetObjectOfB()
        {
            return new ClassB();
        }
    }
}
