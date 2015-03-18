using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticum
{
    class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                try
                {
                    string input = Console.ReadLine().ToLower();

                    if (input == "exit")
                    {
                        break;
                    }
                    else
                    {
                        BaseDishParser dishParser = DishParserFactory.GetDishParser(input);

                        Console.WriteLine(dishParser.Parse());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
