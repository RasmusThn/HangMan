using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class GuessedLetter
    {
        
        public List<char> guessedLetters = new List<char>(14);

        public static void Show(GuessedLetter playerGuesses )
        {
            Console.Write("\nYou have guessed on the letters: ");
            foreach (var letter in playerGuesses.guessedLetters)
            {
                Console.Write("'{0}',", letter);
            }
        }
        public void Add(char letter)
        {
            guessedLetters.Add(letter);
            
        }
    }
}
