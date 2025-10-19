//Conditional operators

Random coinFlip = new Random();
bool playing = true;
//coin flip minigame
while (playing)
{
    Console.WriteLine("Press enter to flip a coin. to quit, type 'N'");
    string playerInput = "" + Console.ReadLine();
    //wait for player input to continue or quit game
    if (playerInput.ToLower().Equals("n"))
    {
        playing = false;
    }
    else
    {
        //flip a coin see if the player wins
        int flip = coinFlip.Next(0, 2);
        Console.WriteLine($"You landed on {(flip == 0 ? "Heads" : "Tails")}");
    }
}