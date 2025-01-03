using Newtonsoft.Json;
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

namespace Fiziix.HomePages
{
    public partial class ProjectsPage : UserControl
    {
        private Image defaultImage; // Varsayılan resim

        public ProjectsPage()
        {
            InitializeComponent();
            // Varsayılan resmi yükle
            defaultImage = SystemIcons.Information.ToBitmap();
        }

        public async Task refresh()
        {
            string apiUrl = $"https://localhost:44340/projects/{User.userID}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetStringAsync(apiUrl);
                    var projects = JsonConvert.DeserializeObject<List<ProjectsDto>>(response);

                    dataGridView1.Rows.Clear(); // Önceki verileri temizle

                    foreach (var project in projects)
                    {
                        int rowIndex = dataGridView1.Rows.Add();
                        DataGridViewRow dataGridViewRow = dataGridView1.Rows[rowIndex];

                        // Projeye Git Butonu
                        dataGridViewRow.Cells["enter"].Value = "Enter";

                        // ProjectID
                        dataGridViewRow.Cells["projectID"].Value = project.ProjectID.ToString();

                        // Image
                        if (!string.IsNullOrEmpty(project.ProjectImage))
                        {
                            try
                            {
                                byte[] imageBytes = Convert.FromBase64String(project.ProjectImage);
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    dataGridViewRow.Cells["image"].Value = Image.FromStream(ms);
                                }
                            }
                            catch (Exception)
                            {
                                dataGridViewRow.Cells["image"].Value = defaultImage; // Resmi doğru şekilde yükleyemezse varsayılan resmi kullan
                            }
                        }
                        else
                        {
                            dataGridViewRow.Cells["image"].Value = defaultImage; // Resim null ise varsayılan resmi kullan
                        }

                        // Project Name
                        dataGridViewRow.Cells["projectName"].Value = project.ProjectName;

                        // Project Description
                        dataGridViewRow.Cells["projectDescription"].Value = project.ProjectDescription;

                        // Manager
                        dataGridViewRow.Cells["manager"].Value = project.Manager;

                        // Number of Members
                        dataGridViewRow.Cells["members"].Value = project.MemberCount.ToString();

                        // Projeden Ayrıl Butonu
                        dataGridViewRow.Cells["Leave"].Value = "Leave";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching data: {ex.Message}");
                }
            }

            // Image sütununun özelliklerini ayarlama
            if (dataGridView1.Columns["image"] != null)
            {
                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dataGridView1.Columns["image"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            }   
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["image"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                // Hücredeki Image değerini alın.
                Image img = (Image)e.Value;

                if (img != null)
                {
                    // Görüntüyü hücrenin boyutuna göre ayarlayın (zoom yapma).
                    Rectangle destRect = new Rectangle(e.CellBounds.X, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height);
                    e.Graphics.DrawImage(img, destRect);
                }

                e.Handled = true; // Bu hücreyi manuel boyadığımız için varsayılan boyamayı iptal eder.
            }
        }
        
        public async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["enter"].Index && e.RowIndex >= 0)
            {
                int projectID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProjectID"].Value);

                string apiUrl = $"https://localhost:44340/project/{projectID}";

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var project = JsonConvert.DeserializeObject<ProjectDto>(responseBody);

                        if (project != null)
                        {
                            
                            Project.projectID = project.ProjectID;
                            Project.projectName = project.ProjectName;
                            Project.projectDescription = project.ProjectDescription;
                            Project.manager = project.Manager;
                            Project.connectionCode = project.ConnectionCode;
                            Project.projectImage = project.ProjectImage;

                            
                            Home parentForm = this.Parent as Home;
                            if (parentForm != null)
                            {
                                parentForm.showProject();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proje bilgileri boş döndü.");
                        }
                    }
                    else
                    {
                        MessageBox.Show($"API çağrısı başarısız oldu: {response.StatusCode}");
                    }
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["leave"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure?", "Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var projectId = dataGridView1.Rows[e.RowIndex].Cells["ProjectID"].Value;

                    string deleteApiUrl = $"https://localhost:44340/project/{User.userID}/{projectId}";

                    using (HttpClient client = new HttpClient())
                    {
                        HttpResponseMessage response = await client.DeleteAsync(deleteApiUrl);

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Kullanıcı başarıyla projeden çıkarıldı.");
                            refresh();
                        }
                        else
                        {
                            MessageBox.Show("Kullanıcı projeden çıkarılamadı.");
                        }
                    } 
                }
                
            }
        }
    }
}
