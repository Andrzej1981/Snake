using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            double framerate = 1000 / 5.0;
            //game loop

            while (!exit)
            {
               if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();

                    switch(input.Key)
                    {
                        case ConsoleKey.Escape:
                            exit = true;
                            break;
                        case ConsoleKey.LeftArrow:
                            break;
                        case ConsoleKey.RightArrow:
                            break;
                        case ConsoleKey.LeftArrow:
                            break;
                        case ConsoleKey.LeftArrow:
                            break;

                    }

                    if(DateTime.Now)
                

            }



        }
    }
}
