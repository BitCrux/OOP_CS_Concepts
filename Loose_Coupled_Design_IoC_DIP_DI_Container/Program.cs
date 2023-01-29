using Loose_Coupled_Design_IoC_DIP_DI_Container.DIP.Source.NTier_Architecture_Example.Good_Design_DIP_Abstraction;
using Loose_Coupled_Design_IoC_DIP_DI_Container.IoC.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupled_Design_IoC_DIP_DI_Container
{
    //https://www.tutorialsteacher.com/ioc/introduction
    class Program
    {
        static void Main(string[] args)
        {
            IoCExamples iocExamples = new IoCExamples();
            iocExamples.Run();

            DIPExample dipExample = new DIPExample();
            dipExample.Run();
        }
    }
}
