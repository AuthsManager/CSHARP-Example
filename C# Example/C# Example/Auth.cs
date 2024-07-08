using System;
using System.Threading.Tasks;

public static class Auth
{
    public static async Task Login()
    {
        Console.Write("Enter Username: ");
        var username = Console.ReadLine();

        Console.Write("Enter Password: ");
        var password = Console.ReadLine();

        var ownerId = Program.ownerid;

        var userExists = await Api.CheckUserExists(username, password, ownerId);
        Console.WriteLine(userExists ? "User exists." : "User doesn't exist.");

        if (userExists)
        {
            Console.WriteLine("\nyo (user)\n");
            // CODE HERE
        }
    }

    public static async Task License()
    {
        Console.Write("Enter License: ");
        var license = Console.ReadLine();

        var hwid = Utils.GetHWID();
        var ownerId = Program.ownerid;

        var licenseIsValid = await Api.CheckLicense(license, hwid, ownerId);
        Console.WriteLine(licenseIsValid ? "License is valid." : "License is invalid.");

        if (licenseIsValid)
        {
            Console.WriteLine("\nyo (license)\n");
            // CODE HERE
        }
    }

    public static async Task Register()
    {
        Console.Write("Enter Email: ");
        var email = Console.ReadLine();

        Console.Write("Enter Username: ");
        var username = Console.ReadLine();

        Console.Write("Enter Password: ");
        var password = Console.ReadLine();

        Console.Write("Enter License: ");
        var license = Console.ReadLine();

        if (!Utils.ValidateInput(email, username, password))
        {
            Console.WriteLine("Invalid input. Please check your email, username, and password and try again.\n");
            return;
        }

        var hwid = Utils.GetHWID();
        var ownerId = Program.ownerid;

        var registrationSuccess = await Api.RegisterUser(email, username, password, license, hwid, ownerId);

        if (registrationSuccess)
        {
            Console.WriteLine("\nRegistration successful.");
            // CODE HERE
        }
        else
        {
            Console.WriteLine("\nError during registration.");
        }
    }
}
