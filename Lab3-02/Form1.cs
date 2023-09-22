using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_02
{
    public partial class Form1 : Form
    {
        public string path;
        public Form1()
        {
            InitializeComponent();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.ShowApply = true;
            fontDialog.ShowEffects = true;
            fontDialog.ShowHelp = true;
            if(fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                richText.ForeColor = fontDialog.Color;
                richText.Font = fontDialog.Font;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveText();



        }

        private void cbFont_Click(object sender, EventArgs e)
        {
            
        }
        private void SaveText()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();   
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "rtf";
            saveFileDialog.Filter = "RichText files|*.rtf";
            saveFileDialog.RestoreDirectory = true;
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                richText.SaveFile(saveFileDialog.FileName,RichTextBoxStreamType.PlainText);
                MessageBox.Show("Lưu file thành công");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewText();
        }

        private void NewText()
        {
            foreach (FontFamily font in new InstalledFontCollection().Families)
            {
                richText.Clear();
                richText.Font = new Font("Tahoma", 14);
                cbFont.Items.Add(font.Name);
                cbFont.SelectedItem = "Tahoma";
                tcbSize.SelectedItem = "14";
                path = "";
                

            }
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
            tcbSize.SelectedIndex = 0;
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text file| *.txt|RichText files| *.rtf";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                richText.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                path = ofd.FileName;
            }
        }

        private void tbtnNew_Click(object sender, EventArgs e)
        {
            NewText();
        }

        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewText();

        }

        private void richText_TextChanged(object sender, EventArgs e)
        {

        }

        private void lưuNộiDungVănBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveText();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont.Bold)
            {
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
            {
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style | FontStyle.Bold);
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont.Italic)
            {
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style & ~FontStyle.Italic);
            }
            else
            {
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style | FontStyle.Italic);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richText.SelectionFont.Underline)
            {
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style & ~FontStyle.Underline);
            }
            else
            {
                richText.SelectionFont = new Font(richText.SelectionFont, richText.SelectionFont.Style | FontStyle.Underline);
            }
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            richText.SelectionFont = new Font(cbFont.Text, float.Parse(tcbSize.Text));
        }

        private void tcbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            richText.SelectionFont = new Font(cbFont.Text, float.Parse(tcbSize.Text));
        }
    }
}
