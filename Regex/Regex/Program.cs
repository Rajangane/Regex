// See https://aka.ms/new-console-template for more information
//Console.WriteLine("*************** Welcome To Regex **********************");
using RegexPatternMatching;
Console.Write("Select Number:\n1)FirstName");
int option = Convert.ToInt32(Console.ReadLine());
Patterns pattern = new Patterns();

switch (option)
{
    case 1:
        Console.Write("Enter FirstName: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("FirstName:" + pattern.ValidateFirstName(firstName));
        break;

    default:
        Console.WriteLine("Invalid Option");
        break;
}
