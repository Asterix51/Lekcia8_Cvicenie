using System.Diagnostics.Metrics;

namespace Lekcia8_Cvicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var driveableArray = new IDriveable[150];
            var vehicleArray = new Vehicle[60];

            int idCounter = 1;

            for (int i = 0; i < 50; i++)
            {
                driveableArray[i] = new Car(i+1, "BrandA", "ModelX", "červená");
                driveableArray[i + 50] = new Motorcycle(i+51, "BrandB", "ModelY", false);
                driveableArray[i + 100] = new Truck(i+101, "BrandC", "ModelZ", 1000);
            }

            for (int i = 0; i < 30; i++)
            {
                vehicleArray[i] = new Car(idCounter++, "BrandA", "ModelX", "červená");
            }
            for (int i = 30; i < 50; i++)
            {
                vehicleArray[i] = new Motorcycle(idCounter++, "BrandB", "ModelY", false);
            }
            for (int i = 50; i < 60; i++)
            {
                vehicleArray[i] = new Truck(idCounter++, "BrandC", "ModelZ", 1000);
            }

            foreach (var driveable in driveableArray)
            {
                driveable.Drive();
            }

            foreach (var vehicle in vehicleArray)
            {
                vehicle.DisplayInfo();
                vehicle.LoanedOut();

                if (vehicle is Truck truck)
                {
                    truck.LoadCargo();
                }
            }
        }
    }
}
