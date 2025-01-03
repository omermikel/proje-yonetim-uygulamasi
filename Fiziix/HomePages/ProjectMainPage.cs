using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;
using Fiziix.Models;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms.DataVisualization.Charting;


namespace Fiziix.HomePages
{
    public partial class ProjectMainPage : UserControl
    {
        public ProjectMainPage()
        {
            InitializeComponent();
            dataGridView1.CellClick += DataGridView1_CellClick;
            
        }

        private ToolStripButton deleteButton;
        private ToolStripButton removememberButton;
        private ToolStripButton newtaskButton;
        int i = 0;
        public void refresh()
        {
            chart1.Hide();
            dataGridView1.Columns.Clear();
            toolStrip1.Items.Clear();

            Image newpostImage = Image.FromFile("C:\\Users\\omerm\\source\\repos\\Fiziix\\Fiziix\\images\\add.png");
            Image postsImage = Image.FromFile("C:\\Users\\omerm\\source\\repos\\Fiziix\\Fiziix\\images\\yeşilev.png");
            Image tasksImage = Image.FromFile("C:\\Users\\omerm\\source\\repos\\Fiziix\\Fiziix\\images\\task.png");
            Image groupmembersImage = Image.FromFile("C:\\Users\\omerm\\source\\repos\\Fiziix\\Fiziix\\images\\group.png");
            Image leaveGroupImage = Image.FromFile("C:\\Users\\omerm\\source\\repos\\Fiziix\\Fiziix\\images\\person_remove_42dp_EA3323_FILL0_wght400_GRAD0_opsz40.png");

            ToolStripButton newpostButton = new ToolStripButton
            {
                Image = newpostImage,
                Text = "New Post",
                ImageScaling = ToolStripItemImageScaling.SizeToFit,
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextAlign = ContentAlignment.MiddleRight,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                ToolTipText = "New Post",
                Height = 42
            };
            newpostButton.Click += (s, e) => NewPost();

            ToolStripButton postsButton = new ToolStripButton
            {
                Image = postsImage,
                Text = "Posts",
                ImageScaling = ToolStripItemImageScaling.SizeToFit,
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextAlign = ContentAlignment.MiddleRight,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                ToolTipText = "Posts",
                Height = 42
            };
            postsButton.Click += (s, e) => Posts();

            ToolStripButton tasksButton = new ToolStripButton
            {
                Image = tasksImage,
                Text = "Tasks",
                ImageScaling = ToolStripItemImageScaling.SizeToFit,
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextAlign = ContentAlignment.MiddleRight,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                ToolTipText = "Tasks",
                Height = 42
            };
            tasksButton.Click += (s, e) => Tasks();

            ToolStripButton groupButton = new ToolStripButton
            {
                Image = groupmembersImage,
                Text = "Group Members",
                ImageScaling = ToolStripItemImageScaling.SizeToFit,
                DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                TextAlign = ContentAlignment.MiddleRight,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                ToolTipText = "Group Members",
                Height = 42
            };
            groupButton.Click += (s, e) => ShowGroup();

            toolStrip1.Items.Add(newpostButton);
            toolStrip1.Items.Add(postsButton);
            toolStrip1.Items.Add(tasksButton);
            toolStrip1.Items.Add(groupButton);

            if (User.username == Project.manager)
            {

                Image deleteImage = Image.FromFile("C:\\Users\\omerm\\source\\repos\\Fiziix\\Fiziix\\images\\delete.png");
                Image newtaskImage = Image.FromFile("C:\\Users\\omerm\\source\\repos\\Fiziix\\Fiziix\\images\\newtask.png");
                Image removememberImage = Image.FromFile("C:\\Users\\omerm\\source\\repos\\Fiziix\\Fiziix\\images\\removemember.png");


                ToolStripButton deleteButton = new ToolStripButton
                {
                    Image = deleteImage,
                    Text = "Delete Project",
                    ImageScaling = ToolStripItemImageScaling.SizeToFit,
                    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                    TextAlign = ContentAlignment.MiddleRight,
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    ToolTipText = "Delete Project",
                    Height = 42
                };
                deleteButton.Click += (s, e) => DeleteProject();

                ToolStripButton newtaskButton = new ToolStripButton
                {
                    Image = newtaskImage,
                    Text = "New Task",
                    ImageScaling = ToolStripItemImageScaling.SizeToFit,
                    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                    TextAlign = ContentAlignment.MiddleRight,
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    ToolTipText = "New Task",
                    Height = 42
                };
                newtaskButton.Click += (s, e) => NewTask();

                // ToolStrip'e butonu ekleyin
                toolStrip1.Items.Add(deleteButton);

                toolStrip1.Items.Add(newtaskButton);

                toolStrip1.Items[toolStrip1.Items.Count - 1].Alignment = ToolStripItemAlignment.Right;
                toolStrip1.Items[toolStrip1.Items.Count - 2].Alignment = ToolStripItemAlignment.Right;
                i++;
            }
            else
            {
                ToolStripButton leaveGroupButton = new ToolStripButton
                {
                    Image = leaveGroupImage,
                    Text = "Leave Group",
                    ImageScaling = ToolStripItemImageScaling.SizeToFit,
                    DisplayStyle = ToolStripItemDisplayStyle.ImageAndText,
                    TextAlign = ContentAlignment.MiddleRight,
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    ToolTipText = "Leave Group",
                    Height = 42
                };
                leaveGroupButton.Click += (s, e) => Leave();

                toolStrip1.Items.Add(leaveGroupButton);

                toolStrip1.Items[toolStrip1.Items.Count - 1].Alignment = ToolStripItemAlignment.Right;
            }


            if (!string.IsNullOrEmpty(Project.projectImage))
            {
                pictureBox1.Image = ImageConvert.Base64ToImage(Project.projectImage);
            }
            else
            {
                pictureBox1.Image = Image.FromFile("C:\\Users\\omerm\\source\\repos\\Fiziix\\Fiziix\\images\\yeşilev.png");
            }


            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            projectname.Text = Project.projectName;
            description.Text = Project.projectDescription;
            ConnecitonCode.Text = Project.connectionCode;

           

            //  UpdateProgressBar();

        }
        private async void Leave()
        {
            var confirmResult = MessageBox.Show("Are you sure about leave the group?",
                                            "Sure?",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {

                string apiUrl = $"https://localhost:44340/project/{User.userID}/{Project.projectID}";

                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        HttpResponseMessage response = await client.DeleteAsync(apiUrl);

                        if (response.IsSuccessStatusCode)
                        { 
                            // Proje listesini yenile
                            Home parentForm = this.Parent as Home;
                            if (parentForm != null)
                            {
                                parentForm.showProjects();
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
            }
        }

        private async void ShowGroup()
        {
            chart1.Hide();
            dataGridView1.Rows.Clear(); // Mevcut satırları temizle
            dataGridView1.Columns.Clear(); // Mevcut kolonları temizle

            // Kolonları ekleyin
            dataGridView1.Columns.Add("Username", "Username");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Lastname", "Lastname");
            dataGridView1.Columns.Add("Position", "Position");

            if (User.username == Project.manager)
            {
                // Remove Group butonunu içeren bir DataGridViewButtonColumn ekleyin
                DataGridViewButtonColumn removeButtonColumn = new DataGridViewButtonColumn();
                removeButtonColumn.Name = "RemoveGroup";
                removeButtonColumn.HeaderText = "Remove Group";
                removeButtonColumn.Text = "Remove";
                removeButtonColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(removeButtonColumn);
            }


            string apiUrl = $"https://localhost:44340/project/{Project.projectID}/users";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // API çağrısını yap
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();
                        var users = JsonConvert.DeserializeObject<List<UserDto>>(responseBody);

                        // DataGridView'i doldur
                        foreach (var user in users)
                        {
                            dataGridView1.Rows.Add(user.username, user.name, user.lastname, user.position);
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

            // DataGridView'i hücre içeriklerine göre boyutlandırma
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Son sütunu dolduracak şekilde ayarlama
            dataGridView1.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private async void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sütunun 'RemoveGroup' olup olmadığını kontrol edin
            if (User.username == Project.manager && dataGridView1.Columns.Contains("RemoveGroup") &&
                e.ColumnIndex == dataGridView1.Columns["RemoveGroup"].Index && e.RowIndex >= 0)
            {
                // Tıklanan satırdaki username'yi alın
                string username = (dataGridView1.Rows[e.RowIndex].Cells["Username"].Value.ToString());

                var confirmResult = MessageBox.Show("Are you sure remove the member?","Sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Kullanıcıyı projeden çıkaran fonksiyonu çağırın
                    RemoveUserFromProject(username);
                }
            }
            else if (User.username == Project.manager && dataGridView1.Columns.Contains("Delete Task") &&
                e.ColumnIndex == dataGridView1.Columns["Delete Task"].Index && e.RowIndex >= 0)
            {
                // Tıklanan satırdaki username'yi alın
                int taskid = (int)(dataGridView1.Rows[e.RowIndex].Cells["TaskID"].Value);

                var confirmResult = MessageBox.Show("Are you sure about delete this task?",
                                             "Sure?",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    DeleteTask(taskid);
                }
            }
            else if (User.username == Project.manager && dataGridView1.Columns.Contains("Delete Post") &&
                e.ColumnIndex == dataGridView1.Columns["Delete Post"].Index && e.RowIndex >= 0)
            {
                // Tıklanan satırdaki username'yi alın
                int postid = (int)(dataGridView1.Rows[e.RowIndex].Cells["PostID"].Value);

                var confirmResult = MessageBox.Show("Are you sure about delete this post?",
                                             "Sure?",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    // Kullanıcıyı projeden çıkaran fonksiyonu çağırın
                    DeletePost(postid);
                }
            }
            else if (User.username == Project.manager && dataGridView1.Columns.Contains("File") && e.ColumnIndex == dataGridView1.Columns["File"].Index
                    && e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["File"].Value != null
                    && !string.IsNullOrWhiteSpace(dataGridView1.Rows[e.RowIndex].Cells["File"].Value.ToString()))
            {
                string base64string = null;
                int taskid = (int)(dataGridView1.Rows[e.RowIndex].Cells["TaskID"].Value);
                    
                string apiurl = $"https://localhost:44340/project/{Project.projectID}/taskfile/{taskid}";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiurl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseString = await response.Content.ReadAsStringAsync();
                        var filestring = JsonConvert.DeserializeObject<string>(responseString);

                        base64string = filestring;
                    }
                    else
                    {
                        MessageBox.Show("No file found for this task.");
                        return;
                    }
                }
                showFile(base64string);
            }
            else if (User.username == Project.manager &&
                    dataGridView1.Columns.Contains("Complete Task") &&
                    e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                    dataGridView1.Rows[e.RowIndex].Cells["Status"].Value != null &&
                    dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "1" &&
                    e.ColumnIndex == dataGridView1.Columns["Complete Task"].Index)
            {
                int taskid = (int)(dataGridView1.Rows[e.RowIndex].Cells["TaskID"].Value);
                var confirmResult = MessageBox.Show("Are you sure about complete this task?",
                                                "Sure?",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {

                    CompleteTask(taskid);
                }
            }
        }
        private async void CompleteTask(int taskid)
        {
            string apiurl = $"https://localhost:44340/project/{Project.projectID}/completetask/{taskid}";
            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.PutAsync(apiurl,null);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Sucsessful!");
                }
                else
                {
                    MessageBox.Show("Error " + response.ReasonPhrase);
                }

            }
            Tasks();
        }
        private void showFile(string base64string)
        {

            // Base64 string'i byte dizisine çevir
            byte[] fileBytes = Convert.FromBase64String(base64string);

            // Dosyayı geçici bir dosya olarak kaydet
            string tempFilePath = Path.Combine(Path.GetTempPath(), "file");

            // Dosyanın türünü tahmin edebilir veya kullanıcının kaydettiği dosya türüne göre bir uzantı belirleyebilirsiniz.
            File.WriteAllBytes(tempFilePath, fileBytes);

            // Dosyayı varsayılan programla aç
            System.Diagnostics.Process.Start(tempFilePath);
        }

        private async void DeletePost(int postid)
        {
            string apiurl = $"https://localhost:44340/project/{Project.projectID}/deletepost/{postid}";
            using(HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(apiurl);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sucsessful");
                }
                else
                {
                    MessageBox.Show("Error " + response.ReasonPhrase);
                }
            }
            Posts();
        }

