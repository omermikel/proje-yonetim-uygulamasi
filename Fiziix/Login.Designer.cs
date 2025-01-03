namespace Fiziix
{
    partial class FiziixLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiziixLogin));
            this.loginPage1 = new Fiziix.LoginPage();
            this.registerPage11 = new Fiziix.RegisterPage1();
            this.registerPage1 = new Fiziix.RegisterPage();
            this.ıForgotMyPassword1 = new Fiziix.LoginPages.IForgotMyPassword();
            this.SuspendLayout();
            // 
            // loginPage1
            // 
            this.loginPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.loginPage1.Location = new System.Drawing.Point(-2, 2);
            this.loginPage1.Name = "loginPage1";
            this.loginPage1.Size = new System.Drawing.Size(440, 760);
            this.loginPage1.TabIndex = 0;
            // 
            // registerPage11
            // 
            this.registerPage11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.registerPage11.ForeColor = System.Drawing.Color.White;
            this.registerPage11.Location = new System.Drawing.Point(-2, 2);
            this.registerPage11.Name = "registerPage11";
            this.registerPage11.Size = new System.Drawing.Size(440, 760);
            this.registerPage11.TabIndex = 2;
            // 
            // registerPage1
            // 
            this.registerPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.registerPage1.ForeColor = System.Drawing.Color.White;
            this.registerPage1.Location = new System.Drawing.Point(-2, 2);
            this.registerPage1.Name = "registerPage1";
            this.registerPage1.Size = new System.Drawing.Size(440, 760);
            this.registerPage1.TabIndex = 1;
            // 
            // ıForgotMyPassword1
            // 
            this.ıForgotMyPassword1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ıForgotMyPassword1.Location = new System.Drawing.Point(-2, 2);
            this.ıForgotMyPassword1.Name = "ıForgotMyPassword1";
            this.ıForgotMyPassword1.Size = new System.Drawing.Size(440, 760);
            this.ıForgotMyPassword1.TabIndex = 3;
            // 
            // FiziixLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(440, 760);
            this.Controls.Add(this.loginPage1);
            this.Controls.Add(this.registerPage1);
            this.Controls.Add(this.ıForgotMyPassword1);
            this.Controls.Add(this.registerPage11);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FiziixLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LoginPage loginPage1;
        private RegisterPage registerPage1;
        private RegisterPage1 registerPage11;
        private LoginPages.IForgotMyPassword ıForgotMyPassword1;
    }
}