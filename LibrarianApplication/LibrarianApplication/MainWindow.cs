using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

using NLPImplementations;
using NLPInterfaces;
using DocumentImplementation;
using DocumentInterfaces;
using CollectionImplementation;
using CollectionInterfaces;

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

        // all of our data will live here
        List<IDocumentCollection> collections;
        private int activeCollection;   // the index for the collection to display in documentview

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
            collections = new List<IDocumentCollection>();
        }

        
        // Helper methods

        private string readFile(string targetPath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(targetPath))
                {
                    String text = sr.ReadToEnd();
                    // validate this stuff before we return it
                    if (text == "")
                    {
                        throw new InvalidDataException($"The file {targetPath} is empty.");
                    }
                    return text;
                }
            }
            catch (Exception e)
            {
                throw new IOException($"Unable to open file {targetPath}", e);
            }

        }

        private void setMode(ViewMode viewMode)
        {

            this.mode = viewMode;
            string windowCaption = $"{Application.ProductName} - ";
            backButton.Enabled = (mode == ViewMode.DocumentView);
            listCollections.Visible = (mode == ViewMode.CollectionView);
            listDocuments.Visible = (mode == ViewMode.DocumentView);



            if (viewMode == ViewMode.DocumentView)
            {
                // populate the listbox with documents from the collection
                listDocuments.Clear();
                foreach (IDocument doc in collections[activeCollection].documents)
                {
                    addDocument(doc);
                }
                int docCount = collections[activeCollection].documents.Count;
                windowCaption = windowCaption + $"Viewing documents for collection {collections[activeCollection].CollectionName} ({docCount})";
            }
            else
            {
                // populate the listbox with collections from our list
                listCollections.Clear();
                foreach (IDocumentCollection col in collections)
                {
                    addCollection(col);
                }
                windowCaption = windowCaption + $"Viewing Collections ({collections.Count})";
            }

            // sets the caption on the form
            this.Text = windowCaption;

        }

        private void refreshView()
        {
            this.setMode(mode);
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

        private void startExternalEditor(string fileName)
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

        private void addCollection(IDocumentCollection col)
        {
            ListViewItem newItem = new ListViewItem();
            newItem.ImageIndex = (int)Icons.CollectionIcon;
            newItem.Text = col.CollectionName;
            listCollections.Items.Add(newItem);
        }

        private void addDocument(IDocument doc)
        {
            ListViewItem newItem = new ListViewItem();
            newItem.ImageIndex = (int)Icons.DocumentIcon;
            newItem.Text = doc.Name;
            listDocuments.Items.Add(newItem);
        }

        private void handle_DragDrop(DragEventArgs e)
        {

            List<string> files = new List<string>((string[])e.Data.GetData(DataFormats.FileDrop));

            // the action we take is based on which mode we are in right now
            if (this.mode == ViewMode.CollectionView)
            {
                // assume they want to create a collection from the document

                string message = $"Create a new collection from the document {files[0]}?";
                string caption = "New Collection";

                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // create collection
                    string path = files[0];
                    newCollection(path);
                    
                }

            }
            else
            {
                // assume they want to add this document to a collection
                string message = $"Add the document {files[0]}?";
                string caption = "New Document";

                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // create document
                    string filePath = files[0];
                    string name = Path.GetFileNameWithoutExtension(filePath);
                    IDocument doc = new Document(name, filePath, new FeatureVector(readFile(filePath)));

                    // determine which collection to add it to

                }
            }

            foreach (string filePath in files)
            {
                Console.WriteLine(filePath);
            }
            // end debug

            // figure out how many files

        }

        private void handle_DragEnter(DragEventArgs e)
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


        private void newCollection(string path)
        {

            collections.Add( new DocumentCollection("DemoCollection", new FeatureVector(readFile(path)), Directory.GetCurrentDirectory()));

            refreshView();
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
            // switch to document view for selected collection
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

            //debug_AddThingsToList(1); // this is for testing the UI
        }

        private void addDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //debug_AddThingsToList(1); // this is for testing the UI
            string file;
            string fileDestination = @"C:\Users\Public";
            OpenFileDialog fileDialog = new OpenFileDialog();

            int size = -1;
            DialogResult result = fileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                file = fileDialog.FileName;
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

        private void listCollections_DragDrop(object sender, DragEventArgs e)
        {
            // pass control to helper method
            handle_DragDrop(e);
        }
        private void listCollections_DragEnter(object sender, DragEventArgs e)
        {
            // pass control to the helper method
            handle_DragEnter(e);
        }
        private void listDocuments_DragDrop(object sender, DragEventArgs e)
        {
            // pass control to helper method
            handle_DragDrop(e);
        }
        private void listDocuments_DragEnter(object sender, DragEventArgs e)
        {
            // pass control to the helper method
            handle_DragEnter(e);
        }

        // DEBUGGING MENU OPTIONS

        private void showGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // debugging method.
            // this creates a featurevector and opens the graph window to
            // display a graph.

            // create a random vector for testing
            string testText = $"This is a test of the feature vector, just to see what it does.";
            FeatureVector vector = new FeatureVector(testText);
            //for (int i = 0; i < 10; i++)
            //{
            //    vector.addScalarValue((double)i);
            //}
            vector.process();
            VectorGraph debugWindow = new VectorGraph(vector);
            debugWindow.Visible = true;
        }


        private void showMultiGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // debugging method.
            // this creates a few featurevectors and opens the graph window to
            // display a graph of them.

            // create random vectors for testing
            Random rndNum = new Random();
            List<IFeatureVector> vectors = new List<IFeatureVector>();

            for (int i = 0; i < 4; i++) // for each vector
            {
                IFeatureVector vector = new FeatureVector(null);
                for (int j = 0; j < 10; j++)    // for each scalar
                {
                    vector.addScalarValue(rndNum.NextDouble() * 50);
                }
                vectors.Add(vector);
            }

            VectorGraph debugWindow = new VectorGraph(vectors);
            debugWindow.Visible = true;
        }


    }


}
