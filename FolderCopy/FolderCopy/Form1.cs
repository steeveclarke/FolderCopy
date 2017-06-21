using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblSourceFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnDestinationFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblDestinationFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Check we have selected a source folder
            if(lblSourceFolder.Text.Length == 0)
            {
                MessageBox.Show("You must select a source folder", 
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Check we have selected a destination folder
            if (lblDestinationFolder.Text.Length == 0)
            {
                MessageBox.Show("You must select a destination folder",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Perform the folder copy operation
            FolderCopyClass fcc = new FolderCopyClass();
            fcc.FolderCopy(lblSourceFolder.Text, lblDestinationFolder.Text, true, txtProgress);

            // Notify the user it is done
            MessageBox.Show("Folder copy operation is completed",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

        }
    }
}
