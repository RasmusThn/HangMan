using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class Game
    {
        public void StartGame(SecretWord secretWord)
        {
            Dialog.StartGame(secretWord);

            int guessCounter = 0;
            GuessedLetter guessedLetters = new GuessedLetter();
                      
            char[] secretWordArray = Convert.ToCharArray(secretWord);
            bool isTrue = true;
            while (isTrue)
            {
                char playerGuess = InputTest.PlayerGuess();//Här gissar spelaren
             
                Console.Clear();
                guessedLetters.Add(playerGuess);

                int lettercount = 0;
                for (int i = 0; i < secretWordArray.Length; i++)
                {
                    if (secretWord.name[i] == playerGuess)
                    {
                        secretWordArray[i] = playerGuess;
                        lettercount++;
                    }
                }
                Console.WriteLine("\'" + playerGuess + "\'" + " Appers at " + lettercount + " spot(s)");
                Console.WriteLine(secretWordArray);

                secretWord.GuessCount++;

                Dialog.GuessCount(secretWord);
                GuessedLetter.Show(guessedLetters);
                
                if (guessCounter == 14)
                {
                    Dialog.GameOver(secretWord);  
                    isTrue = false;
                }
                if (!secretWordArray.Contains('*'))
                {
                    Dialog.GameWon(secretWord);   
                    isTrue = false;
                }
            }
        }
    }
}
