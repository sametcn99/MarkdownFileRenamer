namespace MarkdownFileRenamer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.selectedFolderLabel = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // selectFolderButton
            // 
            this.selectFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.selectFolderButton.Location = new System.Drawing.Point(12, 106);
            this.selectFolderButton.Name = "selectFolderButton";
            this.selectFolderButton.Size = new System.Drawing.Size(576, 75);
            this.selectFolderButton.TabIndex = 0;
            this.selectFolderButton.Text = "Select Folder";
            this.selectFolderButton.UseVisualStyleBackColor = true;
            this.selectFolderButton.Click += new System.EventHandler(this.selectFolderButton_Click);
            // 
            // selectedFolderLabel
            // 
            this.selectedFolderLabel.AutoSize = true;
            this.selectedFolderLabel.Enabled = false;
            this.selectedFolderLabel.ForeColor = System.Drawing.Color.White;
            this.selectedFolderLabel.Location = new System.Drawing.Point(12, 9);
            this.selectedFolderLabel.Name = "selectedFolderLabel";
            this.selectedFolderLabel.Size = new System.Drawing.Size(39, 13);
            this.selectedFolderLabel.TabIndex = 1;
            this.selectedFolderLabel.Text = "Output";
            // 
            // runButton
            // 
            this.runButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(15, 187);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(576, 75);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "RUN";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(194, 266);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(196, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Check out the Source Code from Github";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(603, 288);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.selectedFolderLabel);
            this.Controls.Add(this.selectFolderButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Markdown File Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label selectedFolderLabel;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

