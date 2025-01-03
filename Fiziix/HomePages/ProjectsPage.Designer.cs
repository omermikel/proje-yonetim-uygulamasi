namespace Fiziix.HomePages
{
    partial class ProjectsPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.projectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.members = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enter = new System.Windows.Forms.DataGridViewButtonColumn();
            this.leave = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectID,
            this.image,
            this.projectName,
            this.projectDescription,
            this.manager,
            this.members,
            this.enter,
            this.leave});
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 629);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // projectID
            // 
            this.projectID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.projectID.FillWeight = 32.0933F;
            this.projectID.HeaderText = "Project ID";
            this.projectID.Name = "projectID";
            this.projectID.ReadOnly = true;
            this.projectID.Width = 73;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.image.FillWeight = 236.6197F;
            this.image.HeaderText = "Image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 42;
            // 
            // projectName
            // 
            this.projectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.projectName.FillWeight = 101.7607F;
            this.projectName.HeaderText = "Project Name";
            this.projectName.Name = "projectName";
            this.projectName.ReadOnly = true;
            this.projectName.Width = 88;
            // 
            // projectDescription
            // 
            this.projectDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.projectDescription.FillWeight = 204.9177F;
            this.projectDescription.HeaderText = "Project Description";
            this.projectDescription.Name = "projectDescription";
            this.projectDescription.ReadOnly = true;
            // 
            // manager
            // 
            this.manager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.manager.FillWeight = 83.7972F;
            this.manager.HeaderText = "Manager";
            this.manager.Name = "manager";
            this.manager.ReadOnly = true;
            this.manager.Width = 74;
            // 
            // members
            // 
            this.members.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.members.FillWeight = 85.83412F;
            this.members.HeaderText = "Number of Members";
            this.members.Name = "members";
            this.members.ReadOnly = true;
            this.members.Width = 116;
            // 
            // enter
            // 
            this.enter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.enter.FillWeight = 34.67287F;
            this.enter.HeaderText = "Enter";
            this.enter.Name = "enter";
            this.enter.ReadOnly = true;
            this.enter.Width = 38;
            // 
            // leave
            // 
            this.leave.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.leave.FillWeight = 20.30457F;
            this.leave.HeaderText = "Leave";
            this.leave.Name = "leave";
            this.leave.ReadOnly = true;
            this.leave.Width = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 1);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1166, 109);
            this.label1.TabIndex = 3;
            this.label1.Text = "Projects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProjectsPage";
            this.Size = new System.Drawing.Size(1166, 741);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectID;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn members;
        private System.Windows.Forms.DataGridViewButtonColumn enter;
        private System.Windows.Forms.DataGridViewButtonColumn leave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
