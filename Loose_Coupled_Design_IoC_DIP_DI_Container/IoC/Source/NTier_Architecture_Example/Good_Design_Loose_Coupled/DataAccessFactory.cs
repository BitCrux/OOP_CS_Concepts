using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source.NTier_Architecture_Example.Good_Design_Loose_Coupled
{
    //Let's use the Factory pattern to implement IoC in the above example, as the first step towards attaining loosely coupled classes.

    //First, create a simple Factory class which returns an object of the DataAccess class as shown below.
    public class DataAccessFactory
    {
        public static DataAccess GetDataAccessObj()
        {
            return new DataAccess();
        }
    }
}
