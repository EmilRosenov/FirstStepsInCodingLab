using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberDogs = int.Parse(Console.ReadLine());
            int numberOtherAnimals = int.Parse(Console.ReadLine());

            double sum = numberDogs * 2.5 + numberOtherAnimals * 4;

            Console.WriteLine($"{sum} lv.");
        }
    }
}
