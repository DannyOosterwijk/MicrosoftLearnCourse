//Format alphanumeric data for presentation

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine("Dear " + customerName + ",");
Console.WriteLine("");
Console.WriteLine(String.Format("As a customer of our {0} offering we are excited to tell you about our financial product that would drastically increase your return", currentProduct));
Console.WriteLine(String.Format("Currently, you own {0:N} shares at a return of {1:P2}", currentShares, currentReturn));
Console.WriteLine(String.Format("Our new product, {0} offers a return of {1:P2}.  Given your current volume, your potential profit would be {2:C}", newProduct, newReturn, newProfit));
Console.WriteLine("");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage += currentProduct.PadRight(20) + String.Format("{0:P2}", currentReturn).PadRight(4) + String.Format("{0:C}", currentProfit).PadLeft(17) + "\n";
comparisonMessage += newProduct.PadRight(20) + String.Format("{0:P2}", newReturn).PadRight(4) + String.Format("{0:C}", newProfit).PadLeft(17) + "\n";

Console.WriteLine(comparisonMessage);