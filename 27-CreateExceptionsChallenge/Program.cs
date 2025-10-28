//Create and throw exceptions Challenge

/*
    - All methods must be converted from static string methods to static void methods.
    - The Process1 method must throw exceptions for each type of issue encountered.
    - The Workflow1 method must catch and handle the FormatException exceptions.
    - The top-level statements must catch and handle the DivideByZeroException exceptions.
    - The Message property of the exception must be used to notify the user of the issue.
*/

string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
    Workflow1(userEnteredValues);

    Console.WriteLine("'Workflow1' completed successfully.");
    Console.WriteLine();
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error ocurred during 'Workflow1'.");
    Console.WriteLine(ex.Message);
    Console.WriteLine();
}

static void Workflow1(string[][] userEnteredValues)
{
    //go over every user array and process the data
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);

            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }
}

//check if the value of 4 can be divided by all the entries provided
static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        //try to parse the user entries
        try
        {
            checked
            {
                valueEntered = int.Parse(userValue);
            }
        }
        catch (FormatException ex)
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }

        //try to divide the 2 values
        try
        {
            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (DivideByZeroException ex)
        {
            throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
        }

    }
}