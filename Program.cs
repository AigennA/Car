namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car  myCar = new Car();
            myCar.Brand = "Tesla";
            myCar.Color = "Black";
            myCar.Year = 2025;
            myCar.HorsePower = 1000;
            myCar.Gears = 1;
            myCar.EngineOn = true;

            Console.WriteLine($"Bilmärke {myCar.Brand}");
            Console.WriteLine($"Färg {myCar.Color}");
            Console.WriteLine($"Årsmodell {myCar.Year}");
            Console.WriteLine($"Hästkrafter {myCar.HorsePower}");
            Console.WriteLine($"Växlar {myCar.Gears}");
            Console.WriteLine($"Motorn är startad {myCar.EngineOn}");
            Console.WriteLine();

        }
    }
}
