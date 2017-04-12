﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibrarianApplication
{

    /// <summary>
    /// This class implements the main user window for the application.
    /// 
    /// The window has two modes of operation, which can be set using the
    /// setMode() method. 
    /// 
    /// </summary>
    public partial class MainWindow : Form
    {

        public enum ViewMode
        {
            CollectionView, DocumentView
        }

        public enum Icons
        {
            // Note: Do not change the order of these
            CollectionIcon = 0, DocumentIcon = 1
        }

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

        // constructor
        public MainWindow()
        {
            InitializeComponent();
        }

        // Helper methods

        private void setMode(ViewMode viewMode)
        {

            this.mode = viewMode;

            backButton.Enabled = (mode == ViewMode.DocumentView);
            listCollections.Visible = (mode == ViewMode.CollectionView);
            listDocuments.Visible = (mode == ViewMode.DocumentView);

            this.Text = $"{Application.ProductName} - " + ((mode == ViewMode.CollectionView) ? "Collection View" : "DocumentView");

        }

        private ImageList loadIcons()
        {
            ImageList list = new ImageList();
            list.Images.Add(Properties.Resources.FolderOpen);
            list.Images.Add(Properties.Resources.Document);
            return list;
        }

        private void debug_AddThingsToList(int numberOfThings)
        {
            // for debugging only:  add items to the current listview
            Debug.Print($"Adding {numberOfThings.ToString()} items to the active list");
            for (int i = 0; i < numberOfThings; i++)
            {
                ListViewItem newItem = new ListViewItem();
                newItem.ImageIndex = ((mode == ViewMode.CollectionView) ?
                    (int)Icons.CollectionIcon : (int)Icons.DocumentIcon);
                newItem.Text = ((mode == ViewMode.CollectionView) ?
                    "Collection " : "Document " + i.ToString());
                if (mode == ViewMode.CollectionView)
                {
                    listCollections.Items.Add(newItem);
                }
                else
                {
                    listDocuments.Items.Add(newItem);
                }
            }

        }

        private void startExternalEditor(String fileName)
        {
            // start the external editor with the specified file open.
            ProcessStartInfo start = new ProcessStartInfo();
            start.Arguments = fileName;
            start.FileName = "notepad.exe";  // no idea if this works
            start.WindowStyle = ProcessWindowStyle.Normal;

            // start async
            using (Process proc = Process.Start(start))
            {
                // nothing goes here
            }

        }

        // Form control methods
        /* NOTE:
         * Don't delete any of these if they have references, otherwise you crash the form
         * designer.  Also, if you change the name of a control on the form, make sure you
         * re-associate the method with the control afterwards.
        */
        private void mainLayout_Layout(object sender, LayoutEventArgs e)
        {
            // resize the list controls
            listCollections.Bounds = listDocuments.Bounds = mainLayout.ClientRectangle;
        }

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
            setMode(ViewMode.DocumentView);
        }

        private void listDocuments_DoubleClick(object sender, EventArgs e)
        {
   
            // startExternalEditor(however we get filename of document);
        }

        private void addNewCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Add a new folder to the application
            // show the AddCollection form
            debug_AddThingsToList(1); // this is for testing
        }

        private void addDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debug_AddThingsToList(1);

            OpenFileDialog fileDialog = new OpenFileDialog();

            int size = -1;
            DialogResult result = fileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fileDialog.FileName;
                try
                {
                    /*  Zack:
                     *  if you are just testing to see if the file exists, a better way is
                     *  
                     *  boolean isFileExisting = System.IO.File.Exists(file);
                     *  
                     *  which you can use as a test like:
                     *  
                     *  if (System.IO.File.Exists(file)) {
                     *      // do something
                     *  }
                     *  
                     *  if the file doesn't exist it won't throw an exception you have to catch
                     *  
                    */
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

        private void backButton_Click(object sender, EventArgs e)
        {
            // return to the collection view
            setMode(ViewMode.CollectionView);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // enable search button only if text in textbox
            searchButton.Enabled = (searchBox.Text.Length != 0);
        }
    }


}
