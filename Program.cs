using System;
namespace FactoryPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
          
            int numOfWheels;
            bool input = false;
            do
            {
                Console.WriteLine("Please Enter Number Of Tires");
                input = int.TryParse(Console.ReadLine(), out numOfWheels);
            } while (input == false);
          

            IVehicle vehicle = VehicleFactory.GetVehicle(numOfWheels);
            vehicle.Drive();
          
        }
    }
}