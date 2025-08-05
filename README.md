# AuthManager CSharp (C#) Examples

This repository contains C# examples demonstrating how to use the AuthManager library for user authentication and license management.

## Project Structure

The project includes two main implementations:

- **Console**: A console application example
- **Forms**: A Windows Forms application example

## Features

- User registration and login
- License-based authentication
- Hardware ID (HWID) verification
- User input validation
- Secure authentication management

## Requirements

- .NET Framework
- Visual Studio or compatible C# development environment
- AuthManager library (CSharp-Library.dll)

## Setup Instructions

1. Clone or download this repository
2. Open the solution file (.sln) in your preferred IDE
3. Build the project
4. **Important**: Copy the `CSharp-Library.dll` file to the output directory alongside the compiled .exe file

## Configuration

Before running the application, you need to configure the following parameters in `Program.cs`:

```csharp
public static string app_name = "YOUR_APP_NAME_HERE";
public static string ownerid = "YOUR_OWNER_ID_HERE";
public static string app_secret = "YOUR_APP_SECRET_HERE";
```

Replace the placeholder values with your actual AuthManager credentials.

## Usage

### Forms Application

The Forms application provides a graphical user interface with the following features:

- **Login**: Authenticate using username and password
- **License Login**: Authenticate using a license key
- **Register**: Create a new user account with license verification
- **Main Form**: Access the main application after successful authentication
- **Logout**: Return to the login screen
- **Exit**: Close the application completely

### Console Application

The Console application provides a command-line interface for authentication operations.

## Important Notes

- Ensure the `CSharp-Library.dll` is present in the same directory as your compiled executable
- The application will not start if the AuthManager configuration is invalid
- All authentication operations require a valid internet connection
- Hardware ID is automatically generated and used for license verification

## Troubleshooting

- If the application closes unexpectedly, verify that the .dll file is in the correct location
- Check that your AuthManager credentials are correctly configured
- Ensure your application exists in the AuthManager system

## License

See the [LICENSE](LICENSE) file for more details.

## Contributing

Contributions are welcome! Feel free to open an issue or submit a pull request.

## Support

For any questions or issues, please create an issue on the repository.