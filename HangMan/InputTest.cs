using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class InputTest
    {
        public static char PlayerGuess()
        {
            try
            {
                Console.Write("\nGuess on a letter: "); char playerGuess = char.Parse(Console.ReadLine().ToUpper());//try catch
                return playerGuess;
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input, try again");
                Console.ReadKey();
                Console.Clear();

                return PlayerGuess();
            }
        }
    }
}
