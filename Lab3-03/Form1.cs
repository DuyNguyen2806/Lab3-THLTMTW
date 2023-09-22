using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_03
{
    public partial class frmQLSV : Form
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();
        private class SinhVien
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string Khoa { get; set; }
            public double Diem { get; set; }

            public SinhVien(string mssv, string hoTen,string khoa, double diem)
            {
                MSSV = mssv;
                HoTen = hoTen;
                Khoa = khoa;
                Diem = diem;
            }
        }
        public frmQLSV()
        {
            InitializeComponent();
            ttxtTimkiem.TextChanged += ttxtTimkiem_TextChanged;
        }

        private void sbtnThemmoi_Click(object sender, EventArgs e)
        {
            frmThemSV frmThemSV = new frmThemSV();
            DialogResult rs =  frmThemSV.ShowDialog();
            if(rs == DialogResult.OK)
            {
                string masv = frmThemSV.Masv;
                string tensv = frmThemSV.Tensv;
                string khoa = frmThemSV.Khoa;
                double diem = frmThemSV.Diem;
                if (!KiemTra(masv))
                {
                    danhSachSinhVien.Add(new SinhVien(masv,tensv, khoa, diem));
                    dgvSinhVien.Rows.Add(masv, tensv, khoa, diem);

                }
                else
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool KiemTra(string masv)
        {
            foreach (SinhVien sv in danhSachSinhVien)
            {
                if (sv.MSSV.Equals(masv))
                {
                    return true;
                }
            }
            return false;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void ttxtTimkiem_TextChanged(object sender, EventArgs e)
        {
            string key = ttxtTimkiem.Text.ToLower();
            dgvSinhVien.Rows.Clear();
            foreach (var sv in danhSachSinhVien)
            {
                if (sv.HoTen.ToLower().Contains(key))
                {
                    dgvSinhVien.Rows.Add(sv.MSSV, sv.HoTen, sv.Khoa, sv.Diem);
                }
            }
        }
    }
}
