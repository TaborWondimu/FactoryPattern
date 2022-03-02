using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ConsoleLogger
    {
        public static void VehicleDialogue()
        {
            Console.WriteLine("put in key");
            Thread.Sleep(1000);
            Console.WriteLine("Turn Key");
            Thread.Sleep(1000);

        }
    }
}
