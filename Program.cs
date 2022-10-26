// Michelle Malfabon
// August 17 2022

//-------MINI 8----GUESS IT---------//

//Description: Made a guessing number game with 3 levels of difficulty (used different functions that were called for each). Declared the variables at the top and set a guess counter and boolean for the while loop. Used a while loop to set isCorrect as true only when correct answer is given and 
//continue to play while not correct. Used if statements to compare the user input to the random number, and give hints. 


int userChoice;
int userGuess;
int guessCount= 0;
bool isCorrect= false;
int playAgain;

void PlayGame()
{
Console.WriteLine("Play the guessing game!");
Console.WriteLine("Enter 1 for easy, 2 for medium, or 3 for hard");
userChoice = Convert.ToInt32(Console.ReadLine());


if (userChoice == 1)
{
    EasyGame();
}
else if (userChoice == 2)
{
    MediumGame();
}

else if (userChoice == 3)
{
    HardGame();
}

void EasyGame()
{ 
    while (isCorrect== false){
    Random numGen= new Random();
    int number= numGen.Next(1,10);
    Console.WriteLine("Enter a number between 1-10: ");
    userGuess= Convert.ToInt32(Console.ReadLine());
    guessCount++;

    if(userGuess== number){
        Console.WriteLine("Guess: "+ guessCount+ ": CORRECT!  The number is " + number);
        isCorrect= true;
    }else if (userGuess > number){
        Console.WriteLine("Guess "+ guessCount+ ": Try again (LOWER)");
    }else if (userGuess < number){
        Console.WriteLine("Guess "+ guessCount+ ": Try again (HIGHER)");
    }
    else{
        Console.WriteLine("Guess: "+ guessCount+ ": Wrong! The number is " + number);
    }
    }
}
void MediumGame()
{
    while (isCorrect== false){
    Random numGen= new Random();
    int number= numGen.Next(1,10);
    Console.WriteLine("Enter a number between 1-50: ");
    userGuess= Convert.ToInt32(Console.ReadLine());
    guessCount++;
    if(userGuess== number){
        Console.WriteLine("Guess: "+ guessCount+ ": CORRECT!  The number is " + number);
        isCorrect= true;
    }else if (userGuess > number){
        Console.WriteLine("Guess "+ guessCount+ ": Try again (LOWER)");
    }else if (userGuess < number){
        Console.WriteLine("Guess "+ guessCount+ ": Try again (HIGHER)");
    }
    else{
        Console.WriteLine("Guess "+ guessCount+ ": Wrong! The number is " + number);
    }
    }
}
void HardGame()
{
    while (isCorrect== false){
    Random numGen= new Random();
    int number= numGen.Next(1,10);
    Console.WriteLine("Enter a number between 1-100: ");
    userGuess= Convert.ToInt32(Console.ReadLine());
    guessCount++;
    if(userGuess== number){
        Console.WriteLine("Guess "+ guessCount+ ": CORRECT! The number is " + number);
        isCorrect= true;
    }else if (userGuess > number){
        Console.WriteLine("Guess "+ guessCount+ ": Try again (LOWER)");
    }else if (userGuess < number){
        Console.WriteLine("Guess "+ guessCount+ ": Try again (HIGHER)");
    }
    else{
        Console.WriteLine("Guess "+ guessCount+ ": Wrong! The number is " + number);
    }
    }
}
Console.WriteLine("Enter 0 to play again.");
playAgain= Convert.ToInt32(Console.ReadLine());
if (playAgain == 0)
{
    PlayGame();
}
else{
    Console.WriteLine("Goodbye.");
}
}
PlayGame();

