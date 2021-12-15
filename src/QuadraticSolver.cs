using System;

namespace softwareleb
{
    public class QuadraticSolver
    {
        public static string SolveQuadratic(double a, double b, double c)
        {

            double sqrtpart = b * b - 4 * a * c;

            double x, x1, x2, img;

            if (a != 0 && sqrtpart > 0)

            {

                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);

                x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);

                return String.Format("Two Real Solutions: {0,8:f4} or  {1,8:f4}", x1, x2);
            }

            else if (a != 0 && sqrtpart < 0)

            {

                sqrtpart = -sqrtpart;

                x = -b / (2 * a);

                img = System.Math.Sqrt(sqrtpart) / (2 * a);

                return String.Format("Two Imaginary Solutions: {0,8:f4} + {1,8:f4} j or {2,8:f4} + {3,8:f4} j", x, img, x, img);


            }
            else
            {
                if (a == 0)
                {
                    if (double.IsNaN(-c / b))
                    {
                        return String.Format("Solution is: {0,8:f4}", double.NaN);

                    }
                    return String.Format("One Real Solution: {0,8:f4}", -c / b);
                }

                x = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);


                return String.Format("One Real Solution: {0,8:f4}", x);
            }

        }


    }
}
