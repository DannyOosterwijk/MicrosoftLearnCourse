// Perform operations on arrays using helper functions

string pangram = "The quick brown fox jumps over the lazy dog";
//split the sentence into words
string[] words = pangram.Split(" ");
for (int i = 0; i < words.Length; i++)
{
    //reverse each word
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);
    words[i] = new string(letters);
}

//combine all the words back into a sentence
string message = String.Join(" ", words);

Console.WriteLine(message);
Console.WriteLine("");


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

//split the oderstream into sepperate orders and sort alphabetically
string[] orders = orderStream.Split(",");
Array.Sort(orders);

foreach (string order in orders)
{
    //check if order has a total of 4 characters
    Console.Write(order);
    if(order.Length == 4)
    {
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("\t- Error");
    }
}