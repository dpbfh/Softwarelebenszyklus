using NUnit.Framework;

namespace softwareleb
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestsqrtpartPositive()
        {   
            Assert.AreEqual("Two Real Solutions:   1,6667 or   -3,5000",QuadraticSolver.SolveQuadratic(6, 11, -35));
        }

        [Test]
        public void TestsqrtpartNegative()
        {   
            Assert.AreEqual("Two Imaginary Solutions:  -0,2000 +   0,4000 j or  -0,2000 +   0,4000 j",QuadraticSolver.SolveQuadratic(5, 2, 1));
        }

        [Test]
        public void TestsqrtparZero()
        {   
            Assert.AreEqual("One Real Solution:  -1,0000",QuadraticSolver.SolveQuadratic(2, 4, 2));
        }

        [Test]
        public void TestAllZero()
        {   
            Assert.AreEqual("Solution is:      NaN",QuadraticSolver.SolveQuadratic(0, 0, 0));
        }

        [Test]
        public void TestaIsZero()
        {   
            Assert.AreEqual(QuadraticSolver.SolveQuadratic(0, 2, 1),"One Real Solution:  -0,5000");
        }
    }
}