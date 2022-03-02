using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {

        public static IVehicle GetVehicle(int numOfTires)
        {
            if (numOfTires <= 4)
            {
                return new Car();
            }
            else if (numOfTires >= 4)
            {
                return new Truck();
            }
            else
            {
                return new Car();
            }
        }
    }
}

         
            
        

    


