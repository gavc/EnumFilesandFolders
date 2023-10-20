namespace EnumNames
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
            textBox1 = new TextBox();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            checkBoxFiles = new CheckBox();
            checkBoxFolders = new CheckBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(733, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "C:\\temp";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(751, 8);
            button1.Name = "button1";
            button1.Size = new Size(235, 46);
            button1.TabIndex = 1;
            button1.Text = "Choose Folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(751, 60);
            button2.Name = "button2";
            button2.Size = new Size(235, 46);
            button2.TabIndex = 2;
            button2.Text = "Go";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 505);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(974, 121);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // checkBoxFiles
            // 
            checkBoxFiles.AutoSize = true;
            checkBoxFiles.Checked = true;
            checkBoxFiles.CheckState = CheckState.Checked;
            checkBoxFiles.Location = new Point(12, 66);
            checkBoxFiles.Name = "checkBoxFiles";
            checkBoxFiles.Size = new Size(93, 36);
            checkBoxFiles.TabIndex = 4;
            checkBoxFiles.Text = "Files";
            checkBoxFiles.UseVisualStyleBackColor = true;
            // 
            // checkBoxFolders
            // 
            checkBoxFolders.AutoSize = true;
            checkBoxFolders.Location = new Point(111, 66);
            checkBoxFolders.Name = "checkBoxFolders";
            checkBoxFolders.Size = new Size(123, 36);
            checkBoxFolders.TabIndex = 5;
            checkBoxFolders.Text = "Folders";
            checkBoxFolders.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(12, 112);
            listView1.Name = "listView1";
            listView1.Size = new Size(974, 376);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Type";
            columnHeader2.Width = 894;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(32, 32);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 655);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(998, 42);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(524, 32);
            toolStripStatusLabel1.Text = "File and Folders - Choose a folder and click 'Go'";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 697);
            Controls.Add(statusStrip1);
            Controls.Add(listView1);
            Controls.Add(checkBoxFolders);
            Controls.Add(checkBoxFiles);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Enum Files and Folders";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button2;
        private RichTextBox richTextBox1;
        private CheckBox checkBoxFiles;
        private CheckBox checkBoxFolders;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}