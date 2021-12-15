using System;

namespace softwareleb
{
    class Program
    {
        static void Main(string[] args)

        {

 

            // 6x^2 + 11x - 35 = 0
            System.Console.WriteLine(QuadraticSolver.SolveQuadratic(6, 11, -35));
            

 

            // 5x^2 + 6x + 1 = 0

             System.Console.WriteLine(QuadraticSolver.SolveQuadratic(5, 6, 1));

 

            // 2x^2 + 4x + 2 = 0

             System.Console.WriteLine(QuadraticSolver.SolveQuadratic(2, 4, 2));

 

            // 5x^2 + 2x + 1 = 0

             System.Console.WriteLine(QuadraticSolver.SolveQuadratic(5, 2, 1));

             System.Console.WriteLine(QuadraticSolver.SolveQuadratic(0, 0, 0));

        }
    }
}
