namespace C__Example
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool userExists = AuthManagerWrapper.AuthManager_CheckUserExists(username, password, Program.ownerid);
            if (userExists)
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Main mainForm = new Main();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLicenseLogin_Click(object sender, EventArgs e)
        {
            string license = txtLicense.Text;
            string hwid = AuthManagerWrapper.GetHWID();

            bool licenseIsValid = AuthManagerWrapper.AuthManager_CheckLicense(license, hwid, Program.ownerid);
            if (licenseIsValid)
            {
                MessageBox.Show("License Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Main mainForm = new Main();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid License.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string license = txtLicense.Text;

            if (!AuthManagerWrapper.AuthManager_ValidateInput(username, password))
            {
                MessageBox.Show("Invalid input. Please check your username and password and try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hwid = AuthManagerWrapper.GetHWID();
            bool registrationSuccess = AuthManagerWrapper.AuthManager_RegisterUser(username, password, license, hwid, Program.ownerid);

            MessageBox.Show(registrationSuccess ? "Registration Successful!" : "Error during registration.",
                registrationSuccess ? "Success" : "Error",
                MessageBoxButtons.OK,
                registrationSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
    }
}