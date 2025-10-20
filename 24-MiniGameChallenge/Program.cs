//minigame challenge
using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;
string ApplicationExitReason = "";
bool OptionalSpeedRuleEnabled = true;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
    Move();
    if (TerminalResized())
    {
        ApplicationExitReason = "Terminal Resized,";
        shouldExit = true;
    }

    if (shouldExit)
    {
        Console.WriteLine("\n" + ApplicationExitReason + "Quiting application..."); 
        Thread.Sleep(2000);
        Console.Clear();
    }
}

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood() 
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);

    if(food == 2)
    {
        FreezePlayer();
    }
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    System.Threading.Thread.Sleep(1000);
    player = states[0];
}

// Reads directional input from the Console and moves the player
void Move()
{
    int lastX = playerX;
    int lastY = playerY;

    int moveSpeedX = 1;
    int moveSpeedY = 1;

    if (OptionalSpeedRuleEnabled && player == states[1])
    {
        moveSpeedX = 3;
    }

    switch (Console.ReadKey(true).Key)
    {
        case ConsoleKey.UpArrow:
            playerY -= moveSpeedY;
            break;
        case ConsoleKey.DownArrow:
            playerY += moveSpeedY;
            break;
        case ConsoleKey.LeftArrow:
            playerX -= moveSpeedX;
            break;
        case ConsoleKey.RightArrow:
            playerX += moveSpeedX;
            break;
        case ConsoleKey.Escape:
        default:
            ApplicationExitReason = "Non Directional Key, ";
            shouldExit = true;
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++)
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
    PlayerOnFood();
}

//check if the player is touching the food on his left side
bool PlayerOnFood()
{
    if (playerX >= foodX && playerX < foodX + foods[0].Length && playerY == foodY)
    {
        ChangePlayer();
        ShowFood();
        return true;
    }
    return false;
}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}