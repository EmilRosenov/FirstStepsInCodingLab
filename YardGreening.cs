using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double m2 = double.Parse(Console.ReadLine());
            double price = m2 * 7.61;
            double discount = price * 0.18;


            Console.WriteLine($"The final price is: {price - discount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    }
}
