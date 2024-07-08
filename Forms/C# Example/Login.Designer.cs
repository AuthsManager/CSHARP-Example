using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Example
{
    public partial class Login : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtLicense;
        private TextBox txtEmail;
        private Button btnLogin;
        private Button btnLicenseLogin;
        private Button btnRegister;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblLicense;
        private Label lblEmail;

        private void InitializeComponent()
        {
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.lblLicense = new Label();
            this.txtLicense = new TextBox();
            this.btnLicenseLogin = new Button();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.btnRegister = new Button();

            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new Point(50, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new Size(55, 13);
            this.lblUsername.Text = "Username";

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new Point(150, 50);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new Size(200, 20);

            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new Point(50, 100);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new Size(53, 13);
            this.lblPassword.Text = "Password";

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new Point(150, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new Size(200, 20);
            this.txtPassword.PasswordChar = '*';

            // 
            // btnLogin
            // 
            this.btnLogin.Location = new Point(150, 150);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new Size(200, 30);
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new EventHandler(this.BtnLogin_Click);

            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new Point(50, 200);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new Size(45, 13);
            this.lblLicense.Text = "License";

            // 
            // txtLicense
            // 
            this.txtLicense.Location = new Point(150, 200);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new Size(200, 20);

            // 
            // btnLicenseLogin
            // 
            this.btnLicenseLogin.Location = new Point(150, 250);
            this.btnLicenseLogin.Name = "btnLicenseLogin";
            this.btnLicenseLogin.Size = new Size(200, 30);
            this.btnLicenseLogin.Text = "Login with License";
            this.btnLicenseLogin.UseVisualStyleBackColor = true;
            this.btnLicenseLogin.Click += new EventHandler(this.BtnLicenseLogin_Click);

            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new Point(50, 300);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new Size(32, 13);
            this.lblEmail.Text = "Email";

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(150, 300);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(200, 20);

            // 
            // btnRegister
            // 
            this.btnRegister.Location = new Point(150, 350);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new Size(200, 30);
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new EventHandler(this.BtnRegister_Click);

            // 
            // LoginForm
            // 
            this.ClientSize = new Size(400, 450);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.btnLicenseLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnRegister);
            this.Name = "LoginForm";
            this.Text = "Login Form";
        }
    }
}
