namespace Lekcia8_Cvicenie
{
    public class Car : Vehicle, IDriveable
    {
        public string ColorCar { get; set; }
        public Car(int id, string brand, string model, string colorCar ) 
            : base (id, brand, model)
        { 
            ColorCar = colorCar;
        }

        public void Drive()
        {
            Console.WriteLine($"Auto {Id}. {Brand} {Model} je pojazdné");
        }

        public override void DisplayInfo ()
        {
            Console.WriteLine($"Farba Auta {Id}. {Brand} {Model} je: {ColorCar}");
        }

        public override void LoanedOut()
        {
            Console.WriteLine($"Auto {Id}: {Brand} {Model} je vypožičané a má farbu: {ColorCar}");
        }
    }
}
