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
            this.ModelsComboBox = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.ModelSettingsBox = new System.Windows.Forms.GroupBox();
            this.checkBoxScanSubfolders = new System.Windows.Forms.CheckBox();
            this.checkBoxExpertMode = new System.Windows.Forms.CheckBox();
            this.HelpBox = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.Location = new System.Drawing.Point(23, 54);
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
            this.folderLocation.Location = new System.Drawing.Point(23, 28);
            this.folderLocation.Name = "folderLocation";
            this.folderLocation.ReadOnly = true;
            this.folderLocation.Size = new System.Drawing.Size(341, 20);
            this.folderLocation.TabIndex = 1;
            this.folderLocation.TabStop = false;
            // 
            // ItemPanel
            // 
            this.ItemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(118)))));
            this.ItemPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPanel.Location = new System.Drawing.Point(23, 216);
            this.ItemPanel.Name = "ItemPanel";
            this.ItemPanel.Size = new System.Drawing.Size(756, 193);
            this.ItemPanel.TabIndex = 2;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(23, 415);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(756, 23);
            this.progressBar.TabIndex = 3;
            // 
            // ModelsComboBox
            // 
            this.ModelsComboBox.FormattingEnabled = true;
            this.ModelsComboBox.Location = new System.Drawing.Point(370, 28);
            this.ModelsComboBox.Name = "ModelsComboBox";
            this.ModelsComboBox.Size = new System.Drawing.Size(121, 21);
            this.ModelsComboBox.TabIndex = 4;
            this.ModelsComboBox.TabStop = false;
            this.ModelsComboBox.Text = "Select A Model";
            this.ModelsComboBox.SelectedIndexChanged += new System.EventHandler(this.ModelsComboBox_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(191)))));
            this.btnStart.Enabled = false;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(23, 106);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 43);
            this.btnStart.TabIndex = 5;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(497, 28);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(42, 21);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.TabStop = false;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // ModelSettingsBox
            // 
            this.ModelSettingsBox.Location = new System.Drawing.Point(317, 61);
            this.ModelSettingsBox.Name = "ModelSettingsBox";
            this.ModelSettingsBox.Size = new System.Drawing.Size(462, 149);
            this.ModelSettingsBox.TabIndex = 7;
            this.ModelSettingsBox.TabStop = false;
            this.ModelSettingsBox.Text = "Model Settings";
            // 
            // checkBoxScanSubfolders
            // 
            this.checkBoxScanSubfolders.AutoSize = true;
            this.checkBoxScanSubfolders.Location = new System.Drawing.Point(23, 83);
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
            this.checkBoxExpertMode.Location = new System.Drawing.Point(133, 83);
            this.checkBoxExpertMode.Name = "checkBoxExpertMode";
            this.checkBoxExpertMode.Size = new System.Drawing.Size(86, 17);
            this.checkBoxExpertMode.TabIndex = 9;
            this.checkBoxExpertMode.TabStop = false;
            this.checkBoxExpertMode.Text = "Expert Mode";
            this.checkBoxExpertMode.UseVisualStyleBackColor = true;
            // 
            // HelpBox
            // 
            this.HelpBox.BackColor = System.Drawing.Color.Black;
            this.HelpBox.Location = new System.Drawing.Point(545, 28);
            this.HelpBox.Name = "HelpBox";
            this.HelpBox.Size = new System.Drawing.Size(234, 27);
            this.HelpBox.TabIndex = 10;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(23, 156);
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
            this.btnLoadFiles.Location = new System.Drawing.Point(139, 107);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(109, 43);
            this.btnLoadFiles.TabIndex = 12;
            this.btnLoadFiles.TabStop = false;
            this.btnLoadFiles.Text = "Load Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadFiles);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.HelpBox);
            this.Controls.Add(this.checkBoxExpertMode);
            this.Controls.Add(this.checkBoxScanSubfolders);
            this.Controls.Add(this.ModelSettingsBox);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ModelsComboBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ItemPanel);
            this.Controls.Add(this.folderLocation);
            this.Controls.Add(this.btnLoadFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HImageComparing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.TextBox folderLocation;
        private System.Windows.Forms.FlowLayoutPanel ItemPanel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox ModelsComboBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.GroupBox ModelSettingsBox;
        private System.Windows.Forms.CheckBox checkBoxScanSubfolders;
        private System.Windows.Forms.CheckBox checkBoxExpertMode;
        private System.Windows.Forms.Panel HelpBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLoadFiles;
    }
}

