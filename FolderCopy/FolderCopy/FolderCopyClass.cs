using System;
using System.IO;
using System.Windows.Forms;

class FolderCopyClass
{
   
    public void FolderCopy(string sourceDirName, string destDirName, bool copySubDirs, TextBox txtboxFileList = null)
    {
        // Get the subdirectories for the specified directory.
        DirectoryInfo dir = new DirectoryInfo(sourceDirName);

        if (!dir.Exists)
        {
            throw new DirectoryNotFoundException(
                "Source directory does not exist or could not be found: "
                + sourceDirName);
        }

        if(txtboxFileList != null)
        { 
            txtboxFileList.Text += sourceDirName + Environment.NewLine;
            txtboxFileList.Refresh();
        }

        DirectoryInfo[] dirs = dir.GetDirectories();
        // If the destination directory doesn't exist, create it.
        if (!Directory.Exists(destDirName))
        {
            Directory.CreateDirectory(destDirName);
        }

        // Get the files in the directory and copy them to the new location.
        FileInfo[] files = dir.GetFiles();
        foreach (FileInfo file in files)
        {
            string temppath = Path.Combine(destDirName, file.Name);
            if (txtboxFileList != null)
            {
                txtboxFileList.Text += temppath + Environment.NewLine;
                txtboxFileList.Refresh();
            }
            file.CopyTo(temppath, true);
        }

        // If copying subdirectories, copy them and their contents to new location.
        if (copySubDirs)
        {
            foreach (DirectoryInfo subdir in dirs)
            {
                string temppath = Path.Combine(destDirName, subdir.Name);
                FolderCopy(subdir.FullName, temppath, copySubDirs, txtboxFileList);
            }
        }
    }
}
