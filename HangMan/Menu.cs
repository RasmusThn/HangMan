using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class Menu
    {
        public static void Start()
        {
            char menuChoice;
            do
            {
                Dialog.WelcomeMessage();
                menuChoice = char.Parse(Console.ReadLine().ToUpper());
                
                Console.Clear();
               
                WordCreator creator = new WordCreator();
                Game game = new Game();

                switch (menuChoice)
                {
                    case 'C':
                        {
                            SecretWord secretWord = new SecretWord(creator.CustomWord());
                            game.StartGame(secretWord);
                        }
                        break;
                    case 'R':
                        {
                            SecretWord secretWord = new SecretWord(creator.RandomEnglishWord());                           
                            game.StartGame(secretWord);
                        }
                        break;
                    case 'Q':
                        {
                            Console.WriteLine("Thanks for playing!");
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        break;
                }
            } while (menuChoice != 'Q');
        }
    }
}
