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
            bool result = true;
            int userInput;
            do
            {
                do
                {
                    OptionBook();
                    try
                    {
                        userInput = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Reason : {0}\nEnter valid Number ", e.Message);
                        result = true;
                    }
                } while (true);

                switch (userInput)
                {
                    case 1:
                        int l;
                        int b;
                        int h;
                        //do
                        //{
                            
                        //} while (true);
                        try
                        {
                            Console.WriteLine("-------------------------------------");
                            Console.WriteLine("l = ");
                            l = int.Parse(Console.ReadLine());
                            Console.WriteLine("b = ");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("h = ");
                            h = int.Parse(Console.ReadLine());
                            Console.WriteLine("-------------------------------------");
                            String output = TriangleSolver.Analyze(l, b, h);
                            Console.WriteLine(output);
                            result = true;
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Reason : {0}\nTry Again :(", e.Message);
                            result = true;
                        }

                        break;

                    case 2:

                        Environment.Exit(0);
                        result = false;
                        break;

                    default:
                        Console.WriteLine("Enter valid number");
                        result = true;
                        break;

                } 

            } while (result == true);
        }
    }
}