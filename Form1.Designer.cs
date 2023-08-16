namespace Pipelines_A3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BrowseFilesButton = new Button();
            FilesPreview = new ListView();
            textBox1 = new TextBox();
            folderBrowserAudio = new FolderBrowserDialog();
            RefreshFilesButton = new Button();
            OrganizeBtn = new Button();
            SuspendLayout();
            // 
            // BrowseFilesButton
            // 
            BrowseFilesButton.Location = new Point(12, 18);
            BrowseFilesButton.Name = "BrowseFilesButton";
            BrowseFilesButton.Size = new Size(139, 23);
            BrowseFilesButton.TabIndex = 0;
            BrowseFilesButton.Text = "Browse for Directory";
            BrowseFilesButton.UseVisualStyleBackColor = true;
            BrowseFilesButton.Click += BrowseFilesButton_Click;
            // 
            // FilesPreview
            // 
            FilesPreview.FullRowSelect = true;
            FilesPreview.Location = new Point(165, 52);
            FilesPreview.Name = "FilesPreview";
            FilesPreview.Size = new Size(612, 287);
            FilesPreview.TabIndex = 1;
            FilesPreview.UseCompatibleStateImageBehavior = false;
            FilesPreview.View = View.Details;
            FilesPreview.SelectedIndexChanged += FilesPreview_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(612, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // RefreshFilesButton
            // 
            RefreshFilesButton.Location = new Point(12, 52);
            RefreshFilesButton.Name = "RefreshFilesButton";
            RefreshFilesButton.Size = new Size(139, 23);
            RefreshFilesButton.TabIndex = 3;
            RefreshFilesButton.Text = "Refresh Files";
            RefreshFilesButton.UseVisualStyleBackColor = true;
            RefreshFilesButton.Click += RefreshFilesButton_Click;
            // 
            // OrganizeBtn
            // 
            OrganizeBtn.Location = new Point(165, 345);
            OrganizeBtn.Name = "OrganizeBtn";
            OrganizeBtn.Size = new Size(198, 23);
            OrganizeBtn.TabIndex = 4;
            OrganizeBtn.Text = "Organize Audio Files";
            OrganizeBtn.UseVisualStyleBackColor = true;
            OrganizeBtn.Click += OrganizeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OrganizeBtn);
            Controls.Add(RefreshFilesButton);
            Controls.Add(textBox1);
            Controls.Add(FilesPreview);
            Controls.Add(BrowseFilesButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BrowseFilesButton;
        private ListView FilesPreview;
        private TextBox textBox1;
        private FolderBrowserDialog folderBrowserAudio;
        private Button RefreshFilesButton;
        private Button OrganizeBtn;
    }
}