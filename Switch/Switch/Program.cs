// See https://aka.ms/new-console-template for more information
int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

/*
 The switch keyword defines the purpose of the code block below. Next to the keyword, 
the match expression in parenthesis (employeeLevel).

Inside the code block, there are one or more switch sections. Each switch section has one or more labels. 
A label begins with the keyword case and a matching pattern. 
The runtime compares the value of the match expression with each matching pattern until it finds a match.

Once the runtime finds a matching label, it performs the code in that particular switch section.
*/







