// See https://aka.ms/new-console-template for more information
//Console.WriteLine("*************** Welcome To Regex **********************");
using RegexPatternMatching;
Console.Write("Select Number:\n1)FirstName\n2)LastName\n3)Email\n4)PhoneNumber");
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
        Console.WriteLine("LastName:" + pattern.ValidateLastName(lasttName));
        break;
    case 3:
        Console.Write("Enter Email: ");
        string email = Console.ReadLine();
        Console.WriteLine("Email:" + pattern.ValidateEmail(email));
        break;
    case 4:
        Console.Write("Enter Phone Number: ");
        string phoneno = Console.ReadLine();
        Console.WriteLine("PhoneNumber:" + pattern.ValidatePhoneNo(phoneno));
        break;



    default:
        Console.WriteLine("Invalid Option");
        break;
}
