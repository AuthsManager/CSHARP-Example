using System.Management;
using System.Text.RegularExpressions;

public static class Utils
{
    public static bool ValidateInput(string email, string username, string password)
    {
        var usernameRegex = new Regex("^[a-zA-Z][a-zA-Z0-9_-]{2,15}$");
        var emailRegex = new Regex("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$");
        var passwordRegex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$");

        if (!usernameRegex.IsMatch(username))
        {
            Console.WriteLine("\nInvalid username. It must be 3-16 characters long, start with a letter, and can contain letters, numbers, underscores, and hyphens.");
            return false;
        }

        if (!emailRegex.IsMatch(email))
        {
            Console.WriteLine("\nInvalid email format.");
            return false;
        }

        if (!passwordRegex.IsMatch(password))
        {
            Console.WriteLine("\nInvalid password. It must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, one number, and one special character.");
            return false;
        }

        return true;
    }

    public static string GetHWID()
    {
        string hwid = string.Empty;
        using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard"))
        {
            foreach (var wmiObject in searcher.Get())
            {
                hwid = wmiObject["SerialNumber"].ToString();
                break;
            }
        }
        return hwid;
    }
}
