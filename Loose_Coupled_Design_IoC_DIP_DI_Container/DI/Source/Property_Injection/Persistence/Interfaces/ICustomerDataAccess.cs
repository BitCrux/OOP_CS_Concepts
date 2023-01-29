using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.DI.Source.Property_Injection.Persistence.Interfaces
{
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }
}
