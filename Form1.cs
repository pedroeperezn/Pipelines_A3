using NAudio.Wave;
using System.IO;

namespace Pipelines_A3
{
    public partial class Form1 : Form
    {
        public string[] audioWAVFiles;
        public string[] audioMP3Files;

        public Form1()
        {
            InitializeComponent();
            FilesPreview.Columns.Add("File Name", 300);
            FilesPreview.Columns.Add("File Length", 100);

        }

        private void BrowseFilesButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserAudio.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserAudio.SelectedPath))
            {
                textBox1.Text = folderBrowserAudio.SelectedPath;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void RefreshFilesButton_Click(object sender, EventArgs e)
        {
            FilesPreview.Items.Clear();

            string directory = folderBrowserAudio.SelectedPath;


            if (Directory.Exists(directory))
            {
                audioWAVFiles = Directory.GetFiles(directory, "*.wav");
                audioMP3Files = Directory.GetFiles(directory, "*.mp3");

                TimeSpan duration;

                FilesPreview.Items.Add("FOUND WAVE FILES: ");

                foreach (var audioFile in audioWAVFiles)
                {
                    var wavItem = new ListViewItem(Path.GetFileName(audioFile));

                    using (var reader = new WaveFileReader(audioFile))
                    {
                        duration = reader.TotalTime;
                        wavItem.SubItems.Add(duration.ToString(@"hh\:mm\:ss"));
                    }

                    FilesPreview.Items.Add(wavItem);
                }

                FilesPreview.Items.Add(" ");
                FilesPreview.Items.Add("FOUND MP3 FILES: ");

                foreach (var audioFile in audioMP3Files)
                {
                    var mp3Item = new ListViewItem(Path.GetFileName(audioFile));

                    using (var reader = new Mp3FileReader(audioFile))
                    {
                        duration = reader.TotalTime;
                        mp3Item.SubItems.Add(duration.ToString(@"hh\:mm\:ss"));
                    }

                    FilesPreview.Items.Add(mp3Item);
                }
            }
        }

        private void OrganizeBtn_Click(object sender, EventArgs e)
        {
            string directory = folderBrowserAudio.SelectedPath;

            if (audioWAVFiles != null)
            { 
                foreach (var audioFile in audioWAVFiles)
                {
                    string fileExtension = "WAV FILES";
                    var wavItem = new ListViewItem(Path.GetFileName(audioFile));

                    string targetDirectory = Path.Combine(directory, fileExtension);
                    string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(audioFile));

                    Directory.CreateDirectory(targetDirectory);

                    File.Move(audioFile, targetFilePath);

                }
            }

            if(audioMP3Files != null) 
            {
                foreach (var audioFile in audioMP3Files)
                {
                    string fileExtension = "MP3 FILES";
                    var wavItem = new ListViewItem(Path.GetFileName(audioFile));

                    string targetDirectory = Path.Combine(directory, fileExtension);
                    string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(audioFile));

                    Directory.CreateDirectory(targetDirectory);

                    File.Move(audioFile, targetFilePath);
                }
            }

        }
        private void FilesPreview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}