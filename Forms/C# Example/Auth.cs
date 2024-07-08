using System.Threading.Tasks;

public static class Auth
{
    public static async Task<bool> Login(string username, string password)
    {
        string ownerId = Program.ownerid;
        return await Api.CheckUserExists(username, password, ownerId);
    }

    public static async Task<bool> License(string license, string hwid)
    {
        string ownerId = Program.ownerid;
        return await Api.CheckLicense(license, hwid, ownerId);
    }

    public static async Task<bool> Register(string email, string username, string password, string license, string hwid)
    {
        string ownerId = Program.ownerid;
        return await Api.RegisterUser(email, username, password, license, hwid, ownerId);
    }
}
