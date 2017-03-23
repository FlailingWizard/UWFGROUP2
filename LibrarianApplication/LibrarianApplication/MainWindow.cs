using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace LibrarianApplication
{
    public partial class MainWindow : Form
    {

        public enum VIEW_MODE
        {
            COLLECTION_VIEW, DOCUMENT_VIEW
        }
        public enum ICONS
        {
            // Note: The order here must be the same as the order in which these are loaded to
            // the imagelist in loadIcons() method.
            COLLECTION_ICON, DOCUMENT_ICON
        }

        private const string COLLECTION_ICON_FILENAME = "../../collectionIcon.ico";
        private const string DOCUMENT_ICON_FILENAME = "../../documentIcon.ico";

        // fields
        private VIEW_MODE mode;
        private ImageList icons;

        // accessors
        public VIEW_MODE Mode
        {
            get
            {
                return mode;
            }

            set
            {
                setMode(mode);
                mode = value;
            }
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        // methods belonging to controls
        // NOTE: don't delete w/out removing reference from Designer window first
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // set default view
            this.Mode = VIEW_MODE.COLLECTION_VIEW;

            // instantiate and load icons
            icons = loadIcons();

            // add the imagelist to both listViews
            listCollections.LargeImageList = listDocuments.LargeImageList = icons;

        }

        private void addDocumentClicked(object sender, EventArgs e)
        {
            /*
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            */
        }

        private void addNewCollectionClicked(object sender, EventArgs e)
        {
            // Add a new folder to the application
        }

        private void mainWindowLayout_Layout(object sender, LayoutEventArgs e)
        {
            // resize the list controls
            listCollections.Bounds = listDocuments.Bounds = mainWindowLayout.ClientRectangle;

        }

        private void MainWindow_Layout(object sender, LayoutEventArgs e)
        {

        }

        // helper methods
        private void setMode(VIEW_MODE viewMode)
        {

            this.mode = viewMode;
            if (viewMode == VIEW_MODE.COLLECTION_VIEW)
            {
                listCollections.Visible = true;
                listDocuments.Visible = false;
            }
            else
            {
                listCollections.Visible = false;
                listDocuments.Visible = true;
            }

        }

        private ImageList loadIcons()
        {
            ImageList list = new ImageList();
            // possible exceptions are not caught because we want this to fail if no icon files
            list.Images.Add(Bitmap.FromFile(COLLECTION_ICON_FILENAME));
            list.Images.Add(Bitmap.FromFile(DOCUMENT_ICON_FILENAME));
            return list;
        }



    }
}
