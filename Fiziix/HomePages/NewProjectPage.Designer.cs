namespace Fiziix.HomePages
{
    partial class NewProjectPage
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.projectDescriptionText = new System.Windows.Forms.TextBox();
            this.projectNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectionCode = new System.Windows.Forms.Label();
            this.editProfileBtn = new System.Windows.Forms.Button();
            this.uploadPhotoBtn = new System.Windows.Forms.Button();
            this.photoPathText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.warningNewProject = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 1);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1163, 110);
            this.label3.TabIndex = 6;
            this.label3.Text = "Create a New Project";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectDescriptionText
            // 
            this.projectDescriptionText.BackColor = System.Drawing.Color.MidnightBlue;
            this.projectDescriptionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectDescriptionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.projectDescriptionText.Location = new System.Drawing.Point(308, 273);
            this.projectDescriptionText.Multiline = true;
            this.projectDescriptionText.Name = "projectDescriptionText";
            this.projectDescriptionText.Size = new System.Drawing.Size(233, 410);
            this.projectDescriptionText.TabIndex = 20;
            // 
            // projectNameText
            // 
            this.projectNameText.BackColor = System.Drawing.Color.MidnightBlue;
            this.projectNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.projectNameText.Location = new System.Drawing.Point(308, 213);
            this.projectNameText.Multiline = true;
            this.projectNameText.Name = "projectNameText";
            this.projectNameText.Size = new System.Drawing.Size(233, 31);
            this.projectNameText.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(4, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 31);
            this.label5.TabIndex = 18;
            this.label5.Text = "Project Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.label4.Location = new System.Drawing.Point(4, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Project Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(591, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Connection Code:";
            // 
            // connectionCode
            // 
            this.connectionCode.AutoSize = true;
            this.connectionCode.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.connectionCode.Location = new System.Drawing.Point(824, 577);
            this.connectionCode.Name = "connectionCode";
            this.connectionCode.Size = new System.Drawing.Size(116, 31);
            this.connectionCode.TabIndex = 22;
            this.connectionCode.Text = "ABCDE";
            // 
            // editProfileBtn
            // 
            this.editProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editProfileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.editProfileBtn.Location = new System.Drawing.Point(696, 634);
            this.editProfileBtn.Name = "editProfileBtn";
            this.editProfileBtn.Size = new System.Drawing.Size(244, 48);
            this.editProfileBtn.TabIndex = 25;
            this.editProfileBtn.Text = "CREATE";
            this.editProfileBtn.UseVisualStyleBackColor = true;
            this.editProfileBtn.Click += new System.EventHandler(this.editProfileBtn_Click);
            // 
            // uploadPhotoBtn
            // 
            this.uploadPhotoBtn.BackColor = System.Drawing.SystemColors.Control;
            this.uploadPhotoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadPhotoBtn.ForeColor = System.Drawing.Color.Black;
            this.uploadPhotoBtn.Location = new System.Drawing.Point(905, 332);
            this.uploadPhotoBtn.Name = "uploadPhotoBtn";
            this.uploadPhotoBtn.Size = new System.Drawing.Size(35, 32);
            this.uploadPhotoBtn.TabIndex = 35;
            this.uploadPhotoBtn.Text = "...";
            this.uploadPhotoBtn.UseVisualStyleBackColor = false;
            this.uploadPhotoBtn.Click += new System.EventHandler(this.uploadPhotoBtn_Click);
            // 
            // photoPathText
            // 
            this.photoPathText.BackColor = System.Drawing.Color.MidnightBlue;
            this.photoPathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.photoPathText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.photoPathText.Location = new System.Drawing.Point(696, 332);
            this.photoPathText.Multiline = true;
            this.photoPathText.Name = "photoPathText";
            this.photoPathText.Size = new System.Drawing.Size(203, 31);
            this.photoPathText.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.label13.Location = new System.Drawing.Point(591, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 31);
            this.label13.TabIndex = 33;
            this.label13.Text = "Photo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(596, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // warningNewProject
            // 
            this.warningNewProject.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningNewProject.ForeColor = System.Drawing.Color.Red;
            this.warningNewProject.Location = new System.Drawing.Point(696, 685);
            this.warningNewProject.Name = "warningNewProject";
            this.warningNewProject.Size = new System.Drawing.Size(467, 30);
            this.warningNewProject.TabIndex = 36;
            // 
            // NewProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.warningNewProject);
            this.Controls.Add(this.uploadPhotoBtn);
            this.Controls.Add(this.photoPathText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editProfileBtn);
            this.Controls.Add(this.connectionCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectDescriptionText);
            this.Controls.Add(this.projectNameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "NewProjectPage";
            this.Size = new System.Drawing.Size(1166, 741);
            this.Load += new System.EventHandler(this.NewProjectPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projectDescriptionText;
        private System.Windows.Forms.TextBox projectNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label connectionCode;
        private System.Windows.Forms.Button editProfileBtn;
        private System.Windows.Forms.Button uploadPhotoBtn;
        private System.Windows.Forms.TextBox photoPathText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label warningNewProject;
    }
}
