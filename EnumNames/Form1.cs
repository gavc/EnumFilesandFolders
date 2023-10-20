// This code was created with the assistance of ChatGPT from OpenAI
using System.Text;

namespace EnumNames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = fbd.SelectedPath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;

            //listView1.View = View.Details;
            listView1.Items.Clear();

            if (Directory.Exists(path))
            {
                richTextBox1.Clear();
                toolStripStatusLabel1.Text = "";

                int fileCount = 0;
                int directoryCount = 0;

                // Check if at least one checkbox is checked
                if (!checkBoxFiles.Checked && !checkBoxFolders.Checked)
                {
                    toolStripStatusLabel1.Text = "Please check 'File' or 'Folders' to search";
                    return;  // Exit the method early
                }

                try
                {
                    // If the 'Files' checkbox is checked, scan for files
                    if (checkBoxFiles.Checked)
                    {
                        string[] files = Directory.GetFiles(path);
                        if (files.Length == 0)
                        {
                            toolStripStatusLabel1.Text = "No files found";
                        }
                        else
                        {
                            foreach (var file in files)
                            {
                                ListViewItem item = new ListViewItem(Path.GetFileName(file));
                                item.SubItems.Add("File");
                                listView1.Items.Add(item);
                            }
                        }
                    }

                    // If the 'Folders' checkbox is checked, scan for folders
                    if (checkBoxFolders.Checked)
                    {
                        string[] directories = Directory.GetDirectories(path);
                        if (directories.Length == 0)
                        {
                            toolStripStatusLabel1.Text = "No folders found";
                        }
                        else
                        {
                            foreach (var dir in directories)
                            {
                                ListViewItem item = new ListViewItem(Path.GetFileName(dir));
                                item.SubItems.Add("Folder");
                                listView1.Items.Add(item);
                            }
                        }

                    }

                    // Copy results to clipboard
                    CopyNameColumnToClipboard(listView1);
                }
                catch (Exception ex)
                {
                    //richTextBox1.AppendText("Error: " + ex.Message);
                    toolStripStatusLabel1.Text = "Oh no - we have had an Exception";
                }
            }
            else
            {
                toolStripStatusLabel1.Text = "The specified path does not exist.";
            }

            // Assume newPath is the updated path
            string newPath = textBox1.Text;
            Properties.Settings.Default.LastUsedPath = newPath;
            Properties.Settings.Default.Save();

            foreach (ColumnHeader column in listView1.Columns)
            {
                column.Width = -2;  // based on content
                                    // or
                                    //column.Width = -1;  // based on header
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string lastUsedPath = Properties.Settings.Default.LastUsedPath;
            if (!string.IsNullOrEmpty(lastUsedPath))
            {
                textBox1.Text = lastUsedPath;
            }
            else
            {
                textBox1.Text = @"C:\temp";  // Default path
            }
        }
        private void CopyNameColumnToClipboard(ListView listView)
        {
            if (listView.Items.Count == 0)
            {
                toolStripStatusLabel1.Text = "List empty, nothing copied to Clipboard.";
                return;
            }

            StringBuilder sb = new StringBuilder();

            // Assuming the "Name" column is the first column (index 0)
            foreach (ListViewItem item in listView.Items)
            {
                sb.AppendLine(item.SubItems[0].Text);
            }

            // Copy to clipboard
            Clipboard.SetText(sb.ToString());
        }
    }
}