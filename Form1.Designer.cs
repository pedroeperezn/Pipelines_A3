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
            SuspendLayout();
            // 
            // BrowseFilesButton
            // 
            BrowseFilesButton.Location = new Point(81, 364);
            BrowseFilesButton.Name = "BrowseFilesButton";
            BrowseFilesButton.Size = new Size(139, 29);
            BrowseFilesButton.TabIndex = 0;
            BrowseFilesButton.Text = "Browse for Files";
            BrowseFilesButton.UseVisualStyleBackColor = true;
            // 
            // FilesPreview
            // 
            FilesPreview.Location = new Point(12, 12);
            FilesPreview.Name = "FilesPreview";
            FilesPreview.Size = new Size(277, 327);
            FilesPreview.TabIndex = 1;
            FilesPreview.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FilesPreview);
            Controls.Add(BrowseFilesButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button BrowseFilesButton;
        private ListView FilesPreview;
    }
}