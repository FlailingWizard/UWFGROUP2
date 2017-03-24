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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(897, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCollectionToolStripMenuItem,
            this.addDocumentToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewCollectionToolStripMenuItem
            // 
            this.addNewCollectionToolStripMenuItem.Name = "addNewCollectionToolStripMenuItem";
            this.addNewCollectionToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.addNewCollectionToolStripMenuItem.Text = "Add Collection";
            // 
            // addDocumentToolStripMenuItem
            // 
            this.addDocumentToolStripMenuItem.Name = "addDocumentToolStripMenuItem";
            this.addDocumentToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.addDocumentToolStripMenuItem.Text = "Add Document";
            this.addDocumentToolStripMenuItem.Click += new System.EventHandler(this.addDocumentClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(693, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 2;
            // 
            // mainWindowLayout
            // 
            this.mainWindowLayout.BackColor = System.Drawing.SystemColors.Window;
            this.mainWindowLayout.Controls.Add(this.listCollections);
            this.mainWindowLayout.Controls.Add(this.listDocuments);
            this.mainWindowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainWindowLayout.Location = new System.Drawing.Point(0, 28);
            this.mainWindowLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainWindowLayout.Name = "mainWindowLayout";
            this.mainWindowLayout.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainWindowLayout.Size = new System.Drawing.Size(897, 463);
            this.mainWindowLayout.TabIndex = 3;
            // 
            // listCollections
            // 
            this.listCollections.Location = new System.Drawing.Point(5, 5);
            this.listCollections.MultiSelect = false;
            this.listCollections.Location = new System.Drawing.Point(7, 6);
            this.listCollections.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listCollections.Name = "listCollections";
            this.listCollections.Size = new System.Drawing.Size(436, 291);
            this.listCollections.TabIndex = 0;
            this.listCollections.UseCompatibleStateImageBehavior = false;
            this.listCollections.DoubleClick += new System.EventHandler(this.listCollections_DoubleClick);
            // 
            // listDocuments
            // 
            this.listDocuments.Location = new System.Drawing.Point(5, 248);
            this.listDocuments.MultiSelect = false;
            this.listDocuments.Location = new System.Drawing.Point(7, 305);
            this.listDocuments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listDocuments.Name = "listDocuments";
            this.listDocuments.Size = new System.Drawing.Size(237, 146);
            this.listDocuments.TabIndex = 1;
            this.listDocuments.UseCompatibleStateImageBehavior = false;
            this.listDocuments.SelectedIndexChanged += new System.EventHandler(this.listDocuments_SelectedIndexChanged);
            this.listDocuments.DoubleClick += new System.EventHandler(this.listDocuments_DoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(897, 491);
            this.Controls.Add(this.mainWindowLayout);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = " Librarian Application";
            this.Load += new System.EventHandler(this.MainWindow_Load);
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

