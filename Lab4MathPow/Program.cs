using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name! ");
            var name = Console.ReadLine();

            while (true)
            {
                Console.Write(name + ", please enter an integer!");
                string num1 = Console.ReadLine(); //takes entered number as a string
                bool statement = double.TryParse(num1, out double num2); //converts string to double
                int count = 1;

                if (statement)
                {
                    Console.WriteLine("Number \t Squared \t Cubed");
                    Console.WriteLine("====== \t ======= \t =====");

                    for (count = 1; count <= num2; count++)
                    {
                        double squared = Math.Pow(count, 2); //square 
                        double cubed = Math.Pow(count, 3); //cube
                        Console.WriteLine(count + "\t  " + squared + "\t         " + cubed);
                    }
                    while (true)
                    {
                        Console.Write("Do you want to try another integer [Y/N]?");
                        string answer = Console.ReadLine().ToUpper();
                        if (answer == "Y")
                            break; // Exit the inner while-loop and continue in the outer while loop.
                        if (answer == "N")
                            return;
                    }
                }
                else
                {
                    Console.WriteLine(name + " that is an INVALID input, please enter an integer!");
                }

            }

        }
    }
}
