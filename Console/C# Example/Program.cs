using System;
using System.Threading.Tasks;

public class Program
{
    public static string app_name = "APP_NAME_HERE";
    public static string ownerid = "OWNER_ID_HERE";
    public static string app_secret = "APP_SECRET_HERE";

    public static async Task Main(string[] args)
    {
        if (!await Api.CheckAppExists(app_name, ownerid, app_secret))
        {
            Console.WriteLine("App does not exist. Exiting...");
            return;
        }

        while (true)
        {
            Console.WriteLine("1. Login (Username, Password)");
            Console.WriteLine("2. Login (License)");
            Console.WriteLine("3. Register (Email, Username, Password, License)");
            Console.WriteLine("4. Exit\n");
            Console.Write("Choose an option: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    await Auth.Login();
                    break;
                case "2":
                    await Auth.License();
                    break;
                case "3":
                    await Auth.Register();
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
