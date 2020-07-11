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
        ModelSettings modelSettings = new ModelSettings();
        public MainForm()
        {
            InitializeComponent();

            ModelsComboBox.Items.Add("Auto");
            ModelsComboBox.Items.Add("Hash");
            ModelsComboBox.Items.Add("Scale-Down");
            ModelsComboBox.Items.Add("Difference");
            ModelsComboBox.Items.Add("Machine Learning");

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
            ModelSettingsBox.Controls.Clear();
            modelSettings.comboBox1.SelectedIndex = -1;
            modelSettings.comboBox2.SelectedIndex = -1;
            modelSettings.comboBox3.SelectedIndex = -1;
            modelSettings.comboBox4.SelectedIndex = -1;

            switch (s)
            {
                case "Auto":
                    break;

                case "Hash":
                    modelSettings.SetLabel(modelSettings.label1, new Point(10, 20), "Hash");
                    modelSettings.SetComboBox(modelSettings.comboBox1, new Point(10, 35), new List<string>() { "MD5", "SHA1", "SHA256" });
                    // Set up the Components for Hash
                    ModelSettingsBox.Controls.Add(modelSettings.label1);
                    ModelSettingsBox.Controls.Add(modelSettings.comboBox1);
                    // Add the Components to the Box
                    break;

                case "Scale-Down":
                    modelSettings.SetLabel(modelSettings.label1, new Point(10, 20), "Scale Size");
                    modelSettings.SetComboBox(modelSettings.comboBox1, new Point(10, 35), new List<string>() { "64x64", "128x128", "256x256" });

                    modelSettings.SetLabel(modelSettings.label2, new Point(150, 20), "Tolerance");
                    modelSettings.SetComboBox(modelSettings.comboBox2, new Point(150, 35), new List<string>() { "50%", "60%", "70%", "80%", "90%" });

                    ModelSettingsBox.Controls.Add(modelSettings.label1);
                    ModelSettingsBox.Controls.Add(modelSettings.label2);
                    ModelSettingsBox.Controls.Add(modelSettings.comboBox1);
                    ModelSettingsBox.Controls.Add(modelSettings.comboBox2);
                    break;

                case "Difference":
                    break;

                case "Machine Learing":
                    break;

            }
            
            
            
            

        }

        private void ModelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSettingsPanel(ModelsComboBox.SelectedItem.ToString());
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
            InfoWindow info = new InfoWindow();
            info.Show();
        }

        private void btnLoadFiles_Click(object sender, EventArgs e)
        {

        }
    }
}
