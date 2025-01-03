using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiziix.LoginPages
{
    public partial class IForgotMyPassword : UserControl
    {
        public IForgotMyPassword()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IForgotMyPassword_Load(object sender, EventArgs e)
        {
            verificationCode1.Text = GenerateVerificationCode.generateVerificationCode();
        }

        private async void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rVerificationText.Text) ||
                string.IsNullOrWhiteSpace(rPhoneText.Text) ||
                string.IsNullOrWhiteSpace(rUsernameText.Text))
            {
                warning3.Text = "*Please fill in all fields!";
                warningPassword.Text = "";
                warningUsername.Text = "";
                warningVerification.Text = "";
                verificationCode1.Text = GenerateVerificationCode.generateVerificationCode();
                rVerificationText.Clear();
                rUsernameText.Clear();
                rPhoneText.Clear();
                return;
            }

            if (rVerificationText.Text != verificationCode1.Text)
            {
                warning3.Text = "";
                warningPassword.Text = "";
                warningUsername.Text = "";
                warningVerification.Text = "*Verification code is not correct!";
                verificationCode1.Text = GenerateVerificationCode.generateVerificationCode();
                rVerificationText.Clear();
                rUsernameText.Clear();
                rPhoneText.Clear();
                return;
            }

            string username = rUsernameText.Text;
            string phone = rPhoneText.Text;

            var forgot = new
            {
                Username = username,
                Phone = phone,
            };
            string forgoturl = "https://localhost:44340/users/forgotpassword";
            using (HttpClient client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(forgot);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(forgoturl, content);

                if (response.IsSuccessStatusCode) {
                    var password = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Password  ->  " + password, "Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rVerificationText.Clear();
                    rUsernameText.Clear();
                    rPhoneText.Clear();
                    warningPassword.Text = "";
                    warningUsername.Text = "";
                    warningVerification.Text = "";
                    FiziixLogin parentForm = this.Parent as FiziixLogin;
                    if (parentForm != null)
                    {
                        parentForm.ShowLoginPage();
                    }
                }
                else 
                { 
                    warning3.Text = "Someting is going wrong.";
                    verificationCode1.Text = GenerateVerificationCode.generateVerificationCode();
                    rVerificationText.Clear();
                    rUsernameText.Clear();
                    rPhoneText.Clear();
                    warningPassword.Text = "";
                    warningUsername.Text = "";
                    warningVerification.Text = "";

                }
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {
            FiziixLogin parentForm = this.Parent as FiziixLogin;
            if (parentForm != null)
            {
                parentForm.minimizeLogin();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            rVerificationText.Clear();
            rUsernameText.Clear();
            rPhoneText.Clear();
            warning3.Text = "";
            warningPassword.Text = "";
            warningUsername.Text = "";
            warningVerification.Text = "";

            // Örneğin, bu label'a tıklayarak tekrar Login sayfasına dönebilirsiniz
            FiziixLogin parentForm = this.Parent as FiziixLogin;
            if (parentForm != null)
            {
                parentForm.ShowLoginPage();
            }

        }
    }
}
