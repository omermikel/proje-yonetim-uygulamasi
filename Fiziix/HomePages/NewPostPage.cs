using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiziix.Models;
using Newtonsoft.Json;

namespace Fiziix.HomePages
{
    public partial class NewPostPage : Form
    {
        string photo;
        byte[] photoImage;
        string base64Image = null;
        public NewPostPage()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(contentText.Text))
            {
                warning.Text = "*Please write something.";
                return;
            }

            var post = new
            {
                content = contentText.Text,
                userID = User.userID,
                postImage = base64Image,
            };

            
            string apiurl = $"https://localhost:44340/project/{Project.projectID}/newpost";
            using(HttpClient client = new HttpClient())
            {
                try
                {
                    string jsonPost = JsonConvert.SerializeObject(post);
                    StringContent content = new StringContent(jsonPost, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiurl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Post added successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to add post. Status Code: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Resim Seç";
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = openFileDialog.Filter = "Resim Dosyaları (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                photo = openFileDialog.FileName;
                imagepathText.Text = photo;

                if (!string.IsNullOrEmpty(photo))
                {
                    try
                    {
                        photoImage = File.ReadAllBytes(imagepathText.Text);
                        base64Image = Convert.ToBase64String(photoImage);

                        pictureBox1.Image= ImageConvert.Base64ToImage(base64Image);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Resim dosyasını okurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }
    }
}
