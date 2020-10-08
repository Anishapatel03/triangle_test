using System;

namespace TriangleSolver
{
    public class Program
    {
        public static int Analyze(int sideA, int sideB, int sideC)
        {
            int result = 0;
            // check whether a triangle is Euilateral, Isosceles or Scalene
            if (sideA == sideB && sideB == sideC)
            {
                result = 1;
            }
            else if ((sideA == sideB || sideA == sideC) || sideB == sideC)
            {
                result = 2;
            }
            else
            {
                result = 3;
            }
            return result;
        }
        public static bool checkvalue(string value)
        {
            int Ans;
            if (int.TryParse(value, out Ans))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n enter side A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n enter side B : ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n enter side C : ");
            int C = Convert.ToInt32(Console.ReadLine());

            int FinalMatch = Program.Analyze(A, B, C);
            switch (FinalMatch)
            {
                case 1:
                    Console.WriteLine("\n Triangle is an Equilateral");
                    break;
                case 2:
                    Console.WriteLine("\n Triangle is a Isosceles");
                    break;
                case 3:
                    Console.WriteLine("\n Triangle is a Scalene");
                    break;
            }

        }
    }
}


