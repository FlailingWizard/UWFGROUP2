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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainWindowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.listCollections = new System.Windows.Forms.ListView();
            this.listDocuments = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.mainWindowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
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
            this.addNewCollectionToolStripMenuItem.Click += new System.EventHandler(this.addNewCollectionClicked);
            // 
            // addDocumentToolStripMenuItem
            // 
            this.addDocumentToolStripMenuItem.Name = "addDocumentToolStripMenuItem";
            this.addDocumentToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addDocumentToolStripMenuItem.Text = "Add Document";
            this.addDocumentToolStripMenuItem.Click += new System.EventHandler(this.addDocumentClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(520, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 2;
            // 
            // mainWindowLayout
            // 
            this.mainWindowLayout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mainWindowLayout.Controls.Add(this.listCollections);
            this.mainWindowLayout.Controls.Add(this.listDocuments);
            this.mainWindowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainWindowLayout.Location = new System.Drawing.Point(0, 24);
            this.mainWindowLayout.Margin = new System.Windows.Forms.Padding(2);
            this.mainWindowLayout.Name = "mainWindowLayout";
            this.mainWindowLayout.Padding = new System.Windows.Forms.Padding(2);
            this.mainWindowLayout.Size = new System.Drawing.Size(673, 375);
            this.mainWindowLayout.TabIndex = 3;
            this.mainWindowLayout.Layout += new System.Windows.Forms.LayoutEventHandler(this.mainWindowLayout_Layout);
            // 
            // listCollections
            // 
            this.listCollections.Location = new System.Drawing.Point(5, 5);
            this.listCollections.Name = "listCollections";
            this.listCollections.Size = new System.Drawing.Size(328, 237);
            this.listCollections.TabIndex = 0;
            this.listCollections.UseCompatibleStateImageBehavior = false;
            // 
            // listDocuments
            // 
            this.listDocuments.Location = new System.Drawing.Point(5, 248);
            this.listDocuments.Name = "listDocuments";
            this.listDocuments.Size = new System.Drawing.Size(179, 119);
            this.listDocuments.TabIndex = 1;
            this.listDocuments.UseCompatibleStateImageBehavior = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(673, 399);
            this.Controls.Add(this.mainWindowLayout);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = " Librarian Application";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.MainWindow_Layout);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainWindowLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDocumentToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel mainWindowLayout;
        private System.Windows.Forms.ListView listCollections;
        private System.Windows.Forms.ListView listDocuments;
    }
}

