using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FolderGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadFolderIcons();
            lstPreview.View = View.LargeIcon;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void LoadFolderIcons()
        {
            string folderIconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "folder-icon.png");

            if (File.Exists(folderIconPath))
            {
                var image = Image.FromFile(folderIconPath);
                imgList.Images.Clear();
                imgList.Images.Add(image);
                lstPreview.LargeImageList = imgList;
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    txtTargetFolder.Text = folderBrowser.SelectedPath;
                    UpdatePreview();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string targetFolder = txtTargetFolder.Text.Trim();
            string baseFolderName = txtBaseFolderName.Text.Trim();

            if (string.IsNullOrEmpty(targetFolder) || string.IsNullOrEmpty(baseFolderName))
            {
                MessageBox.Show("Please specify both the target directory and base folder name.");
                return;
            }

            if (!int.TryParse(txtNumFolders.Text.Trim(), out int numFolders) || numFolders <= 0)
            {
                MessageBox.Show("Please enter a valid number of folders.");
                return;
            }

            for (int i = 1; i <= numFolders; i++)
            {
                string folderPath = Path.Combine(targetFolder, $"{baseFolderName} {i}");
                Directory.CreateDirectory(folderPath);
            }

            MessageBox.Show($"Folders from '{baseFolderName} 1' to '{baseFolderName} {numFolders}' have been created.");
            UpdatePreview();
        }

        private void txtBaseFolderName_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void txtNumFolders_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void UpdatePreview()
        {
            lstPreview.Items.Clear();

            string baseFolderName = txtBaseFolderName.Text.Trim();
            string numFoldersText = txtNumFolders.Text.Trim();

            if (string.IsNullOrEmpty(baseFolderName))
            {
                return;
            }

            if (int.TryParse(numFoldersText, out int numFolders) && numFolders > 0)
            {
                lblFolderCount.Text = $"Folders: {numFolders}";
                for (int i = 1; i <= numFolders; i++)
                {
                    lstPreview.Items.Add(new ListViewItem($"{baseFolderName} {i}", 0));
                }
            }
            else
            {
                lblFolderCount.Text = "Folders: 0";
                lstPreview.Items.Add(new ListViewItem(baseFolderName, 0));
            }
        }
    }
}
