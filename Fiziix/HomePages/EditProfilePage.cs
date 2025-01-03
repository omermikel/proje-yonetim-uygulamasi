using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using Fiziix.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace Fiziix.HomePages
{

    public partial class EditProfilePage : UserControl
    {
        string photo;
        byte[] photoImage = null;
        string base64Image = null;
        public event Action<string> PhotoChange;


        public EditProfilePage()
        {
            InitializeComponent();   

        }
       
        public void cleartexts()
        {
            oldpasswordText.Clear();
            newPasswordText.Clear();
            newPassword1Text.Clear();
            verificationText.Clear();
            verificationCode.Text = GenerateVerificationCode.generateVerificationCode();
        }
        private void EditProfilePage_Load(object sender, EventArgs e)
        {
            nameText.Text = User.name;
            lastnameText.Text = User.lastname;
            phoneText.Text = User.phone;
            emailText.Text = User.email;
            usernameText.Text = User.username;
            verificationCode.Text = GenerateVerificationCode.generateVerificationCode();
            if (!string.IsNullOrEmpty(User.userPhoto))
            {
                // Base64 string'i resme dönüştür ve PictureBox'a ata
                pictureBox1.Image = ImageConvert.Base64ToImage(User.userPhoto);
                
            }
            else
            {
                pictureBox1.Image = null;
            }
        }

        private async void editProfileBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameText.Text) ||
                string.IsNullOrWhiteSpace(lastnameText.Text) ||
                string.IsNullOrWhiteSpace(emailText.Text) ||
                string.IsNullOrWhiteSpace(usernameText.Text) ||
                string.IsNullOrWhiteSpace(phoneText.Text))
            {
                warningEditProfile.Text = "*Please fill in all fields!";
                return;
            }

            string name = nameText.Text;
            string lastname = lastnameText.Text;
            string email = emailText.Text;
            string username = usernameText.Text;
            string phone = phoneText.Text;

            var updated = new UptadeProfileDto
            {
                Userid = User.userID,
                Name = name,
                Lastname = lastname,
                Phone = phone,
                Email = email,
                Username = username,
                
            };

            string updateurl = "https://localhost:44340/users/updateprofile";
            using (HttpClient client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(updated);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(updateurl, content);

                if (response.IsSuccessStatusCode)
                    warningEditProfile.Text = "Profile has been updated!";
                else
                    warningEditProfile.Text = "Something is going wrong!";
            }
        }


        private async void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(oldpasswordText.Text) ||
               string.IsNullOrWhiteSpace(newPasswordText.Text) ||
               string.IsNullOrWhiteSpace(newPassword1Text.Text) ||
               string.IsNullOrWhiteSpace(verificationText.Text))
            {
                warningPassword.Text = "*Please fiil in all fields!";
                cleartexts();
                return;
            }
            else if (!verificationCode.Text.Trim().Equals(verificationText.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                warningPassword.Text = "*Verification code is wrong!";
                cleartexts();
                return;
            }
            else if(newPasswordText.Text != newPassword1Text.Text)
            {
                warningPassword.Text = "*New passwords are not the same!";
                cleartexts();
                return;
            }
            else if(oldpasswordText.Text != User.password)
            {
                warningPassword.Text = "Old password is not correct!";
                cleartexts();
                return;
            }
            else if(oldpasswordText.Text == newPasswordText.Text)
            {
                warningPassword.Text = "*Old password and new password cannot be the same!";
                cleartexts();
                return;
            }

            string password = newPassword1Text.Text;

            var changepassword = new
            {
                Userid = User.userID,
                Password = password,
            };
            string passwordurl = $"https://localhost:44340/users/changepassword";
            using(HttpClient client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(changepassword);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(passwordurl, content);

                if (response.IsSuccessStatusCode)
                    warningPassword.Text = "Password changed!";
                else
                    warningPassword.Text =" Something is going wrong!";
            }

        }

        private void uploadPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Resim Seç";
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = openFileDialog.Filter = "Resim Dosyaları (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                photo = openFileDialog.FileName;
                photoPathText.Text = photo;
            }
            
        }

        private async void changePhotoBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(photoPathText.Text))
            {
                warningPhoto.Text = "Please choose a photo.";
                return;
            }
            if (!string.IsNullOrEmpty(photo))
            {
                try
                {
                    // Resmi byte dizisine dönüştür ve ardından Base64 stringine dönüştür
                    photoImage = File.ReadAllBytes(photoPathText.Text);
                    base64Image = Convert.ToBase64String(photoImage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Resim dosyasını okurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            var photoapi = new
            {
                Userid = User.userID,
                UserPhoto = base64Image
            };
            string changephotourl = $"https://localhost:44340/users/changephoto";
            using (HttpClient client =new HttpClient())
            {
                var json = JsonConvert.SerializeObject(photoapi);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(changephotourl, content);

                if (response.IsSuccessStatusCode)
                    warningPhoto.Text = "Photo has changed!";
                else
                    warningPhoto.Text = "Something is going wrong.";
            }
            pictureBox1.Image = ImageConvert.Base64ToImage(base64Image);
            // Home formundaki PictureBox'ı güncelle
            PhotoChange?.Invoke(base64Image);
            photoPathText.Clear();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure about delete photo?",
                                             "Sure?",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                var photoapi = new
                {
                    Userid = User.userID,
                    UserPhoto = DBNull.Value,
                };
                string changephotourl = $"https://localhost:44340/users/changephoto";
                using (HttpClient client = new HttpClient())
                {
                    var json = JsonConvert.SerializeObject(photoapi);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PutAsync(changephotourl, content);

                    if (response.IsSuccessStatusCode)
                        warningPhoto.Text = "Photo has cleaned!";
                    else
                        warningPhoto.Text = "Something is going wrong.";
                }

                pictureBox1.Image = null;
                photoPathText.Clear();
            }
            
        }
    }
}
