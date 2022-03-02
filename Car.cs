﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            ConsoleLogger.VehicleDialogue();
            Console.WriteLine($"This is a self driving car");
           
        }
    }
}
