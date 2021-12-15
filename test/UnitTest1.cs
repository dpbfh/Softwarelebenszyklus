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
            Assert.AreEqual("a = 0",QuadraticSolver.SolveQuadratic(0, 0, 0));
        }

        [SetCulture("de-AT")]
        [Test]
        public void TestaIsZero()
        {   
            Assert.AreEqual("a = 0",QuadraticSolver.SolveQuadratic(0, 2, 1));
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
            Assert.AreEqual("a = 0",QuadraticSolver.SolveQuadratic(0, 0, 0));
        }

        [SetCulture("en-GB")]
        [Test]
        public void TestaIsZeroGB()
        {   
            Assert.AreEqual("a = 0", QuadraticSolver.SolveQuadratic(0, 2, 1));
        }


        //----------------------- Real Root -----------------
        [SetCulture("de-AT")]
        [Test]
        public void TestSolveQuadraticRealRootssqrtpartPositive()
        {   
            Assert.AreEqual("Two Real Solutions:   1,6667 or   -3,5000",QuadraticSolver.SolveQuadraticRealRoots(6, 11, -35));
        }

        [SetCulture("de-AT")]
        [Test]
        public void TestSolveQuadraticRealRootssqrtpartNegative()
        {   
            Assert.AreEqual("Imaginary Solutions",QuadraticSolver.SolveQuadraticRealRoots(5, 2, 1));
        }
        
        [SetCulture("de-AT")]
        [Test]
        public void TestSolveQuadraticRealRootssqrtparZero()
        {   
            Assert.AreEqual("One Real Solution:  -1,0000",QuadraticSolver.SolveQuadraticRealRoots(2, 4, 2));
        }

        [SetCulture("de-AT")]
        [Test]
        public void TestSolveQuadraticRealRootsAllZero()
        {   
            Assert.AreEqual("a = 0",QuadraticSolver.SolveQuadraticRealRoots(0, 0, 0));
        }

        [SetCulture("de-AT")]
        [Test]
        public void TestSolveQuadraticRealRootsaIsZero()
        {   
            Assert.AreEqual(QuadraticSolver.SolveQuadratic(0, 2, 1),"a = 0");
        }


       
        [SetCulture("en-GB")]
        [Test]
        public void TestSolveQuadraticRealRootssqrtpartNegativeGB()
        {   
            Assert.AreEqual("Imaginary Solutions",QuadraticSolver.SolveQuadraticRealRoots(5, 2, 1));
        }
        
        [SetCulture("en-GB")]
        [Test]
        public void TestSolveQuadraticRealRootssqrtparZeroGB()
        {   
            Assert.AreEqual("One Real Solution:  -1.0000",QuadraticSolver.SolveQuadraticRealRoots(2, 4, 2));
        }

        [SetCulture("en-GB")]
        [Test]
        public void TestSolveQuadraticRealRootsAllZeroGB()
        {   
            Assert.AreEqual("a = 0",QuadraticSolver.SolveQuadraticRealRoots(0, 0, 0));
        }

        [SetCulture("en-GB")]
        [Test]
        public void TestSolveQuadraticRealRootsaIsZeroGB()
        {   
            Assert.AreEqual(QuadraticSolver.SolveQuadratic(0, 2, 1),"a = 0");
        }

    }
}