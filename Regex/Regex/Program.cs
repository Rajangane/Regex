// See https://aka.ms/new-console-template for more information
//Console.WriteLine("*************** Welcome To Regex **********************");
using RegexPatternMatching;
Console.Write("Select Number:\n1)FirstName\n2)LastName");
int option = Convert.ToInt32(Console.ReadLine());
Patterns pattern = new Patterns();

switch (option)
{
    case 1:
        Console.Write("Enter FirstName: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("FirstName:" + pattern.ValidateFirstName(firstName));
        break;
    case 2:
        Console.Write("Enter LastName: ");
        string lasttName = Console.ReadLine();
        Console.WriteLine("FirstName:" + pattern.ValidateLastName(lasttName));
        break;


    default:
        Console.WriteLine("Invalid Option");
        break;
}
