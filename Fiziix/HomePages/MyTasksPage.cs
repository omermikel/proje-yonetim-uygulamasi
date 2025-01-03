using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using Fiziix.Models;
using System.Net;
using System.Net.Http;
using System.Text.Json.Nodes;
using Newtonsoft.Json;

namespace Fiziix.HomePages
{
    public partial class MyTasksPage : UserControl
    {
        
        byte[] base64;
        public MyTasksPage()
        {
            InitializeComponent();
        }

        public async void refresh()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear(); // Sütunları da temizlemek gerekebilir

            dataGridView1.Columns.Add("TaskID", "TaskID");
            dataGridView1.Columns.Add("TaskName", "TaskName");
            dataGridView1.Columns.Add("TaskDescription", "Description");
            dataGridView1.Columns.Add("Status", "Status");
            dataGridView1.Columns.Add("CreatedBy", "CreatedBy");
            dataGridView1.Columns.Add("AssignedTo", "AssignedTo");
            dataGridView1.Columns.Add("ProjectID", "ProjectID");
            dataGridView1.Columns.Add("CreateAt", "CreateAt");
            dataGridView1.Columns.Add("DueDate", "DueDate");
            dataGridView1.Columns.Add("File", "File");

            dataGridView1.Columns["TaskID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["ProjectID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns["File"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView1.Columns["CreateAt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["DueDate"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["CreatedBy"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["AssignedTo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dataGridView1.Columns["TaskName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["TaskDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.AutoSize = true;


            DataGridViewButtonColumn UploadTaskButton = new DataGridViewButtonColumn();
            UploadTaskButton.Name = "Upload Task";
            UploadTaskButton.HeaderText = "Upload Task";
            UploadTaskButton.Text = "↑";
            UploadTaskButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(UploadTaskButton);

            dataGridView1.Columns["Upload Task"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            string apiurl = $"https://localhost:44340/users/{User.userID}/tasks";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiurl);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var tasks = JsonConvert.DeserializeObject<List<Tasks>>(json);
                

                    foreach (var task in tasks)
                    {
                        dataGridView1.Rows.Add(
                            task.TaskID,
                            task.TaskName,
                            task.TaskDescription,
                            task.Status,
                            task.CreatedBy,
                            task.AssignedTo,
                            task.ProjectID,
                            task.CreateAt,
                            task.DueDate,
                            task.File
                        );
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns.Contains("Upload Task") &&
                e.ColumnIndex == dataGridView1.Columns["Upload Task"].Index && e.RowIndex >= 0)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filepath = openFileDialog1.FileName;

                    base64 = File.ReadAllBytes(filepath);
                    string base64string = Convert.ToBase64String(base64);

                    int taskid = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["TaskID"].Value);

                    SaveFileToDatabase(taskid, base64string);
                }
            }
        }
        private async void SaveFileToDatabase(int taskid, string base64String)
        {
            string apiurl = $"https://localhost:44340/users/{User.userID}/tasks/{taskid}/addfile";
            using(HttpClient client = new HttpClient())
            {
                var addfile = new AddFileDto
                {
                    TaskID = taskid,
                    File = base64String,
                };

                var json = JsonConvert.SerializeObject(addfile);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(apiurl, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Task updated successfully!");
                }
                else
                {
                    MessageBox.Show($"Failed to update task. Status Code: {response.StatusCode}");
                }
            }
            
        }
    }
}
