//do while loops

int playerHealth = 10;
int monsterHealth = 10;
Random random = new Random();

do
{
    int damage = random.Next(1, 11);
    monsterHealth = Math.Clamp(monsterHealth - damage, 0, 10);
    Console.WriteLine("Monster was damaged and lost " + damage + " health and now has " + monsterHealth + " health");

    if (monsterHealth <= 0)
    {
        Console.WriteLine("Hero Wins!!!");
        break;
    }

    damage = random.Next(1, 11);
    playerHealth = Math.Clamp(playerHealth - damage, 0 , 10);
    Console.WriteLine("Hero was damaged and lost " + damage + " health and now has " + playerHealth + " health");

    if (playerHealth <= 0)
    {
        Console.WriteLine("Hero Losses!!!");
        break;
    }

} while (true);