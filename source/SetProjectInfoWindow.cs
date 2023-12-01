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
    public partial class SetProjectInfoWindow : Form
    {
        public ProjectInfo projectInfo;
        private readonly RegistryControl registryControl;

        public SetProjectInfoWindow(Localisation _locale)
        {
            InitializeComponent();
            projectInfo = new ProjectInfo();
            registryControl = new RegistryControl();
            SetLocale(_locale);
        }

        public SetProjectInfoWindow(ProjectInfo _projectInfo, Localisation _locale)
        {
            InitializeComponent();
            projectInfo = new ProjectInfo(_projectInfo);
            registryControl = new RegistryControl();
            SetLocale(_locale);
            SetText();
        }

        private void SetLocale(Localisation locale)
        {
            nameLable.Text = locale.Name;
            descriptionLable.Text = locale.Description;
            pathLable.Text = locale.Path;
            confirmButton.Text = locale.ConfirmButton;
            cancelbutton.Text = locale.CancelButton;
            languageLable.Text = locale.ProgLanguage;
            pathErrorTextBox.Text = locale.DoesntExistError;
            errorToolTip.SetToolTip(errorImageBox1, locale.RequiredFieldToolTip);
            errorToolTip.SetToolTip(errorImageBox2, locale.RequiredFieldToolTip);
            errorToolTip.SetToolTip(errorImageBox3, locale.RequiredFieldToolTip);
        }

        private void SetText()
        {
            nameTextBox.Text = projectInfo.Name;
            descriptionTextBox.Text = projectInfo.Description;
            pathTextBox.Text = projectInfo.Path;
            githubTextBox.Text = projectInfo.GitHub;
            languageComboBox.Text = projectInfo.ProgLanguage;
        }


        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            if(nameTextBox.Text == string.Empty)
            {
                if (!errorImageBox1.Visible) errorImageBox1.Visible = true;
                if(!error) error = true;
            }
            else
                if (errorImageBox1.Visible) errorImageBox1.Visible = false;

            if(languageComboBox.Text == string.Empty)
            {
                if (!errorImageBox2.Visible) errorImageBox2.Visible = true;
                if (!error) error = true;
            }
            else
                if (errorImageBox2.Visible) errorImageBox2.Visible = false;

            if(pathTextBox.Text == string.Empty)
            {
                if (!errorImageBox3.Visible) errorImageBox3.Visible = true;
                if (!error) error = true;
            }
            else
                if (errorImageBox3.Visible) errorImageBox3.Visible = false;

            if(registryControl.CheckName(nameTextBox.Text) && nameTextBox.Text != projectInfo.Name)
            {
                if (!nameErrorTextBox.Visible) nameErrorTextBox.Visible = true;
                if (!error) error = true;
            }
            else
                if (nameErrorTextBox.Visible) nameErrorTextBox.Visible = false;

            if (error)
                return;
            else
            {
                projectInfo.Name = nameTextBox.Text;
                projectInfo.ProgLanguage = languageComboBox.Text;
                projectInfo.Path = pathTextBox.Text;
                projectInfo.Description = descriptionTextBox.Text;
                projectInfo.GitHub = githubTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void PathChoiceButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                    pathTextBox.Text = fbd.SelectedPath;
            }
        }
    }
}
