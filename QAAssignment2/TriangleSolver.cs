using System;
namespace QAAssignment2
{
    public class TriangleSolver
    {
        static public Boolean scaleneTriangle(int l, int b, int h)
        {
            if (l != b && b != h && l != h)
            {
                return true;
            }
            return false;
        }
        static public Boolean isoscelesTriangle(int l, int b, int h)
        {
            if (l == b && b != h)
            {
                return true;
            }
            else if (b == h && l != h)
            {
                return true;
            }
            else if (l == h && b != h)
            {
                return true;
            }

            return false;
        }
        static public Boolean equilateralTriangle(int l, int b, int h)
        {
            if (l == b && b == h && l == h)
            {
                return true;
            }
            return false;
        }
        
        static public string Analyze(int l, int b, int h)
        {
            if (l + b <= h || l + h <= b || b + h <= l)
            {
                string statement = "Sorry, This number do not form triangle.";
                return statement;
            }
            else
            {
                if (scaleneTriangle(l, b, h))
                {
                    string statement = "This number can form triangle.\nThis Is Scalene Triangle.";
                    return statement;
                }
                else if (isoscelesTriangle(l, b, h))
                {
                    string statement = "This number can form triangle.\nThis Is Isosceles Triangle.";
                    return statement;
                }
                else if (equilateralTriangle(l, b, h))
                {
                    string statement = "This number can form triangle.\nThis Is Equilateral Triangle.";
                    return statement;
                }
            }
            return null;
        }
    }
}
