using NUnit.Framework;
using QAAssignment2;

namespace NUnitTesting
{
    public class Tests
    {
        [SetUp]
        [Test]
        public void checkFormTriangle_IsTrue()
        {
            Assert.AreEqual(TriangleSolver.Analyze(2, 3, 4), "This number can form triangle.\nThis Is Scalene Triangle.");
        }
        [Test]
        public void TypeoFTriangle_Scalene_IsTrue()
        {
            Assert.AreEqual(TriangleSolver.Analyze(4, 5, 3), "This number can form triangle.\nThis Is Scalene Triangle.");
        }
        [Test]
        public void TypeOfTriangle_IsIsosceles_IsTrue()
        {
            Assert.AreEqual(TriangleSolver.Analyze(4, 4, 6), "This number can form triangle.\nThis Is Isosceles Triangle.");
        }
        [Test]
        public void TypeOfTriangle_Isosceles_IsTrue()
        {
            Assert.AreEqual(TriangleSolver.Analyze(2, 2, 3), "This number can form triangle.\nThis Is Isosceles Triangle.");

        }
        [Test]
        public void TypeOfTriangle_IsEquilateral_IsFalse()
        {
            Assert.AreEqual(TriangleSolver.Analyze(4, 4, 4), "This number can form triangle.\nThis Is Equilateral Triangle.");
        }
        [Test]
        public void TypeOfTriangle_IsScalene_IsFalse()
        {
            Assert.AreEqual(TriangleSolver.Analyze(6, 6, 6), "This number can form triangle.\nThis Is Equilateral Triangle.");
        }
        [Test]
        public void IsValueTriangle_IsFalse()
        {
            Assert.AreEqual(TriangleSolver.Analyze(12, -6, 7), "Sorry, This number do not form triangle.");
        }
        [Test]
        public void IsValueForTriangle_IsFalse()
        {
            Assert.AreEqual(TriangleSolver.Analyze(0, 1, 3), "Sorry, This number do not form triangle.");
        }
    }
}