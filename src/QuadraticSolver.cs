using System;

namespace softwareleb
{
    public class QuadraticSolver
    {
        // Source: https://newbedev.com/csharp-salvatoin-for-quadratic-function-in-c-code-example
        public static string SolveQuadratic(double a, double b, double c)
        {
            if (a == 0)
            {
                return "a = 0";
            }
            double sqrtpart = b * b - 4 * a * c; // Hier rundungs Fehler möglich b * b - 4 * a * c
            // Bsp. 0 könnte auch bereich sein hierführ abschätzung --> Ergänzen
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

                return String.Format("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} j or {2,8:f4} + {3,8:f4} j", x, img, x, img);


            }
            else
            {
                x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);

                return String.Format("One Real Solution: {0,8:f4}", x);
            }

        }

        //Nach Besprechung Hinzgefügt
        public static string SolveQuadraticRealRoots(double a, double b, double c)
        {
            if(b * b - 4 * a * c  < 0){ // Hier rundungs Fehler möglich b * b - 4 * a * c
                return "Imaginary Solutions";
            }
            return SolveQuadratic( a,  b, c);
         }

    }
}
