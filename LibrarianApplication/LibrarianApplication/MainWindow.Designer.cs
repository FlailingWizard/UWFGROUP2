namespace LibrarianApplication
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMultiGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listCollections = new System.Windows.Forms.ListView();
            this.listDocuments = new System.Windows.Forms.ListView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.searchBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.mainLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCollectionToolStripMenuItem,
            this.addDocumentToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewCollectionToolStripMenuItem
            // 
            this.addNewCollectionToolStripMenuItem.Name = "addNewCollectionToolStripMenuItem";
            this.addNewCollectionToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addNewCollectionToolStripMenuItem.Text = "Add Collection";
            this.addNewCollectionToolStripMenuItem.Click += new System.EventHandler(this.addNewCollectionToolStripMenuItem_Click);
            // 
            // addDocumentToolStripMenuItem
            // 
            this.addDocumentToolStripMenuItem.Name = "addDocumentToolStripMenuItem";
            this.addDocumentToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addDocumentToolStripMenuItem.Text = "Add Document";
            this.addDocumentToolStripMenuItem.Click += new System.EventHandler(this.addDocumentToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGraphToolStripMenuItem,
            this.showMultiGraphToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // showGraphToolStripMenuItem
            // 
            this.showGraphToolStripMenuItem.Name = "showGraphToolStripMenuItem";
            this.showGraphToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.showGraphToolStripMenuItem.Text = "Show Graph";
            this.showGraphToolStripMenuItem.Click += new System.EventHandler(this.showGraphToolStripMenuItem_Click);
            // 
            // showMultiGraphToolStripMenuItem
            // 
            this.showMultiGraphToolStripMenuItem.Name = "showMultiGraphToolStripMenuItem";
            this.showMultiGraphToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.showMultiGraphToolStripMenuItem.Text = "Show MultiGraph";
            this.showMultiGraphToolStripMenuItem.Click += new System.EventHandler(this.showMultiGraphToolStripMenuItem_Click);
            // 
            // listCollections
            // 
            this.listCollections.AllowDrop = true;
            this.listCollections.Location = new System.Drawing.Point(3, 3);
            this.listCollections.MultiSelect = false;
            this.listCollections.Name = "listCollections";
            this.listCollections.Size = new System.Drawing.Size(328, 237);
            this.listCollections.TabIndex = 0;
            this.listCollections.UseCompatibleStateImageBehavior = false;
            this.listCollections.DragDrop += new System.Windows.Forms.DragEventHandler(this.listCollections_DragDrop);
            this.listCollections.DragEnter += new System.Windows.Forms.DragEventHandler(this.listCollections_DragEnter);
            this.listCollections.DoubleClick += new System.EventHandler(this.listCollections_DoubleClick);
            // 
            // listDocuments
            // 
            this.listDocuments.AllowDrop = true;
            this.listDocuments.Location = new System.Drawing.Point(337, 3);
            this.listDocuments.MultiSelect = false;
            this.listDocuments.Name = "listDocuments";
            this.listDocuments.Size = new System.Drawing.Size(179, 119);
            this.listDocuments.TabIndex = 1;
            this.listDocuments.UseCompatibleStateImageBehavior = false;
            this.listDocuments.DragDrop += new System.Windows.Forms.DragEventHandler(this.listDocuments_DragDrop);
            this.listDocuments.DragEnter += new System.Windows.Forms.DragEventHandler(this.listDocuments_DragEnter);
            this.listDocuments.DoubleClick += new System.EventHandler(this.listDocuments_DoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.searchBox,
            this.searchButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(769, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = global::LibrarianApplication.Properties.Resources.Previous_grey_24x;
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 22);
            this.backButton.Text = "toolStripButton2";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.toolStripLabel1.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 25);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchButton.Enabled = false;
            this.searchButton.Image = global::LibrarianApplication.Properties.Resources.Search;
            this.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(23, 22);
            this.searchButton.Text = "toolStripButton1";
            // 
            // mainLayout
            // 
            this.mainLayout.AllowDrop = true;
            this.mainLayout.Controls.Add(this.listCollections);
            this.mainLayout.Controls.Add(this.listDocuments);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 49);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.Size = new System.Drawing.Size(769, 365);
            this.mainLayout.TabIndex = 5;
            this.mainLayout.Layout += new System.Windows.Forms.LayoutEventHandler(this.mainLayout_Layout);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(769, 414);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = " Librarian Application";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDocumentToolStripMenuItem;
        private System.Windows.Forms.ListView listCollections;
        private System.Windows.Forms.ListView listDocuments;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox searchBox;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FlowLayoutPanel mainLayout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMultiGraphToolStripMenuItem;
    }
}

