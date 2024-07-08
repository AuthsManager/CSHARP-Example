using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public static class Api
{
    public static async Task<bool> CheckAppExists(string name, string ownerId, string secret)
    {
        using (var client = new HttpClient())
        {
            var requestUri = "http://localhost:8080/auth/initiate";

            var requestData = new
            {
                name = name,
                ownerId = ownerId,
                secret = secret
            };

            var json = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(requestUri, content);

            var responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Status Code (App): " + response.StatusCode);
            Console.WriteLine("Response Body (App): " + responseBody + "\n");

            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    }

    public static async Task<bool> CheckUserExists(string username, string password, string ownerId)
    {
        using (var client = new HttpClient())
        {
            var requestUri = "http://localhost:8080/auth/login";

            var requestData = new
            {
                username = username,
                password = password,
                ownerId = ownerId
            };

            var json = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(requestUri, content);

            var responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine("\nStatus Code (User): " + response.StatusCode);
            Console.WriteLine("Response Body (User): " + responseBody + "\n");

            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    }

    public static async Task<bool> RegisterUser(string email, string username, string password, string license, string hwid, string ownerId)
    {
        using (var client = new HttpClient())
        {
            var registerUri = "http://localhost:8080/auth/register";

            var registerData = new
            {
                email = email,
                username = username,
                password = password,
                license = license,
                hwid = hwid,
                ownerId = ownerId
            };

            var registerJson = JsonConvert.SerializeObject(registerData);
            var registerContent = new StringContent(registerJson, Encoding.UTF8, "application/json");

            var registerResponse = await client.PostAsync(registerUri, registerContent);

            var registerResponseBody = await registerResponse.Content.ReadAsStringAsync();
            Console.WriteLine("\nStatus Code (Register): " + registerResponse.StatusCode);
            Console.WriteLine("Response Body (Register): " + registerResponseBody + "\n");

            return registerResponse.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    }

    public static async Task<bool> CheckLicense(string license, string hwid, string ownerId)
    {
        using (var client = new HttpClient())
        {
            var loginUri = "http://localhost:8080/auth/login";

            var loginData = new
            {
                license = license,
                hwid = hwid,
                ownerId = ownerId
            };

            var loginJson = JsonConvert.SerializeObject(loginData);
            var loginContent = new StringContent(loginJson, Encoding.UTF8, "application/json");

            var loginResponse = await client.PostAsync(loginUri, loginContent);

            var loginResponseBody = await loginResponse.Content.ReadAsStringAsync();
            Console.WriteLine("\nStatus Code (Login): " + loginResponse.StatusCode);
            Console.WriteLine("Response Body (Login): " + loginResponseBody + "\n");

            return loginResponse.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    }
}
