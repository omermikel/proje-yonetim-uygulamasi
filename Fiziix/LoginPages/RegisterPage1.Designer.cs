namespace Fiziix
{
    partial class RegisterPage1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage1));
            this.label5 = new System.Windows.Forms.Label();
            this.rVerificationText = new System.Windows.Forms.TextBox();
            this.rPasswordText = new System.Windows.Forms.TextBox();
            this.rUsernameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rPassword1Text = new System.Windows.Forms.TextBox();
            this.verificationCode1 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.warningUsername = new System.Windows.Forms.Label();
            this.warningPassword = new System.Windows.Forms.Label();
            this.warning2 = new System.Windows.Forms.Label();
            this.warningVerification = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(197, 575);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 45);
            this.label5.TabIndex = 45;
            this.label5.Text = " <";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // rVerificationText
            // 
            this.rVerificationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.rVerificationText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rVerificationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.rVerificationText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rVerificationText.Location = new System.Drawing.Point(191, 402);
            this.rVerificationText.Name = "rVerificationText";
            this.rVerificationText.Size = new System.Drawing.Size(219, 28);
            this.rVerificationText.TabIndex = 3;
            this.rVerificationText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rPasswordText
            // 
            this.rPasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.rPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.rPasswordText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rPasswordText.Location = new System.Drawing.Point(164, 262);
            this.rPasswordText.Name = "rPasswordText";
            this.rPasswordText.PasswordChar = '*';
            this.rPasswordText.Size = new System.Drawing.Size(246, 28);
            this.rPasswordText.TabIndex = 1;
            this.rPasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rPasswordText.TextChanged += new System.EventHandler(this.rSurnameText_TextChanged);
            // 
            // rUsernameText
            // 
            this.rUsernameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.rUsernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rUsernameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rUsernameText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rUsernameText.Location = new System.Drawing.Point(164, 195);
            this.rUsernameText.Name = "rUsernameText";
            this.rUsernameText.Size = new System.Drawing.Size(246, 28);
            this.rUsernameText.TabIndex = 0;
            this.rUsernameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(35, 404);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Verification:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(40, 435);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 1);
            this.panel4.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(35, 333);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Password:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(40, 365);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 1);
            this.panel3.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(35, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "Password:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(40, 295);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 1);
            this.panel2.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(35, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 34;
            this.label2.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(40, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 1);
            this.panel1.TabIndex = 32;
            // 
            // rPassword1Text
            // 
            this.rPassword1Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.rPassword1Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rPassword1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.rPassword1Text.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rPassword1Text.Location = new System.Drawing.Point(164, 332);
            this.rPassword1Text.Name = "rPassword1Text";
            this.rPassword1Text.PasswordChar = '*';
            this.rPassword1Text.Size = new System.Drawing.Size(246, 28);
            this.rPassword1Text.TabIndex = 2;
            this.rPassword1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // verificationCode1
            // 
            this.verificationCode1.AutoSize = true;
            this.verificationCode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verificationCode1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.verificationCode1.Location = new System.Drawing.Point(311, 438);
            this.verificationCode1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.verificationCode1.Name = "verificationCode1";
            this.verificationCode1.Size = new System.Drawing.Size(99, 29);
            this.verificationCode1.TabIndex = 50;
            this.verificationCode1.Text = "ABCDE";
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.registerBtn.FlatAppearance.BorderSize = 0;
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(40, 505);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(370, 50);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "REGISTER";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // warningUsername
            // 
            this.warningUsername.AutoSize = true;
            this.warningUsername.BackColor = System.Drawing.Color.MidnightBlue;
            this.warningUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warningUsername.ForeColor = System.Drawing.Color.White;
            this.warningUsername.Location = new System.Drawing.Point(179, 228);
            this.warningUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warningUsername.Name = "warningUsername";
            this.warningUsername.Size = new System.Drawing.Size(0, 16);
            this.warningUsername.TabIndex = 52;
            // 
            // warningPassword
            // 
            this.warningPassword.AutoSize = true;
            this.warningPassword.BackColor = System.Drawing.Color.MidnightBlue;
            this.warningPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warningPassword.ForeColor = System.Drawing.Color.White;
            this.warningPassword.Location = new System.Drawing.Point(198, 368);
            this.warningPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warningPassword.Name = "warningPassword";
            this.warningPassword.Size = new System.Drawing.Size(0, 16);
            this.warningPassword.TabIndex = 53;
            // 
            // warning2
            // 
            this.warning2.AutoSize = true;
            this.warning2.BackColor = System.Drawing.Color.Transparent;
            this.warning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warning2.ForeColor = System.Drawing.Color.White;
            this.warning2.Location = new System.Drawing.Point(111, 555);
            this.warning2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warning2.Name = "warning2";
            this.warning2.Size = new System.Drawing.Size(0, 24);
            this.warning2.TabIndex = 54;
            // 
            // warningVerification
            // 
            this.warningVerification.AutoSize = true;
            this.warningVerification.BackColor = System.Drawing.Color.Transparent;
            this.warningVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warningVerification.ForeColor = System.Drawing.Color.White;
            this.warningVerification.Location = new System.Drawing.Point(37, 438);
            this.warningVerification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.warningVerification.Name = "warningVerification";
            this.warningVerification.Size = new System.Drawing.Size(0, 16);
            this.warningVerification.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(402, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(363, -10);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 44);
            this.label7.TabIndex = 57;
            this.label7.Text = "_";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // RegisterPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.warningVerification);
            this.Controls.Add(this.warning2);
            this.Controls.Add(this.warningPassword);
            this.Controls.Add(this.warningUsername);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.verificationCode1);
            this.Controls.Add(this.rPassword1Text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rVerificationText);
            this.Controls.Add(this.rPasswordText);
            this.Controls.Add(this.rUsernameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RegisterPage1";
            this.Size = new System.Drawing.Size(440, 760);
            this.Load += new System.EventHandler(this.RegisterPage1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rVerificationText;
        private System.Windows.Forms.TextBox rPasswordText;
        private System.Windows.Forms.TextBox rUsernameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox rPassword1Text;
        private System.Windows.Forms.Label verificationCode1;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label warningUsername;
        private System.Windows.Forms.Label warningPassword;
        private System.Windows.Forms.Label warning2;
        private System.Windows.Forms.Label warningVerification;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
