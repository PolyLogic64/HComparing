namespace HComparing
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.folderLocation = new System.Windows.Forms.TextBox();
            this.ItemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ImageModelComboBox = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnImageInfo = new System.Windows.Forms.Button();
            this.ImageModelSettingsBox = new System.Windows.Forms.GroupBox();
            this.checkBoxScanSubfolders = new System.Windows.Forms.CheckBox();
            this.checkBoxExpertMode = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VideoModelSettingsBox = new System.Windows.Forms.GroupBox();
            this.btnVideoInfo = new System.Windows.Forms.Button();
            this.VideoModelComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.Location = new System.Drawing.Point(12, 38);
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFolder.TabIndex = 0;
            this.btnLoadFolder.TabStop = false;
            this.btnLoadFolder.Text = "Load Folder";
            this.btnLoadFolder.UseVisualStyleBackColor = true;
            this.btnLoadFolder.Click += new System.EventHandler(this.btnLoadFolder_Click);
            // 
            // folderLocation
            // 
            this.folderLocation.Location = new System.Drawing.Point(12, 12);
            this.folderLocation.Name = "folderLocation";
            this.folderLocation.ReadOnly = true;
            this.folderLocation.Size = new System.Drawing.Size(341, 20);
            this.folderLocation.TabIndex = 1;
            this.folderLocation.TabStop = false;
            // 
            // ItemPanel
            // 
            this.ItemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPanel.Location = new System.Drawing.Point(774, 12);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(394, 445);
            this.ItemPanel.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 434);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(756, 23);
            this.progressBar.TabIndex = 3;
            // 
            // ImageModelComboBox
            // 
            this.ImageModelComboBox.FormattingEnabled = true;
            this.ImageModelComboBox.Location = new System.Drawing.Point(3, 3);
            this.ImageModelComboBox.Name = "ImageModelComboBox";
            this.ImageModelComboBox.Size = new System.Drawing.Size(142, 21);
            this.ImageModelComboBox.TabIndex = 4;
            this.ImageModelComboBox.TabStop = false;
            this.ImageModelComboBox.Text = "Select an Image Model";
            this.ImageModelComboBox.SelectedIndexChanged += new System.EventHandler(this.ModelsComboBox_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(191)))));
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 90);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 43);
            this.btnStart.TabIndex = 5;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnImageInfo
            // 
            this.btnImageInfo.Location = new System.Drawing.Point(151, 3);
            this.btnImageInfo.Name = "btnImageInfo";
            this.btnImageInfo.Size = new System.Drawing.Size(42, 21);
            this.btnImageInfo.TabIndex = 6;
            this.btnImageInfo.TabStop = false;
            this.btnImageInfo.Text = "Info";
            this.btnImageInfo.UseVisualStyleBackColor = true;
            this.btnImageInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // ImageModelSettingsBox
            // 
            this.ImageModelSettingsBox.ForeColor = System.Drawing.SystemColors.Control;
            this.ImageModelSettingsBox.Location = new System.Drawing.Point(3, 30);
            this.ImageModelSettingsBox.Name = "ImageModelSettingsBox";
            this.ImageModelSettingsBox.Size = new System.Drawing.Size(403, 172);
            this.ImageModelSettingsBox.TabIndex = 7;
            this.ImageModelSettingsBox.TabStop = false;
            this.ImageModelSettingsBox.Text = "Image Model Settings";
            // 
            // checkBoxScanSubfolders
            // 
            this.checkBoxScanSubfolders.AutoSize = true;
            this.checkBoxScanSubfolders.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxScanSubfolders.Location = new System.Drawing.Point(12, 67);
            this.checkBoxScanSubfolders.Name = "checkBoxScanSubfolders";
            this.checkBoxScanSubfolders.Size = new System.Drawing.Size(104, 17);
            this.checkBoxScanSubfolders.TabIndex = 8;
            this.checkBoxScanSubfolders.TabStop = false;
            this.checkBoxScanSubfolders.Text = "Scan Subfolders";
            this.checkBoxScanSubfolders.UseVisualStyleBackColor = true;
            // 
            // checkBoxExpertMode
            // 
            this.checkBoxExpertMode.AutoSize = true;
            this.checkBoxExpertMode.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxExpertMode.Location = new System.Drawing.Point(122, 67);
            this.checkBoxExpertMode.Name = "checkBoxExpertMode";
            this.checkBoxExpertMode.Size = new System.Drawing.Size(86, 17);
            this.checkBoxExpertMode.TabIndex = 9;
            this.checkBoxExpertMode.TabStop = false;
            this.checkBoxExpertMode.Text = "Expert Mode";
            this.checkBoxExpertMode.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 188);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(109, 35);
            this.btnSettings.TabIndex = 11;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Enabled = false;
            this.btnLoadFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFiles.Location = new System.Drawing.Point(12, 139);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(109, 43);
            this.btnLoadFiles.TabIndex = 12;
            this.btnLoadFiles.TabStop = false;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImageModelComboBox);
            this.panel1.Controls.Add(this.btnImageInfo);
            this.panel1.Controls.Add(this.ImageModelSettingsBox);
            this.panel1.Location = new System.Drawing.Point(359, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 205);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.VideoModelSettingsBox);
            this.panel2.Controls.Add(this.btnVideoInfo);
            this.panel2.Controls.Add(this.VideoModelComboBox);
            this.panel2.Location = new System.Drawing.Point(359, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 205);
            this.panel2.TabIndex = 14;
            // 
            // VideoModelSettingsBox
            // 
            this.VideoModelSettingsBox.ForeColor = System.Drawing.SystemColors.Control;
            this.VideoModelSettingsBox.Location = new System.Drawing.Point(0, 31);
            this.VideoModelSettingsBox.Name = "VideoModelSettingsBox";
            this.VideoModelSettingsBox.Size = new System.Drawing.Size(406, 171);
            this.VideoModelSettingsBox.TabIndex = 2;
            this.VideoModelSettingsBox.TabStop = false;
            this.VideoModelSettingsBox.Text = "Video Model Settings";
            // 
            // btnVideoInfo
            // 
            this.btnVideoInfo.Location = new System.Drawing.Point(151, 4);
            this.btnVideoInfo.Name = "btnVideoInfo";
            this.btnVideoInfo.Size = new System.Drawing.Size(42, 22);
            this.btnVideoInfo.TabIndex = 1;
            this.btnVideoInfo.TabStop = false;
            this.btnVideoInfo.Text = "Info";
            this.btnVideoInfo.UseVisualStyleBackColor = true;
            // 
            // VideoModelComboBox
            // 
            this.VideoModelComboBox.FormattingEnabled = true;
            this.VideoModelComboBox.Location = new System.Drawing.Point(3, 5);
            this.VideoModelComboBox.Name = "VideoModelComboBox";
            this.VideoModelComboBox.Size = new System.Drawing.Size(142, 21);
            this.VideoModelComboBox.TabIndex = 0;
            this.VideoModelComboBox.TabStop = false;
            this.VideoModelComboBox.Text = "Select a Video Model";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1180, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLoadFiles);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.checkBoxExpertMode);
            this.Controls.Add(this.checkBoxScanSubfolders);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.folderLocation);
            this.Controls.Add(this.btnLoadFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HComparing";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.TextBox folderLocation;
        private System.Windows.Forms.FlowLayoutPanel ItemPanel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox ImageModelComboBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnImageInfo;
        private System.Windows.Forms.GroupBox ImageModelSettingsBox;
        private System.Windows.Forms.CheckBox checkBoxScanSubfolders;
        private System.Windows.Forms.CheckBox checkBoxExpertMode;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox VideoModelSettingsBox;
        private System.Windows.Forms.Button btnVideoInfo;
        private System.Windows.Forms.ComboBox VideoModelComboBox;
    }
}

