using NUnit.Framework;

namespace softwareleb
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [SetCulture("de-AT")]
        [Test]
        public void TestsqrtpartPositive()
        {   
            Assert.AreEqual("Two Real Solutions:   1,6667 or   -3,5000",QuadraticSolver.SolveQuadratic(6, 11, -35));
        }

        [SetCulture("de-AT")]
        [Test]
        public void TestsqrtpartNegative()
        {   
            Assert.AreEqual("Two Imaginary Solutions:  -0,2000 +   0,4000 j or  -0,2000 +   0,4000 j",QuadraticSolver.SolveQuadratic(5, 2, 1));
        }
        
        [SetCulture("de-AT")]
        [Test]
        public void TestsqrtparZero()
        {   
            Assert.AreEqual("One Real Solution:  -1,0000",QuadraticSolver.SolveQuadratic(2, 4, 2));
        }

        [SetCulture("de-AT")]
        [Test]
        public void TestAllZero()
        {   
            Assert.AreEqual("Solution is:      NaN",QuadraticSolver.SolveQuadratic(0, 0, 0));
        }

        [SetCulture("de-AT")]
        [Test]
        public void TestaIsZero()
        {   
            Assert.AreEqual(QuadraticSolver.SolveQuadratic(0, 2, 1),"One Real Solution:  -0,5000");
        }


       
        [SetCulture("en-GB")]
        [Test]
        public void TestsqrtpartNegativeGB()
        {   
            Assert.AreEqual("Two Imaginary Solutions:  -0.2000 +   0.4000 j or  -0.2000 +   0.4000 j",QuadraticSolver.SolveQuadratic(5, 2, 1));
        }
        
        [SetCulture("en-GB")]
        [Test]
        public void TestsqrtparZeroGB()
        {   
            Assert.AreEqual("One Real Solution:  -1.0000",QuadraticSolver.SolveQuadratic(2, 4, 2));
        }

        [SetCulture("en-GB")]
        [Test]
        public void TestAllZeroGB()
        {   
            Assert.AreEqual("Solution is:      NaN",QuadraticSolver.SolveQuadratic(0, 0, 0));
        }

        [SetCulture("en-GB")]
        [Test]
        public void TestaIsZeroGB()
        {   
            Assert.AreEqual(QuadraticSolver.SolveQuadratic(0, 2, 1),"One Real Solution:  -0.5000");
        }
    }
}