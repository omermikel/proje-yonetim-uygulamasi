using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.Json;
using Fiziix.Models;


namespace Fiziix
{
    public partial class LoginPage : UserControl
    {
        private readonly HttpClient _httpClient;
       
        public LoginPage()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var username = usernameText.Text;
            var password = passwordText.Text;

            var loginDto = new LoginDto
            {
                username = username,
                password = password
            };

            var json = JsonConvert.SerializeObject(loginDto);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _httpClient.PostAsync("https://localhost:44340/login", content);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON response into an object
                    var userDto = JsonConvert.DeserializeObject<dynamic>(result);

                    // Assign the values to the User class properties
                    User.userID = userDto.userID;
                    User.name = userDto.name;
                    User.lastname = userDto.lastname;
                    User.phone = userDto.phone;
                    User.email = userDto.email;
                    User.username = userDto.username;
                    User.password = userDto.password;
                    User.userPhoto = userDto.userPhoto;

                    usernameText.Clear();
                    passwordText.Clear();
                    FiziixLogin parentForm = this.Parent as FiziixLogin;
                    if (parentForm != null)
                    {
                        parentForm.openHome();
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Invalid username or password.");
                }
                else
                {
                    MessageBox.Show("An error occurred: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception occurred: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            // Ana formu al ve RegisterPage'i göster.
            FiziixLogin parentForm = this.Parent as FiziixLogin;
            if (parentForm != null)
            {
                parentForm.ShowRegisterPage();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FiziixLogin parentForm = this.Parent as FiziixLogin;
            if (parentForm != null)
            {
                parentForm.ShowIForgotMyPasword();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FiziixLogin parentForm = this.Parent as FiziixLogin;
            if (parentForm != null)
            {
                parentForm.minimizeLogin();

            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FiziixLogin parentForm = this.Parent as FiziixLogin;
            if (parentForm != null)
            {
                parentForm.minimizeLogin();

            }
        }
    }
}
