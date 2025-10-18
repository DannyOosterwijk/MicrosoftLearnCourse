/*
this code reverses a string and counts the amount of o's 
and then prints it to the console window
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(Message);

int LetterCount = 0;

foreach (char i in message) 
{ 
    if (i == 'o') 
    { 
        x++; 
    } 
}

string reversedMessage = new String(message);

Console.WriteLine(reversedMessage);
Console.WriteLine($"'o' appears {x} times.");