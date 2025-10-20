//methods with parameters challenge

using System.ComponentModel.DataAnnotations;

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

//go over all internal employees and print their email
for (int i = 0; i < corporate.GetLength(0); i++)
{
    DisplayEmail(corporate[i, 0], corporate[i, 1]);
}

//go over all external employees and print their email
for (int i = 0; i < external.GetLength(0); i++)
{
    DisplayEmail(external[i, 0], external[i, 1], externalDomain);
}

//print the email adress of employee with first 2 letter of their name, their last name, and inputted domain
void DisplayEmail(string firstName, string lastName, string domain = "contoso.com")
{
    string name = (firstName.Substring(0, 2) + lastName).ToLower();
    Console.WriteLine(name + "@" + domain);
}