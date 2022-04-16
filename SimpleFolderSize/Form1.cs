using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleFolderSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                long size = GetDirectorySize(new DirectoryInfo(folderBrowserDialog1.SelectedPath));
                MessageBox.Show(size.ToString());
            }
        }

        private long GetDirectorySize(DirectoryInfo directoryInfo)
        {
            long size = 0;
            FileInfo[] allFiles = directoryInfo.GetFiles();
            for(int i = 0; i < allFiles.Length;i++)
            {
                size += allFiles[i].Length;
                    
            }
            return size;
        }
    }
}
