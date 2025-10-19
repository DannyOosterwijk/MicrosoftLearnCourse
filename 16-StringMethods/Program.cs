// modify the content of strings using build in string data type methods in C#

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

//Get quantity by getting the end of span and the length to /span
int spanLoc = input.IndexOf("<span>") + 6;
int spanEnd = input.IndexOf("</span>");
quantity = input.Substring(spanLoc, spanEnd - spanLoc);

//Get output by getting the end of div and length to /div
int divLoc = input.IndexOf("<div>") + 5;
int divEnd = input.IndexOf("</div>");
output = input.Substring(divLoc, divEnd - divLoc);

//Replace &trade with &reg
output = output.Replace("&trade", "&reg");

Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Output: " + output);