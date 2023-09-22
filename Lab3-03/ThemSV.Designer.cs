namespace Lab3_03
{
    partial class frmThemSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMasv = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm TB";
            // 
            // txtMasv
            // 
            this.txtMasv.Location = new System.Drawing.Point(307, 22);
            this.txtMasv.Name = "txtMasv";
            this.txtMasv.Size = new System.Drawing.Size(285, 26);
            this.txtMasv.TabIndex = 4;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(307, 91);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(285, 26);
            this.txtTen.TabIndex = 5;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(307, 231);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(285, 26);
            this.txtDiem.TabIndex = 6;
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Ngôn ngữ Anh",
            "Quản trị kinh doanh"});
            this.cbKhoa.Location = new System.Drawing.Point(307, 160);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(285, 28);
            this.cbKhoa.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(344, 308);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 42);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(489, 308);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 42);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.txtDiem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMasv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmThemSV";
            this.Text = "Thêm sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMasv;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
    }
}