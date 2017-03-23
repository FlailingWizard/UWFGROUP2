using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace LibrarianApplication
{
    public partial class MainWindow : Form
    {

        public enum VIEW_MODE
        {
            COLLECTION_VIEW, DOCUMENT_VIEW
        }

        private VIEW_MODE mode;

        public VIEW_MODE Mode
        {
            get
            {
                return mode;
            }

            set
            {
                mode = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

            this.mode = VIEW_MODE.COLLECTION_VIEW;

        }


        private void addDocumentClicked(object sender, EventArgs e)
        {
            //Add a new document to the selected folder
        }

        private void addNewCollectionClicked(object sender, EventArgs e)
        {
            // Add a new folder to the application
        }

        private void listCollections_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            resizeLists();
            
        }

        private void resizeLists()
        {
            Debug.Print("Resize");
            listCollections.Top = listCollections.Left = 0;
            listCollections.Width = this.Width;
            listCollections.Height = this.Height;
        }



    }
}
