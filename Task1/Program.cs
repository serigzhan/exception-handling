using System;

namespace Task1
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            while (true)
            {


                Console.Write("Input: ");
                string input = Console.ReadLine();

                try
                {
                    PrintFirstLetter(input);
                }
                catch (ArgumentException aex) when (aex.Message.EndsWith("(Parameter 'input')"))
                {
                    Console.WriteLine("Input can't be empty. Try again.");
                }
                catch (OperationCanceledException ocex)
                {
                    Console.WriteLine(ocex.Message);
                    break;
                }

            }
            
        }

        public static void PrintFirstLetter(string input)
        {
            ArgumentException.ThrowIfNullOrEmpty(input, "input");

            if (input == "q")
            {
                throw new OperationCanceledException("Canceled by user.");
            }

            Console.WriteLine(input.Substring(0, 1).ToUpper());
        }
    }
}