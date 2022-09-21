// See https://aka.ms/new-console-template for more information

/*
FizzBuzz rules:

Output values from 1 to 100, one number per line.
When the current value is divisible by 3, print the term Fizz next to the number.
When the current value is divisible by 5, print the term Buzz next to the number.
When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number
*/


for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"{i}.FizzBizz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i}.Fizz");
    }

    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i}.Bizz");
    }
    else
    {
        Console.WriteLine(i);
    }


}