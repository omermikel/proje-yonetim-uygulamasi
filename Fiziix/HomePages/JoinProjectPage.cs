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
    public partial class JoinProjectPage : UserControl
    {
        public JoinProjectPage()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(connectionCodeText.Text))
            {
                warning.Text = "*Please enter connection code.";
                return;
            }

            string Code = connectionCodeText.Text;

            string apiurl = "https://localhost:44340/projects/joinproject";

            using(HttpClient client = new HttpClient())
            {
                var join = new
                {
                    UserID = User.userID,
                    ConnectionCode = Code,
                };

                var json = JsonConvert.SerializeObject(join);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(apiurl, data);

                string result = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    warning.Text="You joined to project!";
                }
                else
                {
                    dynamic responseObject =JsonConvert.DeserializeObject(result);
                    string errorMessage = responseObject.message ?? "Bilinmeyen bir hata oluştu.";
                    warning.Text = errorMessage;
                }

            }

        }
    }
}
