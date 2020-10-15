using AbstractFactory.Factories;
using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factoryWin = new WinFactory();
            IFactory factoryLin = new LinuxFactory();
            IFactory factoryMac = new MacFactory();           
            List<IFactory> list = new List<IFactory>(new IFactory[] { factoryWin, factoryLin, factoryMac });
            foreach (IFactory factory in list)
            {
                var b = factory.createButton();
                var r = factory.createRadioButton();
                var c = factory.createCheckBox();
                Console.WriteLine("I'm {0} factory with objects:", factory.GetType().Name);
                Console.WriteLine("\t {0} {1} {2}", b.GetType().Name, r.GetType().Name, c.GetType().Name);
            }
        }
    }
}
