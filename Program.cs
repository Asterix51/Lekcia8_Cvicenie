using System;
using System.Diagnostics.Metrics;

namespace Lekcia8_Cvicenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] farby = { "červená", "modrá", "zelená", "biela", "čierna", "sivá", "žltá", "oranžová", "fialová", "hnedá" };
            string[] znackaAuta = { "Škoda", "Seat", "Tesla", "Volvo", "Volkswagen" };

            List<List<string>> modelAuta = new List<List<string>>
            {
            new List<string> { "Fabia", "Rapid", "Octavia", "Enyaq iV", "Kamiq", "Karoq", "Kodiaq", "Superb"  }, // Škoda
            new List<string> { "Ateca", "Leon", "Ibiza", "Arona", "Tarraco" }, // Seat
            new List<string> { "Model S", "Model 3", "Model X", "Model Y", "Cybertruck" }, // Tesla
            new List<string> { "XC90", "XC60", "S90 Recharge", "S60 Recharge", "V60 Recharge", "EX90", "EX40", "EX30", "EC40" }, // Volvo
            new List<string> { "Passat", "Taigo", "T-Cross", "Tiguan", "T-Roc", "Touran", "ID4", "ID5", "Polo", "Golf", "ID3", "Tayron", "ID7", "Caddy", "Multivan" } // Volkswagen

            };


            var driveableArray = new IDriveable[150];
            var vehicleArray = new Vehicle[60];
            var random = new Random();
            int idCounter = 1;

            for (int i = 0; i < 50; i++)
            {
                var (brandCar, modelCar) = GenerateRandomCar(random, znackaAuta, modelAuta);
                string color = GenerateRandomColor(random, farby);
                driveableArray[i] = new Car(i + 1, brandCar, modelCar, color);


                driveableArray[i + 50] = new Motorcycle(i + 51, "BrandB", "ModelY", false);
                driveableArray[i + 100] = new Truck(i + 101, "BrandC", "ModelZ", 1000);
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

        private static (string, string) GenerateRandomCar(Random random, string[] znacky, List<List<string>> auta)
        {
        int brandIndex = random.Next(znacky.Length);
        string brandCar = znacky[brandIndex];

        List<string> modelList = auta[brandIndex];
        string modelCar = modelList[random.Next(modelList.Count)];

        return (brandCar, modelCar);
        }

        // Metóda na generovanie náhodnej farby
        private static string GenerateRandomColor(Random random, string[] farby)
        {
        return farby[random.Next(farby.Length)];
        }

    }
}
