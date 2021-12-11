using System;

namespace softwareleb
{
    class Program
    {
        public static string SolveQuadratic(double a, double b, double c)

        {

            double sqrtpart = b * b - 4 * a * c;

            double x, x1, x2, img;

            if (sqrtpart > 0)

            {

                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);

                x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);

                return String.Format("Two Real Solutions: {0,8:f4} or  {1,8:f4}", x1, x2);
            }

            else if (sqrtpart < 0)

            {

                sqrtpart = -sqrtpart;

                x = -b / (2 * a);

                img = System.Math.Sqrt(sqrtpart) / (2 * a);

                return  String.Format("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} i or {2,8:f4} + {3,8:f4} i", x, img, x, img);


            }

            else

            {

                x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);

                return String.Format("One Real Solution: {0,8:f4}", x);
            }

        }

 

 

        static void Main(string[] args)

        {

 

            // 6x^2 + 11x - 35 = 0
            System.Console.WriteLine(SolveQuadratic(6, 11, -35));
            

 

            // 5x^2 + 6x + 1 = 0

             System.Console.WriteLine(SolveQuadratic(5, 6, 1));

 

            // 2x^2 + 4x + 2 = 0

             System.Console.WriteLine(SolveQuadratic(2, 4, 2));

 

            // 5x^2 + 2x + 1 = 0

             System.Console.WriteLine(SolveQuadratic(5, 2, 1));

        }
    }
}
