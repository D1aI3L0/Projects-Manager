using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace source
{
    public partial class AddProject : Form
    {
        internal ProjectInfo projectInfo;
        private RegistryControl registryControl;
        public bool isOk = false;

        public AddProject()
        {
            InitializeComponent();
            projectInfo = new ProjectInfo();
            registryControl = new RegistryControl();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            if(nameTextBox.Text == "")
            {
                if (!errorImageBox1.Enabled) errorImageBox1.Enabled = true;
                if (!errorImageBox1.Enabled) errorImageBox1.Enabled = true;
                if(!error) error = true;
            }
            else
            {
                if (errorImageBox1.Enabled) errorImageBox1.Enabled = false;
                if (errorImageBox1.Enabled) errorImageBox1.Enabled = false;
            }

            if(languageComboBox.Text == "")
            {
                if (!errorImageBox2.Enabled) errorImageBox2.Enabled = true;
                if (!errorImageBox2.Enabled) errorImageBox2.Enabled = true;
                if (!error) error = true;
            }
            else
            {
                if (errorImageBox2.Enabled) errorImageBox2.Enabled = false;
                if (errorImageBox2.Enabled) errorImageBox2.Enabled = false;
            }

            if(pathTextBox.Text == "")
            {
                if (!errorImageBox3.Enabled) errorImageBox3.Enabled = true;
                if (!errorImageBox3.Enabled) errorImageBox3.Enabled = true;
                if (!error) error = true;
            }
            else
            {
                if (errorImageBox3.Enabled) errorImageBox3.Enabled = false;
                if (errorImageBox3.Enabled) errorImageBox3.Enabled = false;
            }

            if(registryControl.CheckName(nameTextBox.Text))
            {
                if (!errorTextBox.Enabled) errorTextBox.Enabled = true;
                if (!errorTextBox.Enabled) errorTextBox.Enabled = true;
            }
            else
            {
                if (errorTextBox.Enabled) errorTextBox.Enabled = false;
                if (errorTextBox.Enabled) errorTextBox.Enabled = false;
            }

            if (error)
                return;
            else
            {
                projectInfo.Name = nameTextBox.Text;
                projectInfo.ProgLanguage = languageComboBox.Text;
                projectInfo.Path = pathTextBox.Text;
                projectInfo.Description = descriptionTextBox.Text;
                projectInfo.GitHub = githubTextBox.Text;
                isOk = true;
                Close();
            }
        }

        private void pathChoiceButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                    pathTextBox.Text = fbd.SelectedPath;
            }
        }
    }
}
