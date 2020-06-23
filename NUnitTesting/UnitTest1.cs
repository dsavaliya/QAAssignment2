using NUnit.Framework;
using QAAssignment2;

namespace NUnitTesting
{
    public class Tests
    {
        [SetUp]

        // This input 2, 3, 4 has taken because It checks input can form triangle or not.
        // This input satisfy all the condition so it can form a triangle. Type of triangle is Scalene triangle.
        [Test]
        public void checkFormTriangle_IsTrue()
        {
            Assert.AreEqual(TriangleSolver.Analyze(2, 3, 4), "This number can form triangle.\nThis Is Scalene Triangle.");
        }

        // This input 4, 5, 3 has taken because It checks input can form triangle or not and if yes type of triangle is Scalene is true.
        // This input satisfy all the condition so it can form a triangle. Type of triangle is Scalene triangle.
        [Test]
        public void TypeoFTriangle_Scalene_IsTrue()
        {
            Assert.AreEqual(TriangleSolver.Analyze(4, 5, 3), "This number can form triangle.\nThis Is Scalene Triangle.");
        }

        // This input 4, 4, 6 has taken because It checks input can form triangle or not and if yes type of triangle is Isosceles is true.
        // This input satisfy all the condition so it can form a triangle. Type of triangle is Isosceles triangle.
        [Test]
        public void TypeOfTriangle_IsIsosceles_IsTrue()
        {
            Assert.AreEqual(TriangleSolver.Analyze(4, 4, 6), "This number can form triangle.\nThis Is Isosceles Triangle.");
        }

        // This input 2, 2, 3 has taken because It checks input can form triangle or not and if yes type of triangle is Isosceles is true.
        // This input satisfy all the condition so it can form a triangle. Type of triangle is Isosceles triangle.
        [Test]
        public void TypeOfTriangle_Isosceles_IsTrue()
        {
            Assert.AreEqual(TriangleSolver.Analyze(2, 2, 3), "This number can form triangle.\nThis Is Isosceles Triangle.");

        }

        // This input 4, 4, 4 has taken because It checks input can form triangle or not and if yes type of triangle is Equilateral is true.
        // This input satisfy all the condition so it can form a triangle. Type of triangle is Equilateral triangle.
        [Test]
        public void TypeOfTriangle_IsEquilateral_IsFalse()
        {
            Assert.AreEqual(TriangleSolver.Analyze(4, 4, 4), "This number can form triangle.\nThis Is Equilateral Triangle.");
        }

        // This input 6, 6, 6 has taken because It checks input can form triangle or not and if yes type of triangle is Equilateral is true.
        // This input satisfy all the condition so it can form a triangle. Type of triangle is Equilateral triangle.
        [Test]
        public void TypeOfTriangle_IsScalene_IsFalse()
        {
            Assert.AreEqual(TriangleSolver.Analyze(6, 6, 6), "This number can form triangle.\nThis Is Equilateral Triangle.");
        }

        // This input 12, -6, 7 has taken because It checks input can form triangle or not.
        // This input is not satisfy all the condition so it can not form a triangle because of Invalid Input.
        [Test]
        public void IsValueTriangle_IsFalse()
        {
            Assert.AreEqual(TriangleSolver.Analyze(12, -6, 7), "Sorry, This number do not form triangle.");
        }

        // This input 0, 1, 3 has taken because It checks input can form triangle or not.
        // This input is not satisfy all the condition so it can not form a triangle because of Invalid Input.
        [Test]
        public void IsValueForTriangle_IsFalse()
        {
            Assert.AreEqual(TriangleSolver.Analyze(0, 1, 3), "Sorry, This number do not form triangle.");
        }
    }
}