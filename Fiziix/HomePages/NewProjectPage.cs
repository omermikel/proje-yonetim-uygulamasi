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
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices.ComTypes;
using Fiziix.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.CodeDom;

namespace Fiziix.HomePages
{
    public partial class NewProjectPage : UserControl
    {
        private GenerateVerificationCode generateVerificationCode;
        string picture;
        byte[] imageBytes = null;
        public NewProjectPage()
        {
            InitializeComponent();
        }

        private void NewProjectPage_Load(object sender, EventArgs e)
        {
            connectionCode.Text = GenerateVerificationCode.generateVerificationCode();
        }

        private async void editProfileBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(projectNameText.Text))
            {
                warningNewProject.Text = "*Please enter a project name!";
                return;
            }

            string base64Image = null;
            if (!string.IsNullOrEmpty(picture))
            {
                try
                {
                    // Resmi byte dizisine dönüştür ve ardından Base64 stringine dönüştür
                    imageBytes = File.ReadAllBytes(picture);
                    base64Image = Convert.ToBase64String(imageBytes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Resim dosyasını okurken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string checkUrl = $"https://localhost:44340/projects/code/{connectionCode.Text}";
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(checkUrl);

                if (response.IsSuccessStatusCode)
                {
                    var countText = await response.Content.ReadAsStringAsync();
                    if (int.TryParse(countText, out int count))
                    {
                        if (count > 0)
                        {
                            warningNewProject.Text = "*Sorry, creating new connection code.";
                            connectionCode.Text = GenerateVerificationCode.generateVerificationCode();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Received invalid count value from the API.");
                    }
                }
                else
                {
                    MessageBox.Show($"Failed to check connection code. Status Code: {response.StatusCode}");
                }
            }

            string createUrl = "https://localhost:44340/projects/newproject";
            using (HttpClient client = new HttpClient())
            {
                var newproject = new
                {
                    projectName = projectNameText.Text,
                    projectDescription = projectDescriptionText.Text,
                    connectionCode = connectionCode.Text,
                    projectImage = string.IsNullOrEmpty(base64Image) ? null : base64Image,
                    createdBy = User.userID // Bu alanın Dto'da tanımlı olması gerekir.
                };

                try
                {
                    string jsonNewProject = JsonConvert.SerializeObject(newproject);
                    StringContent content = new StringContent(jsonNewProject, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(createUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Project created successfully!");
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Failed to create project. Status Code: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
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
                picture = openFileDialog.FileName;
                photoPathText.Text = picture;
            }
        }
    }
}
