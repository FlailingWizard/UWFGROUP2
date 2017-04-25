using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace LibrarianApplication
{
    public partial class AddCollectionWindow : Form
    {

        public string templateFileName;
        public string collectionName;
        private MainWindow parentForm;

        public AddCollectionWindow(MainWindow parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            toggleButtons();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void AddCollectionWindow_Load(object sender, EventArgs e)
        {

        }

        private void toggleButtons()
        {
            if (txtCollectionName.Text.Length > 0 && templateFileName != null)
            {
                btnCreate.Enabled = true;
            } else
            {
                btnCreate.Enabled = false;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();

            open.CheckFileExists = true;
            open.CheckPathExists = true;
            open.InitialDirectory = Directory.GetCurrentDirectory();
            open.Multiselect = false;
            DialogResult result = open.ShowDialog();

            if (result != DialogResult.Cancel)
            {
                label2.Text = templateFileName = open.FileName;

            }
            toggleButtons();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            parentForm.newCollection(templateFileName, collectionName);
            this.Close();
        }

        private void txtCollectionName_TextChanged(object sender, EventArgs e)
        {
            collectionName = txtCollectionName.Text;
            toggleButtons();
        }

        private void AddCollectionWindow_DragDrop(object sender, DragEventArgs e)
        {
            List<string> files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));
            label2.Text = templateFileName = files[0];
            toggleButtons();
        }

        private void AddCollectionWindow_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
