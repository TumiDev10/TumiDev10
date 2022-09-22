// See https://aka.ms/new-console-template for more information

/*
A hero and a monster start with the same health score. During the hero's turn, 
they'll generate a random value that will be subtracted from the monster's health. 
If the monster's health is greater than zero, they'll take their turn and attack the hero. 
As long as both the hero and the monster have health greater than zero, the battle will resume.
*/

Random dice = new Random();
int hero = 10;
int monsta = 10;

do
{
    int roll = dice.Next(1, 11);
    monsta -= roll;
    Console.WriteLine($"Monsta was damaged and lost {roll} health and now has {monsta} health");

    if (monsta <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health");

} while (hero > 0 && monsta > 0);
Console.WriteLine(hero > monsta ? "hero wins!" : "Monsta wins!");
