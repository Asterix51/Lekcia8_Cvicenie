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
            string[] znackaMotorky = { "Ducati", "BMW", "Yamaha", "Harley-Davidson", "Honda" };
            //výkon motoriek cca 50-300 kW
            string[] znackaNakladiak = { "Mercedes-Benz", "Volvo", "MAN", "Scania", "DAF" };
            List<List<string>> modelAuta = new List<List<string>>
            {
            new List<string> { "Fabia", "Rapid", "Octavia", "Enyaq iV", "Kamiq", "Karoq", "Kodiaq", "Superb" }, // Škoda
            new List<string> { "Ateca", "Leon", "Ibiza", "Arona", "Tarraco" }, // Seat
            new List<string> { "Model S", "Model 3", "Model X", "Model Y", "Cybertruck" }, // Tesla
            new List<string> { "XC90", "XC60", "S90 Recharge", "S60 Recharge", "V60 Recharge", "EX90", "EX40", "EX30", "EC40" }, // Volvo
            new List<string> { "Passat", "Taigo", "T-Cross", "Tiguan", "T-Roc", "Touran", "ID4", "ID5", "Polo", "Golf", "ID3", "Tayron", "ID7", "Caddy", "Multivan" } // Volkswagen
            };

            List<List<string>> modelMotorky = new List<List<string>>
            {
            new List<string> { "DesertX", "Multistrada", "Diavel", "XDiavel", "Monster", "Hypermotard", "Panigale", "Streetfighter" }, // Ducati
            new List<string> { "R 1250 RS", "S 1000 RR", "K 1600 Grand America", "R 1300 GS Adventure", "CE 02 AM", "C 400 GT" }, // BMW
            new List<string> { "MT-10 SP", "MT-07 Pure", "2024 MT-03", "2024 XSR125 Legacy", "Tracer 9 GT", "Niken GT", "Ténéré 700 Extreme", "YZ450F", "WR450F" }, // Yamaha
            new List<string> { "CVO PAN AMERICA", "HERITAGE CLASSIC", "STREET GLIDE", "ROAD KING SPECIAL", "BREAKOUT 117", "TRI GLIDE ULTRA", "LOW RIDER ST" }, // Harley-Davidson
            new List<string> { "CBR650R", "CBR600RR", "NT1100", "GL1800 Gold Wing", "X-AD", "NC750X", "NX500", "CRF300L", "CB300R", "CB125R", "CB500F", "ADV350", "Forza 750", "Forza 350", "CRF450R" } // Honda
            };

            List<List<string>> modelNakladiak = new List<List<string>>
            {
            new List<string> { "Actros", "Atego", "Arocs", "Econic", "Unimog" }, // Mercedes-Benz
            new List<string> { "FH", "FM", "FMX", "FL", "FE" }, // Volvo
            new List<string> { "TGM", "TGX", "TGL", "TGS" }, // MAN
            new List<string> { "R-Series", "G-Series", "P-Series", "L-Series", "XT" }, // Scania
            new List<string> {  "XF", "CF", "LF", "XG", "XD"  } // DAF
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

                var (brandMotocycle, modelMotocycle) = GenerateRandomCar(random, znackaMotorky, modelMotorky);
                double enginePower = random.Next(50, 300);
                driveableArray[i + 50] = new Motorcycle(i + 51, brandMotocycle, modelMotocycle, enginePower);

                var (brandTruck, modelTruck) = GenerateRandomCar(random, znackaNakladiak, modelNakladiak);
                int LoadCapacity = random.Next(8, 15);
                driveableArray[i + 100] = new Truck(i + 101, brandTruck, modelTruck, LoadCapacity);
            }

            for (int i = 0; i < 30; i++)
            {
                var (brandCar, modelCar) = GenerateRandomCar(random, znackaAuta, modelAuta);
                string color = GenerateRandomColor(random, farby);
                vehicleArray[i] = new Car(idCounter++, brandCar, modelCar, color);
            }
            for (int i = 30; i < 50; i++)
            {
                var (brandMotocycle, modelMotocycle) = GenerateRandomCar(random, znackaMotorky, modelMotorky);
                double enginePower = random.Next(50, 300);
                vehicleArray[i] = new Motorcycle(idCounter++, brandMotocycle, modelMotocycle, enginePower);
            }
            for (int i = 50; i < 60; i++)
            {
                var (brandTruck, modelTruck) = GenerateRandomCar(random, znackaNakladiak, modelNakladiak);
                int LoadCapacity = random.Next(8, 15);
                vehicleArray[i] = new Truck(idCounter++, brandTruck, modelTruck, LoadCapacity);
            }

            foreach (var driveable in driveableArray)
            {
                driveable.Drive();
            }

            foreach (var vehicle in vehicleArray)
            {
                vehicle.DisplayInfo();
                vehicle.LoanedOut();
                int weightCargo = random.Next(5000, 18000);

                if (vehicle is Truck truck)
                {
                    truck.LoadCargo(weightCargo);
                }
            }
        }

        // Metóda na generovanie náhodnéhej značky a modelu
        private static (string, string) GenerateRandomCar(Random random, string[] znacky, List<List<string>> Model)
        {
        int brandIndex = random.Next(znacky.Length);
        string brand = znacky[brandIndex];

        List<string> modelList = Model[brandIndex];
        string model = modelList[random.Next(modelList.Count)];

        return (brand, model);
        }

        // Metóda na generovanie náhodnej farby
        private static string GenerateRandomColor(Random random, string[] farby)
        {
        return farby[random.Next(farby.Length)];
        }

    }
}
