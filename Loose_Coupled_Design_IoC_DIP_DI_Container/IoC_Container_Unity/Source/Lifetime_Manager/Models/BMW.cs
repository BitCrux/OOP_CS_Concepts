using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Lifetime_Manager.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC_Container_Unity.Source.Lifetime_Manager.Models
{
    public class BMW : ICar 
    {
        private int _miles = 0;

        public int Run()
        {
            return ++_miles;
        }
    }
}
