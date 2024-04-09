namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var building = new Building(5);

            Console.WriteLine($"Taille :{building.GetSize()}m");
            Console.WriteLine($"Taille maximum de un étage :{building.GetFloorMaxSize()}m");
            Console.WriteLine($"Nombre d'étages :{building.GetFloorCount()}");
        }
    }
}
