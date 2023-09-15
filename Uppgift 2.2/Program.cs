using System;
namespace Uppgift_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många meter hoppade Elin?");
            float ElinHopp = float.Parse(Console.ReadLine());
            Console.WriteLine("Hur många meter hoppade Alma?");
            float AlmaHopp = float.Parse(Console.ReadLine());

            Console.WriteLine($"Elin hoppade {Math.Round(ElinHopp - AlmaHopp,2)} meter längre än Alma."); //Avrundar för att operationer med float ibland ger lite fel svar

            Console.ReadKey();
        }
    }
}