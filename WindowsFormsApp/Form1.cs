using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnSelectFile2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string content = File.ReadAllText(openFileDialog1.FileName);
            File.AppendAllText(saveFileDialog1.FileName, content);
            content = File.ReadAllText(openFileDialog2.FileName);
            File.AppendAllText(saveFileDialog1.FileName, content);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            var path = folderBrowserDialog1.SelectedPath;
            foreach (var fileName in Directory.GetFiles(path, "*.txt"))
            {
                comboBox1.Items.Add(fileName);
            }
        }
    }
}
