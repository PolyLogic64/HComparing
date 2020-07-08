namespace HComparing
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
            this.btnLoadFolder = new System.Windows.Forms.Button();
            this.folderLocation = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ModelsComboBox = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.ModelSettingsBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnLoadFolder
            // 
            this.btnLoadFolder.Location = new System.Drawing.Point(23, 54);
            this.btnLoadFolder.Name = "btnLoadFolder";
            this.btnLoadFolder.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFolder.TabIndex = 0;
            this.btnLoadFolder.Text = "Load Folder";
            this.btnLoadFolder.UseVisualStyleBackColor = true;
            // 
            // folderLocation
            // 
            this.folderLocation.Location = new System.Drawing.Point(23, 28);
            this.folderLocation.Name = "folderLocation";
            this.folderLocation.ReadOnly = true;
            this.folderLocation.Size = new System.Drawing.Size(341, 20);
            this.folderLocation.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(118)))));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 167);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(756, 242);
            this.flowLayoutPanel1.TabIndex = 2;
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
            this.ModelsComboBox.Items.AddRange(new object[] {
            "Hash",
            "Scale-Down",
            "Difference",
            "Machine Learning"});
            this.ModelsComboBox.Location = new System.Drawing.Point(370, 28);
            this.ModelsComboBox.Name = "ModelsComboBox";
            this.ModelsComboBox.Size = new System.Drawing.Size(121, 21);
            this.ModelsComboBox.TabIndex = 4;
            this.ModelsComboBox.Text = "Select A Model";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(669, 118);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(109, 43);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(497, 28);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(42, 21);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // ModelSettingsBox
            // 
            this.ModelSettingsBox.Location = new System.Drawing.Point(317, 61);
            this.ModelSettingsBox.Name = "ModelSettingsBox";
            this.ModelSettingsBox.Size = new System.Drawing.Size(346, 100);
            this.ModelSettingsBox.TabIndex = 7;
            this.ModelSettingsBox.TabStop = false;
            this.ModelSettingsBox.Text = "Model Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ModelSettingsBox);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ModelsComboBox);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.folderLocation);
            this.Controls.Add(this.btnLoadFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HImageComparing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadFolder;
        private System.Windows.Forms.TextBox folderLocation;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ComboBox ModelsComboBox;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.GroupBox ModelSettingsBox;
    }
}

