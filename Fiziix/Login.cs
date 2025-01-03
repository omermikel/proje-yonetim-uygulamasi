using Fiziix.LoginPages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiziix
{
    public partial class FiziixLogin : Form
    {
        public FiziixLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        { 
            ıForgotMyPassword1.Hide();
            registerPage1.Hide();
            registerPage11.Hide();
            loginPage1.Show();
            
        }

        
        public void ShowRegisterPage()
        {
            ıForgotMyPassword1.Hide();
            loginPage1.Hide();
            registerPage11.Hide();
            registerPage1.Show();
            
        }
        public void ShowRegister1Page()
        {
            ıForgotMyPassword1.Hide();
            loginPage1.Hide();
            registerPage1.Hide();
            registerPage11.Show();

        }

        public void ShowLoginPage()
        {
            ıForgotMyPassword1.Hide();
            registerPage1.Hide();
            registerPage11.Hide();
            loginPage1.Show();
        }
        public void ShowIForgotMyPasword()
        {
            registerPage1.Hide();
            registerPage11.Hide();
            loginPage1.Hide();
            ıForgotMyPassword1.Show();
        }
        public void minimizeLogin()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void openHome()
        {
            Home home = new Home();
            home.StartPosition = FormStartPosition.CenterParent;
            home.Show();
            this.Hide();
            home.FormClosed += (s, args) =>
            {
                this.Show();
                
                

            };
        }
    }
}
