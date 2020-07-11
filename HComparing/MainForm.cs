using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HComparing
{
    public partial class MainForm : Form
    {
        string scanFolder;
        public MainForm()
        {
            InitializeComponent();
            btnStart.Enabled = false;
            btnStart.BackColor = Color.FromArgb(128, 128, 128);

        }

        private void btnLoadFolder_Click(object sender, EventArgs e)
        {
            // I dont like the way that the folderBrowserDialog looks like I like the one
            // from the fileBrowserDialog more but there is a hacky solution to do it.
            // I could do it, but I need to add several checks to make sure it's a Directory.

            folderBrowserDialog1.ShowDialog();
            scanFolder = folderBrowserDialog1.SelectedPath;
            folderLocation.Text = scanFolder;
            Console.WriteLine(scanFolder);
            
        }

        private void ChangeSettignsPanel(string s)
        {
            Console.WriteLine(s);

        }

        private void ModelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSettignsPanel(ModelsComboBox.SelectedItem.ToString());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();

            settingsWindow.ShowDialog();
            // I would like to use settingsWindow.Show(); but I need to find a way to keep the user from
            // keep opening the same settings window and just to focus on the settings window in the background.
        }
    }
}
