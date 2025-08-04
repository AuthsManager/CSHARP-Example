using System;

public class Program
{
    public static string app_name = "APP_NAME_HERE";
    public static string ownerid = "OWNER_ID_HERE";
    public static string app_secret = "APP_SECRET_HERE";

    public static void Main(string[] args)
    {
        Console.WriteLine("=== Authentication System ===");
        Console.WriteLine("Powered by AuthManager");
        if (string.IsNullOrEmpty(app_name) || string.IsNullOrEmpty(ownerid) || string.IsNullOrEmpty(app_secret))
        {
            Console.WriteLine("Authentication failed. Please check your configuration.");
            return;
        }

        AuthManagerWrapper.AuthManager_SetConfig(app_name, ownerid, app_secret);

        if (!AuthManagerWrapper.AuthManager_CheckAppExists(app_name, ownerid, app_secret))
        {
            Console.WriteLine("App does not exist. Exiting...");
            return;
        }

        while (true)
        {
            Console.WriteLine("1. Login (Username, Password)");
            Console.WriteLine("2. Login (License)");
            Console.WriteLine("3. Register (Username, Password, License)");
            Console.WriteLine("4. Exit\n");
            Console.Write("Choose an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    if (AuthManagerWrapper.AuthManager_LoginInterface())
                    {
                        Console.WriteLine("Login successful!");
                        // TODO: Add your custom code here after successful login
                    }
                    else
                    {
                        Console.WriteLine("Login failed.");
                    }
                    break;
                case "2":
                    if (AuthManagerWrapper.AuthManager_LicenseInterface())
                    {
                        Console.WriteLine("License validation successful!");
                        // TODO: Add your custom code here after successful license validation
                    }
                    else
                    {
                        Console.WriteLine("License validation failed.");
                    }
                    break;
                case "3":
                    if (AuthManagerWrapper.AuthManager_RegisterInterface())
                    {
                        Console.WriteLine("Registration completed successfully!");
                        // TODO: Add your custom code here after successful registration
                    }
                    else
                    {
                        Console.WriteLine("Registration failed.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Exiting ...");
                    return;
                default:
                    Console.WriteLine("\nInvalid option. Please try again.");
                    break;
            }
        }
    }
}
