//do while loops


//Code challenge 1
/*string? readResult;
Console.WriteLine("Enter a number between 5 and 10");
do
{
    readResult = Console.ReadLine();
    int number = 0;
    bool validNumber = int.TryParse(readResult, out number);
    if (validNumber)
    {
        if (number >= 5 && number <= 10)
        {
            Console.WriteLine("The number " + number + " has been accepted");
            break;
        }
        else
        {
            Console.WriteLine("Invalid Number");
        }
    }
} while (true);*/

//Code challenge 2
/*string? readResult;
bool waitForInput = true;
Console.WriteLine("Enter your role (Admin, Manager, or User)");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        string role = readResult.Trim().ToLower();
        switch (role)
        {
            case "admin":
            case "manager":
            case "user":
                Console.WriteLine("Your input of (" + role + ") has been accepted");
                waitForInput = false;
                break;
            default:
                Console.WriteLine("invalid entry");
                break;
        }
    }
    
} while (waitForInput);*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

//write the string above to console seperated by every period symbol
foreach (string str in myStrings)
{
    string remainingString = str;
    do
    {
        //check if there is a period symbol left
        int periodLocation = remainingString.IndexOf('.');

        //if no peroid left, print the remaining string
        if (periodLocation == -1)
        {
            Console.WriteLine(remainingString.TrimStart());
            break;
        }

        //get the string up to the period and print it
        string cutString = remainingString.Substring(0, periodLocation);
        remainingString = remainingString.Remove(0, periodLocation + 1);

        Console.WriteLine(cutString.TrimStart());

        if (remainingString.Length <= 0)
            break;

    } while (true);
}