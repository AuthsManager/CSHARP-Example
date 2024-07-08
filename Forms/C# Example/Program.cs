using C__Example;
using System;
using System.Windows.Forms;

public static class Program
{
    public static string app_name = "APP_NAME_HERE";
    public static string ownerid = "OWNER_ID_HERE";
    public static string app_secret = "APP_SECRET_HERE";

    [STAThread]
    public static async Task Main()
    {
        if (!await Api.CheckAppExists(app_name, ownerid, app_secret))
        {
            MessageBox.Show("App does not exist. Exiting...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Login());
    }
}
