//Conditional operators

Random coinFlip = new Random();
bool playing = true;
while (playing)
{
    Console.WriteLine("Press enter to flip a coin. to quit, type 'N'");
    string playerInput = "" + Console.ReadLine();
    if (playerInput.ToLower().Equals("n"))
    {
        playing = false;
    }
    else
    {
        int flip = coinFlip.Next(0, 2);
        Console.WriteLine($"You landed on {(flip == 0 ? "Heads" : "Tails")}");
    }
}