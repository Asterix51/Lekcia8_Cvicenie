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
            Console.WriteLine($"Nákladiak {Id} je pojazdný");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Nákladné auto {Id} má kapicitu: {LoadCapacity} kg");
        }

        public void LoadCargo()
        {
            Console.WriteLine($"Nákladné auto {Id} nakladá náklad.");
        }
    }
}
