
using System.Xml.Schema;

namespace Lekcia8_Cvicenie
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        protected Vehicle(int id, string brand, string model, int year, int mileage) 
        { 
            Id = id;
            Brand = brand; 
            Model = model;
            Year = year;
            Mileage = mileage;
        }
        public abstract void DisplayInfo();

        public virtual void LoanedOut()
        {
            Console.WriteLine($"Vozidlo {Id} je vypožičané");
        }
    }
}
