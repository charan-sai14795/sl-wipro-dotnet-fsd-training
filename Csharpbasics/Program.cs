using System;

namespace Csharpbasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            converttoseconds(2);
            float b=Convert.ToSingle(Console.ReadLine());
            float h = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"area= {Triangle(b,h)} ");
        }
        static void converttoseconds(int mins)
        {
            Console.WriteLine($"{mins}={mins*60}");
        }
        static double Triangle(float b,float h)
        {
            return (b*h)/2;
        }
    }
}
