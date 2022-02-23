using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class WordCreator
    {
        public string RandomEnglishWord()
        {
            string[] listwords = new string[10];
            listwords[0] = "sheep";
            listwords[1] = "goat";
            listwords[2] = "computer";
            listwords[3] = "america";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "jasmine";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "mango";
            Random randGen = new Random();
            var idx = randGen.Next(0, 9);
            string secretWord = listwords[idx].ToUpper();

            return secretWord;
            


        }
        public string CustomWord()
        {
            Console.Write("\nEnter your Secret Word: ");
            SecretWord secretWord = new SecretWord(Console.ReadLine().ToUpper());
            Console.WriteLine("Your Secret Word is: " + secretWord.name);
            return secretWord.name;
                       

            Console.WriteLine("Press any key to Continue..");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
