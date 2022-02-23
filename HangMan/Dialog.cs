using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class Dialog
    {
        public static void WelcomeMessage()
        {
            Console.Clear();
            Console.WriteLine("************** WELCOME TO HANGMAN **************\n");
            Console.WriteLine("[C]reate your custom word");
            Console.WriteLine("[R]andom English word");
            Console.WriteLine("[Q]uit");
        }
        public static void StartGame(SecretWord secretWord)
        {
            Console.WriteLine("\nThe Secret Word is {0} letters long ", secretWord.name.Length);
            Console.WriteLine("You get 14 guesses");
            Console.WriteLine("\nPress a Key to START");
            Console.ReadKey();
            Console.Clear();
        }
        public static void GameOver(SecretWord secretWord)
        {
            Console.Clear();
            Console.WriteLine("Sorry, You hanged the MAN..");
            Console.WriteLine("The correct word was: {0}", secretWord.name);
            Console.ReadKey();
        }
        public static void GameWon(SecretWord secretWord)
        {
            Console.Clear();
            Console.WriteLine("Congratulations!");
            Console.WriteLine("You guessed the correct word {0} in {1} tries", secretWord.name, secretWord.GuessCount);

            Console.ReadKey();
        }
        public static void GuessCount(SecretWord secretWord)
        {
            Console.WriteLine("\nYou have {0} guesses left", 14 - secretWord.GuessCount);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
