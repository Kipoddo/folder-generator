namespace FolderGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtTargetFolder;
        private System.Windows.Forms.TextBox txtBaseFolderName;
        private System.Windows.Forms.TextBox txtNumFolders;
        private System.Windows.Forms.Label lblTargetFolder;
        private System.Windows.Forms.Label lblBaseFolderName;
        private System.Windows.Forms.Label lblNumFolders;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.ListView lstPreview;
        private System.Windows.Forms.Label lblFolderCount;
        private System.Windows.Forms.ImageList imgList;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtTargetFolder = new System.Windows.Forms.TextBox();
            this.txtBaseFolderName = new System.Windows.Forms.TextBox();
            this.txtNumFolders = new System.Windows.Forms.TextBox();
            this.lblTargetFolder = new System.Windows.Forms.Label();
            this.lblBaseFolderName = new System.Windows.Forms.Label();
            this.lblNumFolders = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lstPreview = new System.Windows.Forms.ListView();
            this.lblFolderCount = new System.Windows.Forms.Label();
            this.imgList = new System.Windows.Forms.ImageList(this.components);

            this.SuspendLayout();

            // 
            // lblTargetFolder
            // 
            this.lblTargetFolder.AutoSize = true;
            this.lblTargetFolder.Location = new System.Drawing.Point(12, 15);
            this.lblTargetFolder.Name = "lblTargetFolder";
            this.lblTargetFolder.Size = new System.Drawing.Size(89, 15);
            this.lblTargetFolder.TabIndex = 0;
            this.lblTargetFolder.Text = "Target Directory:";
            
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.Location = new System.Drawing.Point(12, 33);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.Size = new System.Drawing.Size(350, 23);
            this.txtTargetFolder.TabIndex = 1;
            this.txtTargetFolder.ReadOnly = true;

            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(368, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 27);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            this.btnBrowse.Height = this.txtTargetFolder.Height;

            // 
            // lblBaseFolderName
            // 
            this.lblBaseFolderName.AutoSize = true;
            this.lblBaseFolderName.Location = new System.Drawing.Point(12, 65);
            this.lblBaseFolderName.Name = "lblBaseFolderName";
            this.lblBaseFolderName.Size = new System.Drawing.Size(113, 15);
            this.lblBaseFolderName.TabIndex = 3;
            this.lblBaseFolderName.Text = "Base Folder Name:";
            
            // 
            // txtBaseFolderName
            // 
            this.txtBaseFolderName.Location = new System.Drawing.Point(12, 83);
            this.txtBaseFolderName.Name = "txtBaseFolderName";
            this.txtBaseFolderName.Size = new System.Drawing.Size(456, 23);
            this.txtBaseFolderName.TabIndex = 4;
            this.txtBaseFolderName.TextChanged += new System.EventHandler(this.txtBaseFolderName_TextChanged);

            // 
            // lblNumFolders
            // 
            this.lblNumFolders.AutoSize = true;
            this.lblNumFolders.Location = new System.Drawing.Point(12, 115);
            this.lblNumFolders.Name = "lblNumFolders";
            this.lblNumFolders.Size = new System.Drawing.Size(119, 15);
            this.lblNumFolders.TabIndex = 5;
            this.lblNumFolders.Text = "Number of Folders:";
            
            // 
            // txtNumFolders
            // 
            this.txtNumFolders.Location = new System.Drawing.Point(12, 133);
            this.txtNumFolders.Name = "txtNumFolders";
            this.txtNumFolders.Size = new System.Drawing.Size(100, 23);
            this.txtNumFolders.TabIndex = 6;
            this.txtNumFolders.TextChanged += new System.EventHandler(this.txtNumFolders_TextChanged);

            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(368, 373);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 27);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(12, 165);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(51, 15);
            this.lblPreview.TabIndex = 8;
            this.lblPreview.Text = "Preview:";
            
            // 
            // lstPreview
            // 
            this.lstPreview.Location = new System.Drawing.Point(12, 183);
            this.lstPreview.Name = "lstPreview";
            this.lstPreview.Size = new System.Drawing.Size(456, 184);
            this.lstPreview.TabIndex = 9;
            this.lstPreview.UseCompatibleStateImageBehavior = false;

            // 
            // lblFolderCount
            // 
            this.lblFolderCount.AutoSize = true;
            this.lblFolderCount.Location = new System.Drawing.Point(12, 370);
            this.lblFolderCount.Name = "lblFolderCount";
            this.lblFolderCount.Size = new System.Drawing.Size(0, 15);
            this.lblFolderCount.TabIndex = 10;

            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageSize = new System.Drawing.Size(32, 32);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(480, 408);
            this.Controls.Add(this.lblFolderCount);
            this.Controls.Add(this.lstPreview);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtNumFolders);
            this.Controls.Add(this.lblNumFolders);
            this.Controls.Add(this.txtBaseFolderName);
            this.Controls.Add(this.lblBaseFolderName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtTargetFolder);
            this.Controls.Add(this.lblTargetFolder);
            this.Name = "Form1";
            this.Text = "Folder Generator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
