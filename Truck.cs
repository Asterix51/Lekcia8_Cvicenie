namespace Lekcia8_Cvicenie
{
    public class Truck : Vehicle, IDriveable
    {
        public int LoadCapacity { get; set; }
        public Truck(int id, string brand, string model, int loadCapacity)
            : base(id, brand, model)
        {
            LoadCapacity = loadCapacity;
        }

        public void Drive()
        {
            Console.WriteLine($"Nákladiak {Id}. {Brand} {Model} je pojazdný");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Nákladné auto {Id}. {Brand} {Model} má kapicitu: {LoadCapacity} ton");
        }

        public void LoadCargo(int weightCargo)
        {
            Console.WriteLine($"Nákladné auto {Id}. {Brand} {Model} naložilo {weightCargo} kg nákladu.");
            if (weightCargo > (LoadCapacity*1000))
            {
                Console.WriteLine("Nákladné auto je preťažené");
            }
        }
    }
}
