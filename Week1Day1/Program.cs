using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{        
    class Program
    {

        static void Main(string[] args)
        {
            string input = string.Empty;

            Console.WriteLine("What's name?");
            input = Console.ReadLine();
            Console.WriteLine("\nHi {0}!\n", input);

            Console.WriteLine("What's your age?");
            input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                Console.WriteLine("\nAt age {0}, I was {1} \n", input, result > 25 ? "a superhero" : "a pirate");
            }
            else
            {                
                Console.WriteLine("\nYou are an alien! LOL\n");
            }
            
            Console.WriteLine("What's your favorite color?");
            input = Console.ReadLine();
            Console.WriteLine("\nWhat a coincident, my favorite color is {0}, too!\n\n", input);

        }
    }
}
