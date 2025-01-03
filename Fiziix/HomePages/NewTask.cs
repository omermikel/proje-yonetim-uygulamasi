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
using Fiziix.Models;
using Newtonsoft.Json;


namespace Fiziix.HomePages
{
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }

        private  void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 ||
                string.IsNullOrWhiteSpace(tasknameText.Text) ||
                string.IsNullOrWhiteSpace(taskdescriptionText.Text)) 
            {
                warning.Text = "*Please fiil all field!";
                return;
            }

            string apiUrl = $"https://localhost:44340/project/{Project.projectID}/newtask";

            var task = new
            {
                TaskName = tasknameText.Text, // Formdan alınan veri
                TaskDescription = taskdescriptionText.Text, // Formdan alınan veri
                AssignedTo = comboBox1.Text, // Formdan alınan veri
                CreatedBy = User.userID, // Formdan alınan veri
                DueDate = monthCalendar1.SelectionStart // Formdan alınan veri
            };

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string jsonTask = JsonConvert.SerializeObject(task);
                    StringContent content = new StringContent(jsonTask, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Task added successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to add task. Status Code: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private async void NewTask_Load(object sender, EventArgs e)
        {

            // ComboBox kontrolünü temizleyin
            comboBox1.Items.Clear();

            // İlk öğe olarak "Bir Kişi Seçin" ekleyin
            comboBox1.Items.Add("Choose someone...");

            string apiurl = $"https://localhost:44340/project/{Project.projectID}/users";

            using( HttpClient client = new HttpClient())
            {
                try
                {
                    // API çağrısını yap
                    HttpResponseMessage response = await client.GetAsync(apiurl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var users = JsonConvert.DeserializeObject<List<UserDto>>(responseBody);

                        // DataGridView'i doldur
                        foreach (var user in users)
                        {
                            comboBox1.Items.Add(user.username);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"API çağrısı başarısız oldu: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }

            }


           

            // Varsayılan olarak ilk öğeyi seçili yapın
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
