using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Fiziix.HomePages;
using Fiziix.Models;
using Newtonsoft.Json;
using static Fiziix.Models.HomePageStatsDto;

namespace Fiziix.HomePages
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public async void refresh()
        {
            label1.Text =$"WELCOME {User.name}" ;
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart3.Series.Clear();
            chart1.Series.Add("Tamamlanan Görev");
            chart1.Series.Add("Tamamlanmayan Görev");
            chart2.Series.Add("Gönderi Sayısı");
            chart3.Series.Add("Beğeni Sayısı");
            string apiUrl = $"https://localhost:44340/homepage/{User.userID}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    // API'den alınan veriyi işleme
                    var content = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<ApiResponse>(content);

                    // Veriyi UI'ye aktar
                   
                    UpdateChart1(apiResponse.ProjectTasksStatus);
                    UpdateChart2(apiResponse.UserPosts);
                    UpdateChart3(apiResponse.UserLikes);
                }
                else
                {
                    MessageBox.Show("Veri alınırken bir hata oluştu.");
                }

            }
        }

        private void UpdateChart1(List<ProjectTaskStatus> projectTasksStatus)
        {

            chart1.Series["Tamamlanan Görev"].Points.Clear();
            chart1.Series["Tamamlanmayan Görev"].Points.Clear();

            foreach (var status in projectTasksStatus)
            {
                chart1.Series["Tamamlanan Görev"].Points.AddXY(status.ProjectName, status.CompletedTasks);
                chart1.Series["Tamamlanmayan Görev"].Points.AddXY(status.ProjectName, status.IncompleteTasks);
            }
        }

        private void UpdateChart2(List<UserPost> userPosts)
        {
            chart2.Series["Gönderi Sayısı"].Points.Clear();

            foreach (var post in userPosts)
            {
                chart2.Series["Gönderi Sayısı"].Points.AddXY(post.ProjectName, post.PostCount);
            }
        }
        private void UpdateChart3(List<UserLike> userLikes)
        {
            chart3.Series["Beğeni Sayısı"].Points.Clear();

            foreach (var like in userLikes)
            {
                chart3.Series["Beğeni Sayısı"].Points.AddXY(like.ProjectName, like.LikeCount);
            }
        }

    }
}

