using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HComparing
{
    public partial class MainForm : Form
    {
        public class ModelSettings
        {
            public Label label1 = new Label();
            public Label label2 = new Label();
            public Label label3 = new Label();
            public Label label4 = new Label();
            public Label label5 = new Label();
            public Label label6 = new Label();
            public ComboBox comboBox1 = new ComboBox();
            public ComboBox comboBox2 = new ComboBox();
            public ComboBox comboBox3 = new ComboBox();
            public ComboBox comboBox4 = new ComboBox();
            public ComboBox comboBox5 = new ComboBox();
            public ComboBox comboBox6 = new ComboBox();
            public void SetLabel(Label label, Point p, string text)
            {
                label.Text = text;
                label.Location = p;
                label.AutoSize = true;
                label.ForeColor = Color.FromKnownColor(KnownColor.Control);
            }
            public void SetComboBox(ComboBox comboBox, Point p, List<string> items)
            {
                comboBox.Location = p;
                comboBox.TabStop = false;
                comboBox.Items.Clear();
                foreach (string item in items)
                {
                    comboBox.Items.Add(item);
                }
            }
        }
        string scanFolder;
        ModelSettings ImageModelSettings = new ModelSettings();
        ModelSettings VideoModelSettings = new ModelSettings();
        public MainForm()
        {
            InitializeComponent();

            ImageModelComboBox.Items.Add("Auto");
            ImageModelComboBox.Items.Add("Hash");
            ImageModelComboBox.Items.Add("Difference");
            ImageModelComboBox.Items.Add("Scale-Down");
            ImageModelComboBox.Items.Add("Machine Learning");

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

        private void ChangeSettingsPanel(string s)
        {
            Console.WriteLine(s);
            ImageModelSettingsBox.Controls.Clear();
            ImageModelSettings.comboBox1.SelectedIndex = -1;
            ImageModelSettings.comboBox2.SelectedIndex = -1;
            ImageModelSettings.comboBox3.SelectedIndex = -1;
            ImageModelSettings.comboBox4.SelectedIndex = -1;
            ImageModelSettings.comboBox5.SelectedIndex = -1;
            ImageModelSettings.comboBox6.SelectedIndex = -1;

            switch (s)
            {
                case "Auto":
                    break;

                case "Hash":
                    ImageModelSettings.SetLabel(ImageModelSettings.label1, new Point(10, 20), "Hash");
                    ImageModelSettings.SetComboBox(ImageModelSettings.comboBox1, new Point(10, 35), new List<string>() { "Auto", "MD5", "SHA1", "SHA256" });
                    // Set up the Components for Hash
                    ImageModelSettingsBox.Controls.Add(ImageModelSettings.label1);
                    ImageModelSettingsBox.Controls.Add(ImageModelSettings.comboBox1);
                    // Add the Components to the Box
                    break;

                case "Difference":
                    break;

                case "Scale-Down":
                    ImageModelSettings.SetLabel(ImageModelSettings.label1, new Point(10, 20), "Scale Size");
                    ImageModelSettings.SetComboBox(ImageModelSettings.comboBox1, new Point(10, 35), new List<string>() { "Auto", "64x64", "128x128", "256x256" });

                    ImageModelSettings.SetLabel(ImageModelSettings.label2, new Point(150, 20), "Tolerance");
                    ImageModelSettings.SetComboBox(ImageModelSettings.comboBox2, new Point(150, 35), new List<string>() { "Auto", "50%", "60%", "70%", "80%", "90%" });

                    ImageModelSettingsBox.Controls.Add(ImageModelSettings.label1);
                    ImageModelSettingsBox.Controls.Add(ImageModelSettings.label2);
                    ImageModelSettingsBox.Controls.Add(ImageModelSettings.comboBox1);
                    ImageModelSettingsBox.Controls.Add(ImageModelSettings.comboBox2);
                    break;

                case "Machine Learing":
                    break;

            }
            
            
            
            

        }

        private void ModelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSettingsPanel(ImageModelComboBox.SelectedItem.ToString());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();

            settingsWindow.ShowDialog();
            // I would like to use settingsWindow.Show(); but I need to find a way to keep the user from
            // keep opening the same settings window and just to focus on the settings window in the background.
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ImageInfoWindow info = new ImageInfoWindow();
            info.Show();
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {

        }
    }
}
