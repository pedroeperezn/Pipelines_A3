namespace Pipelines_A3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}