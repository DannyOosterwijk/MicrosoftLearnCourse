// methods that return values, Challenge
using System.Diagnostics;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = random.Next(1, 6);
        var roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

string WinOrLose(int target, int roll)
{
    if(roll > target)
    {
        return "You Win!";
    }
    else
    {
        return "You Lose!";
    }
}

bool ShouldPlay()
{
    while (true)
    {
        string input = Console.ReadLine();
        if(input != null)
        {
            input = input.ToLower().Trim();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
        }
    }
    
}