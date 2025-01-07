namespace Lekcia8_Cvicenie
{
    public class Motorcycle : Vehicle, IDriveable
    {
        public bool HasSidecar { get; set; }
        public Motorcycle(int id, string brand, string model, bool hasSidecar)
            : base(id, brand, model)
        {
            HasSidecar = hasSidecar;
        }

        public void Drive()
        {
            Console.WriteLine($"Motorka {Id} je pojazdná");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Motorka {Id} je vybavená Sidecarov: {HasSidecar}");
        }

        public override void LoanedOut()
        {
            Console.WriteLine($"Motorka {Id}: {Brand} {Model} je vybavená Sidecarov: {HasSidecar}");
        }
    }
}

