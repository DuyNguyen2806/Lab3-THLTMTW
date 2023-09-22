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
    public partial class frmThemSV : Form
    {
        private double diem;
        private string masv;
        private string tensv;
        private string khoa;

        public frmThemSV()
        {
            InitializeComponent();
            cbKhoa.SelectedIndex = 0;
        }

        public frmThemSV(string masv, string tensv, string khoa, double diem)
        {
            this.masv = masv;
            this.tensv = tensv;
            this.khoa = khoa;
            this.diem = diem;
        }

        public string Masv { get => masv; set => masv = value; }
        public string Tensv { get => tensv; set => tensv = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public double Diem { get => diem; set => diem = value; }

        private void btnThem_Click(object sender, EventArgs e)
        {
            masv = txtMasv.Text;
            tensv = txtTen.Text;
            khoa = cbKhoa.Text;
            if (double.TryParse(txtDiem.Text, out double diem))
            {
                if (diem >= 0 && diem <= 10)
                {
                    Diem = diem;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Điểm phải là số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }
    }
}
