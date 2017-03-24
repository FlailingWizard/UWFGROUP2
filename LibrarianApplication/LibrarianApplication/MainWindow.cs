using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace LibrarianApplication
{
    public partial class MainWindow : Form
    {

        public enum ViewMode
        {
            CollectionView, DocumentView
        }

        public enum Icons
        {
            // Note: The order here must match the order in loadIcons()
            CollectionIcon = 0, DocumentIcon = 1
        }

        // these filepaths map to the project directory.
        private const string COLLECTION_ICON_FILENAME = "../../collectionIcon.ico";
        private const string DOCUMENT_ICON_FILENAME = "../../documentIcon.ico";

        // fields
        private ViewMode mode;
        private ImageList icons;
        
        
        // accessors
        public ViewMode Mode
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
            this.Mode = ViewMode.CollectionView;

            // instantiate and load icons
            icons = loadIcons();

            // add the imagelist to both listViews
            listCollections.LargeImageList = listDocuments.LargeImageList = icons;

        }

        private void listCollections_DoubleClick(object sender, EventArgs e)
        {
            // switch to document view for selected document

            if (listCollections.SelectedItems.Count > 0)
            {
                setMode(ViewMode.DocumentView);
            }
                         
        }
        private void listDocuments_DoubleClick(object sender, EventArgs e)
        {
            // open the selected document in an external editor
            if (listDocuments.SelectedItems.Count > 0)
            {
                // startExternalEditor(however we get filename of document);
            }

        }

        private void addDocumentClicked(object sender, EventArgs e)
        {
<<<<<<< HEAD
            debug_AddThingsToList(1);

            /*
=======
            OpenFileDialog fileDialog = new OpenFileDialog();

>>>>>>> 8fd6ef12f0c2554596a6faac9f341a11ec426af5
            int size = -1;
            DialogResult result = fileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fileDialog.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            
           // Call method to send to add document here
           // The file variable holds the file path of the document the user wants to import
           
        }

        private void addNewCollectionClicked(object sender, EventArgs e)
        {
            // Add a new folder to the application
            // show the AddCollection form
            debug_AddThingsToList(1);
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
        private void setMode(ViewMode viewMode)
        {

            this.mode = viewMode;
            if (viewMode == ViewMode.CollectionView)
            {
                listCollections.Visible = true;
                listDocuments.Visible = false;
            }
            else
            {
                listCollections.Visible = false;
                listDocuments.Visible = true;
            }

            this.Text = $"{Application.ProductName} - " + ((mode == ViewMode.CollectionView) ? "Collection View" : "DocumentView");

        }

        private ImageList loadIcons()
        {
            ImageList list = new ImageList();
            /* 
             * Possible exceptions are not caught because we want this to fail if no icon files.
             * A good improvement to this is to catch the exception and present a FileDialog
             * for the user to specify where they are. 
            */
            list.Images.Add(Bitmap.FromFile(COLLECTION_ICON_FILENAME));
            list.Images.Add(Bitmap.FromFile(DOCUMENT_ICON_FILENAME));
            return list;
        }

        private void debug_AddThingsToList(int numberOfThings)
        {
            // for debugging:  add items to the current listview
            Debug.Print($"Adding {numberOfThings.ToString()} items to the active list");
            for (int i = 0; i < numberOfThings; i++)
            {
                ListViewItem newItem = new ListViewItem();
                newItem.ImageIndex = ((mode == ViewMode.CollectionView) ?
                    (int)Icons.CollectionIcon : (int)Icons.DocumentIcon);
                newItem.Text = ((mode == ViewMode.CollectionView) ?
                    "Collection " : "Document " + i.ToString());
                listCollections.Items.Add(newItem);
            }

        }

        private void startExternalEditor(String fileName)
        {
            // start the external editor with the specified file open.
            ProcessStartInfo start = new ProcessStartInfo();
            start.Arguments = fileName;
            start.FileName = "notepad.exe";  // no idea if this works
            start.WindowStyle = ProcessWindowStyle.Normal;

            // start process asynch (don't wait for it)
            using (Process proc = Process.Start(start))
            {
                
            }

        }

        private void listDocuments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }


}
