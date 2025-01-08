namespace Lekcia8_Cvicenie
{
    public class Motorcycle : Vehicle, IDriveable
    {
        public double enginePower { get; set; }
        public Motorcycle(int id, string brand, string model, double EnginePower)
            : base(id, brand, model)
        {
            enginePower = EnginePower;
        }

        public void Drive()
        {
            Console.WriteLine($"Motorka {Id}. {Brand} {Model} je pojazdná");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Motorka {Id}. {Brand} {Model} má výkon: {enginePower} kW");
        }

        public override void LoanedOut()
        {
            Console.WriteLine($"Motorka {Id}: {Brand} {Model} má výkon: {enginePower} kW");
        }
    }
}

