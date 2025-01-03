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
using System.Web;
using System.Windows.Forms;

namespace Fiziix
{
    public partial class RegisterPage : UserControl
    {
        public static string name;
        public static string lastname;
        public static string phone;
        public static string email;

        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void label5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rNameText.Text) ||
                string.IsNullOrWhiteSpace(rSurnameText.Text) ||
                string.IsNullOrWhiteSpace(rPhoneText.Text) ||
                string.IsNullOrWhiteSpace(rEmailText.Text))
            {
                warning1.Text = "*Please fill in all fields!";
                warningEmail.Text = "";
                warningPhone.Text = "";
                return;
            }

            // Kullanıcı bilgilerinin alınması
            name = rNameText.Text;
            lastname = rSurnameText.Text;
            phone = rPhoneText.Text;
            email = rEmailText.Text;

            string checkphone = $"https://localhost:44340/users/checkphone/{phone}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(checkphone);

                if (!response.IsSuccessStatusCode)
                {
                    warningPhone.Text = "*This phone number is already in use.";
                    warning1.Text = "";
                    warningEmail.Text = "";
                    return;
                }
                else
                {
                    warning1.Text = "";
                    warningPhone.Text = "";
                }
            }

            string checkmail = $"https://localhost:44340/users/checkmail/{email}";
            using (HttpClient client = new HttpClient()) 
            {
                HttpResponseMessage response = await client.GetAsync(checkmail);
                if (!response.IsSuccessStatusCode)
                {
                    warningEmail.Text = "*This email address is already in use.";
                    warning1.Text = "";
                    warningPhone.Text = "";
                    return;
                }
                else
                {
                    warning1.Text = "";
                    warningEmail.Text = "";
                }
            }
           
            rNameText.Clear();
            rSurnameText.Clear();
            rPhoneText.Clear();
            rEmailText.Clear();
            warningEmail.Text = "";
            warning1.Text = "";
            warningPhone.Text = "";


            FiziixLogin parentForm = this.Parent as FiziixLogin;
            if (parentForm != null)
            {
                parentForm.ShowRegister1Page();
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            rNameText.Clear();
            rSurnameText.Clear();
            rPhoneText.Clear();
            rEmailText.Clear();
            warningEmail.Text = "";
            warning1.Text = "";
            warningPhone.Text = "";

            // Örneğin, bu label'a tıklayarak tekrar Login sayfasına dönebilirsiniz
            FiziixLogin parentForm = this.Parent as FiziixLogin;
            if (parentForm != null)
            {
                parentForm.ShowLoginPage();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FiziixLogin parentForm = this.Parent as FiziixLogin;
            if (parentForm != null)
            {
                parentForm.minimizeLogin();

            }
        }
    }
}
