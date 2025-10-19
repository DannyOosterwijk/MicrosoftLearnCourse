// write your first method

string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] adress;

//loop over every ip and check if they are valid
foreach (string ip in ipv4Input)
{
    adress = ip.Split(".");
    if (ValidateLength() && ValidateZeroes() && ValidateRange())
    {
        Console.WriteLine($"ip {ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"ip {ip} is an invalid IPv4 address");
    }
}

//check if the ip contains 4 numbers
bool ValidateLength()
{
    return adress.Length == 4 ? true : false;
}
//check if the first digit of every number is not 0
bool ValidateZeroes()
{
    foreach (string number in adress)
    {
        if (number.Length > 0 && number[0] == '0') return true;
    }
    return false;
}
//check if all the numbers in the ip are within 0-255 range
bool ValidateRange()
{
    foreach (string number in adress)
    {
        int value = 0;
        if(int.TryParse(number, out value))
        {
            if (value >= 0 && value <= 255)
            {
                return true;
            }
        }
        return false;
    }
    return false;
}