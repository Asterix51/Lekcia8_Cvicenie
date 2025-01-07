namespace Lekcia8_Cvicenie
{
    public abstract class Vehicle
    {
        public int Id { get; private set; }
        public string Brand { get; set; }
        public string Model { get; set; }


        protected Vehicle(int id, string brand, string model) 
        { 
            Id = id;
            Brand = brand; 
            Model = model;

        }
        public abstract void DisplayInfo();

        public virtual void LoanedOut()
        {
            Console.WriteLine($"Vozidlo {Id} je vypožičané");
        }
    }
}
