using C__Example;
using System;
using System.Windows.Forms;

public static class Program
{
    public static string app_name = "APP_NAME_HERE";
    public static string ownerid = "OWNER_ID_HERE";
    public static string app_secret = "APP_SECRET_HERE";

    [STAThread]
    public static void Main()
    {
        if (string.IsNullOrEmpty(app_name) || string.IsNullOrEmpty(ownerid) || string.IsNullOrEmpty(app_secret))
        {
            MessageBox.Show("Authentication failed. Please check your configuration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        AuthManagerWrapper.AuthManager_SetConfig(app_name, ownerid, app_secret);

        if (!AuthManagerWrapper.AuthManager_CheckAppExists(app_name, ownerid, app_secret))
        {
            MessageBox.Show("App does not exist. Exiting...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Login());
    }
}
