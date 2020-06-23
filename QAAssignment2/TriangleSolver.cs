using System;
namespace QAAssignment2
{
    public class TriangleSolver
    {
        static public string Analyze(int l, int b, int h)
        {
            if (l == 0 || b == 0 || h == 0 || l < 0 || b < 0 || h < 0 || l + b <= h || b + h <= l || l + h <= b)
            {
                string statement = "Sorry, This number do not form triangle.";
                return statement;
            }
            else
            {
                if (l != b && b != h && l != h)
                {
                    string statement = "This number can form triangle.\nThis Is Scalene Triangle.";
                    return statement;
                }
                else if ((l == b && b != h) || (b == h && l != h) || (l == h && b != h))
                {
                    string statement = "This number can form triangle.\nThis Is Isosceles Triangle.";
                    return statement;
                }
                else if (l == b && b == h && l == h)
                {
                    string statement = "This number can form triangle.\nThis Is Equilateral Triangle.";
                    return statement;
                }
            }
            return null;
        }
    }
}