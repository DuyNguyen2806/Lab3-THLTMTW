namespace Lab3_03
{
    partial class frmQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSV));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.sbtnThemmoi = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ttxtTimkiem = new System.Windows.Forms.ToolStripTextBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMớiToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.thêmMớiToolStripMenuItem.Text = "Thêm mới";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.sbtnThemmoi_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbtnThemmoi,
            this.toolStripLabel1,
            this.ttxtTimkiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 34);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // sbtnThemmoi
            // 
            this.sbtnThemmoi.Image = ((System.Drawing.Image)(resources.GetObject("sbtnThemmoi.Image")));
            this.sbtnThemmoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sbtnThemmoi.Name = "sbtnThemmoi";
            this.sbtnThemmoi.Size = new System.Drawing.Size(120, 29);
            this.sbtnThemmoi.Text = "Thêm mới";
            this.sbtnThemmoi.Click += new System.EventHandler(this.sbtnThemmoi_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(84, 29);
            this.toolStripLabel1.Text = "Tìm kiếm";
            // 
            // ttxtTimkiem
            // 
            this.ttxtTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ttxtTimkiem.Name = "ttxtTimkiem";
            this.ttxtTimkiem.Size = new System.Drawing.Size(100, 34);
            this.ttxtTimkiem.TextChanged += new System.EventHandler(this.ttxtTimkiem_TextChanged);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.AllowUserToResizeColumns = false;
            this.dgvSinhVien.AllowUserToResizeRows = false;
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.tensv,
            this.khoa,
            this.diem});
            this.dgvSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 125);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 62;
            this.dgvSinhVien.RowTemplate.Height = 28;
            this.dgvSinhVien.Size = new System.Drawing.Size(800, 325);
            this.dgvSinhVien.TabIndex = 2;
            // 
            // mssv
            // 
            this.mssv.HeaderText = "Mã sinh viên";
            this.mssv.MinimumWidth = 8;
            this.mssv.Name = "mssv";
            this.mssv.ReadOnly = true;
            // 
            // tensv
            // 
            this.tensv.HeaderText = "Tên sinh viên";
            this.tensv.MinimumWidth = 8;
            this.tensv.Name = "tensv";
            this.tensv.ReadOnly = true;
            // 
            // khoa
            // 
            this.khoa.HeaderText = "Khoa";
            this.khoa.MinimumWidth = 8;
            this.khoa.Name = "khoa";
            this.khoa.ReadOnly = true;
            // 
            // diem
            // 
            this.diem.HeaderText = "Điểm TB";
            this.diem.MinimumWidth = 8;
            this.diem.Name = "diem";
            this.diem.ReadOnly = true;
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQLSV";
            this.Text = "Quản lý sinh viên";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton sbtnThemmoi;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ttxtTimkiem;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensv;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn diem;
    }
}

