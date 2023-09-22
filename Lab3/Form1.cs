using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format($"Hôm nay là ngày {DateTime.Now.ToString("dd/MM/yyyy")}, Bây giờ là {DateTime.Now.ToString("hh:mm:ss tt")}");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Mp4 File |*.mp4";
            if(openFileDialog.ShowDialog() == DialogResult.OK ) {
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
            }
        }
    }
}
