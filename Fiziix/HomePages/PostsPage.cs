using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Fiziix.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Fiziix.HomePages
{
    public partial class PostsPage : UserControl
    {
        int DUR = 0;
        int offset = 0;
        private int[] postid = new int[3];
        private bool[] flag= new bool[3];
        private int[] likeCount= new int[3];
        string like = @"C:\Users\omerm\source\repos\Fiziix\Fiziix\images\likee-Photoroom.png";
        string unlike = @"C:\Users\omerm\source\repos\Fiziix\Fiziix\images\likeempty.png";

        public PostsPage()
        {
            InitializeComponent();
        }

        private void PostsPage_Load(object sender, EventArgs e)
        {
        }
        public async void refresh(int offset)
        {
            string apiurl = $"https://localhost:44340/posts/{User.userID}/{offset}";
            using (HttpClient client = new HttpClient())
            {
                
                HttpResponseMessage response = await client.GetAsync(apiurl,0);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    List<PostsDto> posts = JsonConvert.DeserializeObject<List<PostsDto>>(jsonResponse);

                    for (int i = 0; i < posts.Count; i++)
                    {
                        if (i == 0)
                        {
                            postid[0] = posts[i].PostID;
                            project1.Text = posts[i].ProjectName;
                            username1.Text = posts[i].Username;
                            pictureBox1.Image = ImageConvert.Base64ToImage(posts[i].UserPhoto);
                            content1.Text = posts[i].Content;
                            postPicture1.Image = ImageConvert.Base64ToImage(posts[i].PostImage);
                            flag[0] = posts[i].IsLiked;
                            likeCount[0] = posts[i].LikeCount;
                            date1.Text = posts[i].CreatedAt.ToString();
                        }
                        if (i == 1)
                        {
                            postid[1] = posts[i].PostID;
                            project2.Text = posts[i].ProjectName;
                            username2.Text = posts[i].Username;
                            pictureBox2.Image = ImageConvert.Base64ToImage(posts[i].UserPhoto);
                            content2.Text = posts[i].Content;
                            postPicture2.Image = ImageConvert.Base64ToImage(posts[i].PostImage);
                            flag[1] = posts[i].IsLiked;
                            likeCount[1] = posts[i].LikeCount;
                            date2.Text = posts[i].CreatedAt.ToString();
                        }
                        if (i == 2)
                        {
                            postid[2] = posts[i].PostID;
                            project3.Text = posts[i].ProjectName;
                            username3.Text = posts[i].Username;
                            pictureBox3.Image = ImageConvert.Base64ToImage(posts[i].UserPhoto);
                            content3.Text = posts[i].Content;
                            postPicture3.Image = ImageConvert.Base64ToImage(posts[i].PostImage); 
                            flag[2] = posts[i].IsLiked;
                            likeCount[2] = posts[i].LikeCount;
                            date3.Text = posts[i].CreatedAt.ToString();
                        }
                    }
                    if (postid[2] == postid[1])
                    {
                        postid[2] = 0;
                        project3.Text = "";
                        username3.Text = "";
                        pictureBox3.Image = null;
                        content3.Text = "";
                        postPicture3.Image = null;
                        flag[2] = false;
                        likeCount[2] = 0;
                        date3.Text = "";
                        like3.Text = $"{likeCount[2]} members liked!";
                        likeb3.BackgroundImage = Image.FromFile(unlike);
                        DUR = 1;
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Veriler çekilemedi.");
                }

                like1.Text = $"{likeCount[0]} members liked!";
                like2.Text = $"{likeCount[1]} members liked!";
                like3.Text = $"{likeCount[2]} members liked!";

                if (flag[0])
                    likeb1.BackgroundImage = Image.FromFile(like);
                else
                    likeb1.BackgroundImage = Image.FromFile(unlike);
                if (flag[1])
                    likeb2.BackgroundImage = Image.FromFile(like);
                else
                    likeb2.BackgroundImage = Image.FromFile(unlike);
                if (flag[2])
                    likeb3.BackgroundImage = Image.FromFile(like);
                else
                    likeb3.BackgroundImage = Image.FromFile(unlike);
            }   
        }

        private async void likepost(int postID)
        {
            string likeurl = $"https://localhost:44340/posts/{User.userID}/like/{postID}";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response =  await client.PostAsync(likeurl,null);
            }
        }
        private async void unlikepost(int postID)
        {
            string unlike = $"https://localhost:44340/posts/{User.userID}/unlike/{postID}";
            using (HttpClient client = new HttpClient())
            {
                 await client.DeleteAsync(unlike);
            }
        }

        private void likeb1_Click(object sender, EventArgs e)
        {
            if (flag[0] == false)
            {
                likeb1.BackgroundImage = Image.FromFile(like);
                flag[0] = true;
                like1.Text = $"{++likeCount[0]} members liked!";
                likepost(postid[0]);
            }
            else
            {
                likeb1.BackgroundImage = Image.FromFile(unlike);
                flag[0] = false;
                like1.Text = $"{--likeCount[0]} members liked!";
                unlikepost(postid[0]);
            }
        }

        private void likeb2_Click(object sender, EventArgs e)
        {
            if (flag[1] == false)
            {
                likeb2.BackgroundImage = Image.FromFile(like);
                flag[1] = true;
                like2.Text = $"{++likeCount[1]} members liked!";
                likepost(postid[1]);
            }
            else 
            {  
                likeb2.BackgroundImage = Image.FromFile(unlike);
                flag[1] = false;
                like2.Text = $"{--likeCount[1]} members liked!";
                unlikepost(postid[1]);
            }    
        }

        private void likeb3_Click(object sender, EventArgs e)
        {
            if (flag[2] == false)
            {
                likeb3.BackgroundImage = Image.FromFile(like);
                flag[2] = true;
                like3.Text = $"{++likeCount[2]} members liked!";
                likepost(postid[2]);
            }
            else
            {
                likeb3.BackgroundImage = Image.FromFile(unlike);
                flag[2] = false;
                like3.Text = $"{--likeCount[2]} members liked!";
                unlikepost(postid[2]);
            }
        }
        private void right_Click(object sender, EventArgs e)
        {
            if (postid[2] == postid[1]|| DUR==1)
            {
                postid[2] = 0;
                project3.Text = "";
                username3.Text = "";
                pictureBox3.Image= null;
                content3.Text = "";
                postPicture3.Image = null;
                flag[2] = false;
                likeCount[2] = 0;
                date3.Text = "";
                like3.Text = $"{likeCount[2]} members liked!";
                likeb3.BackgroundImage = Image.FromFile(unlike);
                return;
            }

            offset++;
            refresh(offset);
        }

        private void left_Click(object sender, EventArgs e)
        {
            DUR = 0;
            offset--;
            if(offset <0 )
            {
                offset = 0;
                return;
            }

            refresh(offset);
        }
    }
}
