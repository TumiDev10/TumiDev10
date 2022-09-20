// See https://aka.ms/new-console-template for more information

/*
Suppose you need to quickly determine if a customer's purchase is eligible for a promotional discount.
If the amount of the sale is greater than 1000,
then discount the purchase by 100 dollars. If the amount is 1000 or less, only discount the sale by 50 dollars.
*/

int salesAmount = 1001;

int discount = salesAmount > 1000 ? 100 : 50;



//Heads or tails condition

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

/*
  business rules that restrict access to users based on their permissions and their level. 
  You'll display a different message to the user depending on their permissions and level. 
*/

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}