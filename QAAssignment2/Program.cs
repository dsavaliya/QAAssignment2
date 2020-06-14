using System;

namespace QAAssignment2
{
    class Program
    {
        public static void OptionBook()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("\nSelect some option");
            Console.WriteLine("1.Enter triangle dimensions");
            Console.WriteLine("2.Exit");
            Console.WriteLine("-------------------------------------");
        }
        static void Main(string[] args)
        {
            OptionBook();
            int userInput;
            userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    int l;
                    int b;
                    int h;
                    do
                    {
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("l = ");
                        l = int.Parse(Console.ReadLine());
                        Console.WriteLine("b = ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("h = ");
                        h = int.Parse(Console.ReadLine());
                        Console.WriteLine("-------------------------------------");
                        if (l == 0 || b == 0 || h == 0 || l < 0 || b < 0 || h < 0)
                        {
                            Console.WriteLine("Enter valid number");
                        }
                        else
                        {
                            String output = TriangleSolver.Analyze(l, b, h);
                            Console.WriteLine(output);
                            break;
                        }
                    } while (true);
                    break;

                case 2:

                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Please Enter Appropriate Input!!!...");
                    break;

            } while (true) ;
        }
    }
}
