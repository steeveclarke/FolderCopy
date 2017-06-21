namespace FolderCopy
{
    partial class Form1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.lblDestinationFolder = new System.Windows.Forms.Label();
            this.btnDestinationFolder = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtProgress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(343, 12);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(146, 23);
            this.btnSelectSource.TabIndex = 0;
            this.btnSelectSource.Text = "Select Source Folder";
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSourceFolder.Location = new System.Drawing.Point(12, 12);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(310, 23);
            this.lblSourceFolder.TabIndex = 1;
            // 
            // lblDestinationFolder
            // 
            this.lblDestinationFolder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblDestinationFolder.Location = new System.Drawing.Point(12, 50);
            this.lblDestinationFolder.Name = "lblDestinationFolder";
            this.lblDestinationFolder.Size = new System.Drawing.Size(310, 23);
            this.lblDestinationFolder.TabIndex = 3;
            // 
            // btnDestinationFolder
            // 
            this.btnDestinationFolder.Location = new System.Drawing.Point(343, 50);
            this.btnDestinationFolder.Name = "btnDestinationFolder";
            this.btnDestinationFolder.Size = new System.Drawing.Size(146, 23);
            this.btnDestinationFolder.TabIndex = 2;
            this.btnDestinationFolder.Text = "Select Destination Folder";
            this.btnDestinationFolder.Click += new System.EventHandler(this.btnDestinationFolder_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(343, 89);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(146, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtProgress
            // 
            this.txtProgress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtProgress.Location = new System.Drawing.Point(15, 89);
            this.txtProgress.Multiline = true;
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.ReadOnly = true;
            this.txtProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProgress.Size = new System.Drawing.Size(307, 489);
            this.txtProgress.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 590);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblDestinationFolder);
            this.Controls.Add(this.btnDestinationFolder);
            this.Controls.Add(this.lblSourceFolder);
            this.Controls.Add(this.btnSelectSource);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Copy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.Label lblDestinationFolder;
        private System.Windows.Forms.Button btnDestinationFolder;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtProgress;
    }
}

