using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Fiziix
{
    public partial class RegisterPage1 : UserControl
    {
        public RegisterPage1()
        {
            InitializeComponent();
        }


        private void rSurnameText_TextChanged(object sender, EventArgs e)
        {

        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rUsernameText.Text) ||
                string.IsNullOrWhiteSpace(rPasswordText.Text) ||
                string.IsNullOrWhiteSpace(rPassword1Text.Text) ||
                string.IsNullOrWhiteSpace(rVerificationText.Text))
            {
                warning2.Text = "*Please fill in all fields!";
                verificationCode1.Text = GenerateVerificationCode.generateVerificationCode();
                warningUsername.Text = "";
                warningPassword.Text = "";
                warningVerification.Text = "";
                rVerificationText.Text = "";
                return;
            }

            if (rVerificationText.Text != verificationCode1.Text)
            {
                warningVerification.Text = "*Verification code is not correct!";
                warningUsername.Text = "";
                warningPassword.Text = "";
                warning2.Text = "";
                verificationCode1.Text = GenerateVerificationCode.generateVerificationCode();
                rVerificationText.Text = "";
                return;
            }

            if (rPassword1Text.Text != rPasswordText.Text)
            {
                warningPassword.Text = "*Passwords are not the same!";
                verificationCode1.Text = GenerateVerificationCode.generateVerificationCode();
                rVerificationText.Text = "";
                warning2.Text = "";
                warningUsername.Text = "";
                warningVerification.Text = "";
                return;
            }


            string username = rUsernameText.Text;
            string password = rPasswordText.Text;
            string password1 = rPassword1Text.Text;
            string verificationCode = rVerificationText.Text;

            string checkusername = $"https://localhost:44340/users/checkusername/{username}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(checkusername);

                if (!response.IsSuccessStatusCode)
                {
                    warningUsername.Text = "*This username is already in use.";
                    verificationCode1.Text = GenerateVerificationCode.generateVerificationCode();
                    warning2.Text = "";
                    warningPassword.Text = "";
                    warningVerification.Text = "";
                    rVerificationText.Text = "";
                    return;
                }

            }

            string registerurl = "https://localhost:44340/users/register";
            using(HttpClient client = new HttpClient())
            {
                var user = new
                {
                    Name = RegisterPage.name,
                    Lastname = RegisterPage.lastname,
                    Phone = RegisterPage.phone,
                    Email = RegisterPage.email,
                    Username = username,
                    Password = password,
                };

                var json = JsonConvert.SerializeObject(user);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(registerurl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sucsessful!", "Sucsesful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FiziixLogin parentForm = this.Parent as FiziixLogin;
                    if (parentForm != null)
                    {
                        parentForm.ShowLoginPage();
                    }
                }
                    
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            rUsernameText.Clear();
            rPasswordText.Clear();
            rPassword1Text.Clear();
            rVerificationText.Clear();
            warning2.Text = "";
            warningPassword.Text = "";
            warningUsername.Text = "";
            warningVerification.Text = "";

            FiziixLogin parentForm = this.Parent as FiziixLogin;
            if (parentForm != null)
            {
                parentForm.ShowRegisterPage();
            }
        }

        private void RegisterPage1_Load(object sender, EventArgs e)
        {
            verificationCode1.Text = GenerateVerificationCode.generateVerificationCode();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FiziixLogin parentForm = this.Parent as FiziixLogin;
            if (parentForm != null)
            {
                parentForm.minimizeLogin();

            }
        }
    }
}