        private async void DeleteTask(int taskid)
        {
            string apiurl = $"https://localhost:44340/project/{Project.projectID}/deletetask/{taskid}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(apiurl);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Sucsessful");
                }
                else
                {
                    MessageBox.Show("Error " + response.ReasonPhrase);
                }
            }
            Tasks();
        }

        private async void RemoveUserFromProject(string username)
        {
            int projectId = Project.projectID;
            int userId;
            // Önce API'den kullanıcı ID'sini alalım
            string getUserApiUrl = $"https://localhost:44340/users/{username}";


            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage userResponse = await client.GetAsync(getUserApiUrl);

                if (userResponse.IsSuccessStatusCode)
                {
                    string userResponseBody = await userResponse.Content.ReadAsStringAsync();
                    var userIdResponse = JsonConvert.DeserializeObject<UserIDDto>(userResponseBody);
                    userId = userIdResponse.userID;
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                    return;
                }
            }

            // API endpoint'ini çağırarak kullanıcıyı projeden çıkaralım
            string deleteApiUrl = $"https://localhost:44340/project/{projectId}/remove/{userId}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(deleteApiUrl);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Kullanıcı başarıyla projeden çıkarıldı.");
                    ShowGroup();  // Grup bilgilerini yeniden yüklemek için
                }
                else
                {
                    MessageBox.Show("Kullanıcı projeden çıkarılamadı.");
                }
            }
        }

        private void NewPost()
        {
            NewPostPage newPostPage = new NewPostPage();
            newPostPage.StartPosition = FormStartPosition.CenterParent;
            newPostPage.ShowDialog();
            Posts();
        }

        private async void Posts()
        {
            chart1.Hide();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("PostID", "PostId");
            dataGridView1.Columns.Add("Content", "Content");
            dataGridView1.Columns.Add("Username", "Username");
            dataGridView1.Columns.Add("CreateAt", "CreateAt");

            if (User.username == Project.manager)
            {
                // Delete Task butonunu içeren bir DataGridViewButtonColumn ekleyin
                DataGridViewButtonColumn DeleteTaskButton = new DataGridViewButtonColumn();
                DeleteTaskButton.Name = "Delete Post";
                DeleteTaskButton.HeaderText = "Delete Post";
                DeleteTaskButton.Text = "Delete";
                DeleteTaskButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(DeleteTaskButton);
            }

           
            
            string apiUrl = $"https://localhost:44340/project/{Project.projectID}/posts";

            using (HttpClient client = new HttpClient())
            {
                // Fetch posts from the API
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                var posts = System.Text.Json.JsonSerializer.Deserialize<List<PostDto>>(jsonResponse, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                // Clear existing rows
                dataGridView1.Rows.Clear();

                // Populate DataGridView
                foreach (var post in posts)
                {
                    dataGridView1.Rows.Add(post.PostId, post.Content, post.Username, post.CreatedAt);
                }

                // DataGridView'i hücre içeriklerine göre boyutlandırma
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                // Son sütunu dolduracak şekilde ayarlama
                dataGridView1.Columns["Content"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private async void Tasks()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear(); // Sütunları da temizlemek gerekebilir

            dataGridView1.Columns.Add("TaskID", "TaskID");
            dataGridView1.Columns.Add("Username", "Username");
            dataGridView1.Columns.Add("TaskName", "TaskName");
            dataGridView1.Columns.Add("TaskDescription", "Description");
            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.Columns.Add("CreatedBy", "CreatedBy");
            //dataGridView1.Columns.Add("AssignedTo", "AssignedTo");
            dataGridView1.Columns.Add("CreateAt", "CreateAt");
            dataGridView1.Columns.Add("DueDate", "DueDate");
            dataGridView1.Columns.Add("File", "File");

            dataGridView1.Columns["TaskID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["Username"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["TaskDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns["File"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns["CreateAt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["DueDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["CreatedBy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            //dataGridView1.Columns["AssignedTo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["TaskName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            if (User.username == Project.manager)
            {
                // Complete Task butonunu içeren bir DataGridViewButtonColumn ekleyin
                DataGridViewButtonColumn CompleteTaskBuuton = new DataGridViewButtonColumn();
                CompleteTaskBuuton.Name = "Complete Task";
                CompleteTaskBuuton.HeaderText = "Complete Task";
                CompleteTaskBuuton.Text = "✓";
                CompleteTaskBuuton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(CompleteTaskBuuton);

                // Delete Task butonunu içeren bir DataGridViewButtonColumn ekleyin
                DataGridViewButtonColumn DeleteTaskButton = new DataGridViewButtonColumn();
                DeleteTaskButton.Name = "Delete Task";
                DeleteTaskButton.HeaderText = "Delete Task";
                DeleteTaskButton.Text = "X";
                DeleteTaskButton.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(DeleteTaskButton);

                dataGridView1.Columns["Complete Task"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dataGridView1.Columns["Delete Task"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            }

            string apiUrl = $"https://localhost:44340/project/{Project.projectID}/tasks";

            using (HttpClient client = new HttpClient())
            {
                // API'den görevleri al
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                var tasks = System.Text.Json.JsonSerializer.Deserialize<List<TaskDto>>(jsonResponse, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                // DataGridView'i doldur
                dataGridView1.Rows.Clear();

                foreach (var task in tasks)
                {
                    dataGridView1.Rows.Add(task.TaskID, task.AssignedUserName, task.TaskName, task.TaskDescription, task.Status,
                        task.CreatedBy,  task.CreateAt, task.DueDate, task.File);
                }
                dataGridView1.Columns["CreateAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridView1.Columns["DueDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            UpdatePieChart();
          //  UpdateProgressBar(); // Eğer bu işlem zaman alıyorsa progress bar güncellenebilir
        }
    
        private async void DeleteProject()
        {
            var confirmResult = MessageBox.Show("Are you sure to delete project?",
                                             "Are you Sure?",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                string apiurl = $"https://localhost:44340/project/deleteproject/{Project.projectID}";
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.DeleteAsync(apiurl);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sucsessful");
                        Home parentForm = this.Parent as Home;

                        if (parentForm != null)
                        {
                            parentForm.showProjects();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error " + response.ReasonPhrase);
                    }
                }
            }
        }

        private void NewTask()
        {
            NewTask newTask = new NewTask();
            newTask.StartPosition = FormStartPosition.CenterParent;
            newTask.ShowDialog();
            Tasks();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Örnek koşul: Belirli bir sütunun değeri
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "2")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (status == "1")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (status == "0")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void UpdatePieChart()
        {
            chart1.Show();
            int countStatus1 = 0; // Hazır görev sayısı (Status 1)
            int countStatus2 = 0; // Tamamlanan görev sayısı (Status 2)
            int totalRows = dataGridView1.Rows.Count; // Toplam görev sayısı

            // Eğer toplam satır sayısı sıfırsa, grafiği güncelleme
            if (totalRows == 0)
            {
                // Hiç görev yoksa grafiği temizle ve başlık göster
                chart1.Series.Clear();
                chart1.Titles.Clear();
                chart1.Titles.Add("Görev Durumu Dağılımı (Veri Yok)");
                return;
            }

            // Görevleri kontrol et
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Status"].Value != null)
                {
                    if (int.TryParse(row.Cells["Status"].Value.ToString(), out int status))
                    {
                        if (status == 1) // Status 1: Hazır
                        {
                            countStatus1++;
                        }
                        else if (status == 2) // Status 2: Tamamlandı
                        {
                            countStatus2++;
                        }
                    }
                }
            }

            int incompleteTasks = totalRows - (countStatus1 + countStatus2); // Tamamlanmayan görev sayısı

            // Chart Ayarları
            chart1.Series.Clear(); // Var olan serileri temizle
            Series series = new Series
            {
                Name = "Tasks",
                ChartType = SeriesChartType.Pie, // Pie Chart olarak ayarla
                IsValueShownAsLabel = true, // Değerlerin etiket olarak gösterilmesini sağla
                BorderWidth = 1
            };

            chart1.Series.Add(series);
            
            // Veri Ekle
            series.Points.AddXY("Hazır Görevler", countStatus1);
            series.Points.AddXY("Tamamlanan Görevler", countStatus2);
            series.Points.AddXY("Tamamlanmayan Görevler", incompleteTasks);

            // Etiketler
            series.Points[0].LegendText= $"Hazır: {countStatus1} ";
            series.Points[1].LegendText= $"Tamamlanan: {countStatus2} ";
            series.Points[2].LegendText= $"Tamamlanmamış: {incompleteTasks} ";

            // Renkler
            series.Points[0].Color = System.Drawing.Color.Yellow; // Hazır görevler için mavi
            series.Points[1].Color = System.Drawing.Color.Green; // Tamamlanan görevler için yeşil
            series.Points[2].Color = System.Drawing.Color.LightGray; // Tamamlanmayan görevler için kırmızı

            // Chart başlık ayarları
            chart1.Titles.Clear();
            chart1.Titles.Add($"Görev Durumu Dağılımı - Toplam: {totalRows} Görev");

            // Chart içindeki etiketlerin karışmaması için etiketlerin dışarıya konulması
            foreach (var point in series.Points)
            {
                point.LabelBackColor = System.Drawing.Color.Transparent; // Arka planı transparan yap
                point.IsValueShownAsLabel = true;
                point.LabelAngle = 0; // Etiketlerin açılarını düz tut
            }
        }

        //private void UpdateProgressBar()
        //{
        //    int countStatus2 = 0;
        //    int totalRows = dataGridView1.Rows.Count;

        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        // Satırın bir DataGridViewCell sınıfından değer aldığını doğrulayın
        //        if (row.Cells["Status"].Value != null)
        //        {
        //            // "Status" hücresindeki değeri int olarak al
        //            if (int.TryParse(row.Cells["Status"].Value.ToString(), out int status))
        //            {
        //                // Status değerinin 2 olup olmadığını kontrol edin
        //                if (status == 2)
        //                {
        //                    countStatus2++;
        //                }
        //            }
        //        }
        //    }
        //    // ProgressBar'ı güncelle
        //    progressBar1.Minimum = 0;
        //    progressBar1.Maximum = totalRows;
        //    progressBar1.Value = countStatus2;
        //}
    }
}
    
