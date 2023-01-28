using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Types.Interfaces
{
    //Generic types can be defined
    //using the<> operator.
    public interface IGenericInterface<T>
    {
        void HandleGenericType(T input);
    }
}
