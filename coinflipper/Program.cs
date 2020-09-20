using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HeadsTails
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPlaying = true;
            int wins = 0;
            int loses = 0;
            bool heads = true;
            char playerInput;
            Random rnd = new Random();
            while (isPlaying)
            {
                Console.WriteLine("Wins: {0} Loses: {1}", wins, loses);
                Console.WriteLine("H for heads, T for tails, E - exit");
                if (rnd.Next(0, 101) < 50)
                {
                    heads = true;
                }
                else
                {
                    heads = false;
                }
                playerInput = Char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine("");
                if (playerInput == 'h')
                {
                    if (heads)
                    {
                        wins++;
                    }
                    else
                    {
                        loses++;
                    }
                }
                else if (playerInput == 't')
                {
                    if (heads)
                    {
                        loses++;
                    }
                    else
                    {
                        wins++;
                    }
                }
                else if (playerInput == 'e')
                {
                    isPlaying = false;
                }
            }
        }
    }
}