using Fiziix.HomePages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using Fiziix.Models;
namespace Fiziix
{
    public partial class Home : Form
    {
        
        private readonly ImageConvert Image;
        
        public Home()
        {
            InitializeComponent();
            this.panelTop.MouseDown += new MouseEventHandler(PanelTop_MouseDown);
            EditProfilePage editProfilePage = new EditProfilePage();
            editProfilePage.PhotoChange += EditProfilePage_PhotoChange;

        }
        private void EditProfilePage_PhotoChange(string base64Image)
        {
            // Home formundaki PictureBox'ı güncelle
            pictureBox1.Image = ImageConvert.Base64ToImage(User.userPhoto);
        }

        // WinAPI kullanarak pencereyi taşıma işlemi
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern bool SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            myTasksPage1.Hide();
            postsPage1.Hide();
            projectMainPage1.Hide();
            joinProject1.Hide();
            editProfilePage1.Hide();
            newProjectPage1.Hide();
            homePage1.refresh();
            homePage1.Show();


            username.Text = User.username;
            cubuk.Location = new Point(0, 111);

            if (!string.IsNullOrEmpty(User.userPhoto))
            {
                // Base64 string'i resme dönüştür ve PictureBox'a ata
                Image photo = ImageConvert.Base64ToImage(User.userPhoto);
                pictureBox1.Image = photo;
            }
            else
            {
                pictureBox1.Image = null;
            }
                
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void projects_Click(object sender, EventArgs e)
        {
            showProjects();

            cubuk.Location = new Point(0, 192);
        }

        private void mtTasks_Click(object sender, EventArgs e)
        {
            myTasksPage1.refresh();
            showMyTask();
            cubuk.Location = new Point(0, 273);
        }

        private void posts_Click(object sender, EventArgs e)
        {
            postsPage1.refresh(0);
            showPosts();
            cubuk.Location = new Point(0, 354);
        }

        private void newProject_Click(object sender, EventArgs e)
        {
            showNewProject();
            cubuk.Location = new Point(0, 435);   
        }

        private void label8_Click(object sender, EventArgs e)
        {
            cubuk.Location = new Point(0, 516);
            showJoinProject();   
        }

        private void editProfile_Click(object sender, EventArgs e)
        {
            showEditProfile();
            cubuk.Location = new Point(0, 597);
        }

        private void homee_Click(object sender, EventArgs e)
        {
            showHome();
            cubuk.Location = new Point(0, 111);

        }
        public void changePicture()
        {
            pictureBox1.Image = ImageConvert.Base64ToImage(User.userPhoto);
        }
        public void showHome()
        {
            myTasksPage1.Hide();
            postsPage1.Hide();
            projectsPage1.Hide();
            joinProject1.Hide();
            editProfilePage1.Hide();
            newProjectPage1.Hide();
            projectMainPage1.Hide();
            homePage1.refresh();
            homePage1.Show();   
        }

        public void showEditProfile()
        {
            myTasksPage1.Hide();
            postsPage1.Hide();
            projectsPage1.Hide();
            joinProject1.Hide();
            homePage1.Hide();
            newProjectPage1.Hide();
            projectMainPage1.Hide();
            editProfilePage1.Show();
        }
        public void showNewProject()
        {
            myTasksPage1.Hide();
            postsPage1.Hide();
            projectsPage1.Hide();
            joinProject1.Hide();
            homePage1.Hide();
            editProfilePage1.Hide();
            projectMainPage1.Hide();
            newProjectPage1.Show();
        }
        public void showJoinProject()
        {
            myTasksPage1.Hide();
            postsPage1.Hide();
            projectsPage1.Hide();
            homePage1.Hide();
            newProjectPage1.Hide();
            editProfilePage1.Hide();
            projectMainPage1.Hide();
            joinProject1.Show();
        }
        public void showProjects()
        {
            myTasksPage1.Hide();
            postsPage1.Hide();
            homePage1.Hide();
            newProjectPage1.Hide();
            editProfilePage1.Hide();
            joinProject1.Hide();
            projectMainPage1.Hide();
            projectsPage1.refresh() ;
            projectsPage1.Show();
        }

        public void showProject()
        {
            myTasksPage1.Hide();
            postsPage1.Hide();
            homePage1.Hide();
            newProjectPage1.Hide();
            editProfilePage1.Hide();
            joinProject1.Hide();
            projectsPage1.Hide();
            projectMainPage1.refresh();
            projectMainPage1.Show();
        }
        public void showPosts()
        {
            myTasksPage1.Hide();
            homePage1.Hide();
            newProjectPage1.Hide();
            editProfilePage1.Hide();
            joinProject1.Hide();
            projectsPage1.Hide();
            projectMainPage1.Hide();
            postsPage1.Show();
        }
        public void showMyTask()
        {
            homePage1.Hide();
            newProjectPage1.Hide();
            editProfilePage1.Hide();
            joinProject1.Hide();
            projectsPage1.Hide();
            projectMainPage1.Hide();
            postsPage1.Hide();
            myTasksPage1.Show();
        }
        
    }
}
