using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Types.Interfaces
{
    //We can use generic types everywhere we would use any other type:
    //• Return types of a method
    //• Arguments to a method
    //• Types of fields

    public interface IGenericsExample<T>
    {
        T MethodReturningT();
        void MethodAcceptingT(T input);
        T PropertyOfTypeT { get; }
    }

    //We can also use multiple generic types per class if we wish so.
    //public interface IGenericsExample<T1,T2,T3>
    //{
    //    T1 MethodReturningT();
    //    void MethodAcceptingT(T2 input);
    //    T3 PropertyOfTypeT { get; }
    //}
}
