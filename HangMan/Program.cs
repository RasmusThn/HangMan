Menu();

void Menu()
{   
    while (true)
    {
        Console.Clear();
        Console.WriteLine("************** WELCOME TO HANGMAN **************\n");
        Console.WriteLine("[C]reate your custom word");
        Console.WriteLine("[R]andom English word");
        Console.WriteLine("[Q]uit");
        char menuChoice = char.Parse(Console.ReadLine().ToUpper());
        Console.Clear();

        switch (menuChoice)
        {
            case 'C':
                {
                    CustomWordGame();
                }
                break;
            case 'R':
                {
                    RandomEnglishWord();
                }
                break;
            case 'Q':
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }break;
            default:
                break;
        }

    }
}

void RandomEnglishWord()
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
    char[] secretWordArray = new char[secretWord.Length];
    for (int i = 0; i < secretWord.Length; i++)
    {
        secretWordArray[i] = '*';
    }

    StartGame(secretWord, secretWordArray);
}

void CustomWordGame()
{
    Console.Write("\nEnter your Secret Word: ");
    string secretWord = Console.ReadLine().ToUpper();
    Console.WriteLine("Your Secret Word is: " + secretWord);

    char[] secretWordArray = new char[secretWord.Length];
    for (int i = 0; i < secretWord.Length; i++)
    {
        secretWordArray[i] = '*';
    }
    Console.WriteLine("Press any key to let the player start guessing the word..");
    Console.ReadKey();
    Console.Clear();
    StartGame(secretWord, secretWordArray);
}

void StartGame(string secretWord, char[] secretWordArray)
{
    Console.WriteLine("\nThe Secret Word is {0} letters long ", secretWord.Length);
    Console.WriteLine("You get 14 guesses");
    Console.WriteLine("\nPress a Key to START");
    Console.ReadKey();
    Console.Clear();

    int guessCounter = 0;
    List<char> guessedWords = new List<char>(14);
    bool ifTrue = true;
    while (ifTrue)
    {      
        char playerGuess = TryPlayerGuess();
       
        Console.Clear();
        guessedWords.Add(playerGuess);
        int lettercount = 0;
        for (int i = 0; i < secretWordArray.Length; i++)
        {

            if (secretWord[i] == playerGuess)
            {
                secretWordArray[i] = playerGuess;
                lettercount++;
            }
        }
        Console.WriteLine("\'" + playerGuess + "\'" + " Appers at " + lettercount + " spot(s)");
        Console.WriteLine(secretWordArray);
      

        guessCounter++;
        Console.WriteLine("\nYou have {0} guesses left", 14 - guessCounter);
        Console.ReadKey();
        Console.Clear();
        Console.Write("\nYou have guessed on the letters: ");
        foreach (var item in guessedWords)
        {
            Console.Write("'{0}',", item);
        }
        if (guessCounter == 14)
        {
            Console.Clear();
            Console.WriteLine("Sorry, You hanged the MAN..");
            Console.WriteLine("The correct word was: {0}", secretWord);
            Console.ReadKey();
            ifTrue = false;
        }
        if (!secretWordArray.Contains('*'))
        {
            Console.Clear();
            Console.WriteLine("Congratulations!");
            Console.WriteLine("You guessed the correct word {0} in {1} tries",secretWord,guessCounter);
            Console.ReadKey();
            ifTrue = false;
        }
    }   
}

char TryPlayerGuess()
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
        
        return TryPlayerGuess();
    }
}