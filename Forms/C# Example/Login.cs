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

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool userExists = await Auth.Login(username, password);
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

        private async void BtnLicenseLogin_Click(object sender, EventArgs e)
        {
            string license = txtLicense.Text;
            string hwid = Utils.GetHWID();

            bool licenseIsValid = await Auth.License(license, hwid);
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

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string license = txtLicense.Text;

            if (!Utils.ValidateInput(email, username, password))
            {
                MessageBox.Show("Invalid input. Please check your email, username, and password and try again.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hwid = Utils.GetHWID();
            bool registrationSuccess = await Auth.Register(email, username, password, license, hwid);

            MessageBox.Show(registrationSuccess ? "Registration Successful!" : "Error during registration.",
                registrationSuccess ? "Success" : "Error",
                MessageBoxButtons.OK,
                registrationSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
    }
}