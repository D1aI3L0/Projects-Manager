using source.Properties;
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
        private Localisation locale;
        private readonly RegistryControl registryControl;

        public SetProjectInfoWindow(Localisation _locale)
        {
            InitializeComponent();
            projectInfo = new ProjectInfo();
            registryControl = new RegistryControl();
            locale = _locale;
            SetLocale();
        }

        public SetProjectInfoWindow(ProjectInfo _projectInfo, Localisation _locale)
        {
            InitializeComponent();
            projectInfo = new ProjectInfo(_projectInfo);
            registryControl = new RegistryControl();
            locale = _locale;
            SetLocale();
            SetText();
        }

        private void SetLocale()
        {
            nameLable.Text = locale.Name;
            descriptionLable.Text = locale.Description;
            pathLable.Text = locale.Path;
            confirmButton.Text = locale.ConfirmButton;
            cancelbutton.Text = locale.CancelButton;
            languageLable.Text = locale.ProgLanguage;
            errorToolTip.SetToolTip(errorImageBox2, locale.RequiredFieldToolTip);
        }

        private void SetText()
        {
            nameTextBox.Text = projectInfo.Name;
            descriptionTextBox.Text = projectInfo.Description;
            pathTextBox.Text = projectInfo.Path;
            githubTextBox.Text = projectInfo.GitHub;
            languageComboBox.Text = projectInfo.ProgLanguage;
        }

        private void SetInfo()
        {
            projectInfo.Name = nameTextBox.Text;
            projectInfo.Description = descriptionTextBox.Text;
            projectInfo.Path = pathTextBox.Text;
            projectInfo.GitHub = githubTextBox.Text;
            projectInfo.ProgLanguage = languageComboBox.Text;
        }

        private bool CheckInfo()
        {
            bool error = false;

            if (nameTextBox.Text == string.Empty)
            {
                errorToolTip.SetToolTip(errorImageBox1, locale.RequiredFieldToolTip);
                if (!errorImageBox1.Visible) errorImageBox1.Visible = true;
                if (!error) error = true;
            }
            else if (registryControl.CheckName(nameTextBox.Text) && nameTextBox.Text != projectInfo.Name)
            {
                errorToolTip.SetToolTip(errorImageBox1, locale.AlreadyExistError);
                if (!errorImageBox1.Visible) errorImageBox1.Visible = true;
                if (!error) error = true;
            }
            else
                if (errorImageBox1.Visible) errorImageBox1.Visible = false;

            if (languageComboBox.Text == string.Empty)
            {
                if (!errorImageBox2.Visible) errorImageBox2.Visible = true;
                if (!error) error = true;
            }
            else
                if (errorImageBox2.Visible) errorImageBox2.Visible = false;

            if (!projectInfo.CheckPath(pathTextBox.Text) && pathTextBox.Text != string.Empty)
            {
                errorToolTip.SetToolTip(errorImageBox3, locale.DoesntExistError);
                if (!errorImageBox3.Visible) errorImageBox3.Visible = true;
                if (!error) error = true;
            }
            else
                if (errorImageBox3.Visible) errorImageBox3.Visible = false;

            return !error;
        }


        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(CheckInfo())
            {
                SetInfo();
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (DialogResult != DialogResult.Cancel)
            {
                if (CheckInfo() && DialogResult != DialogResult.OK)
                {
                    if (MessageBox.Show("Do you want to save project info?", "Set info",
                         MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }
    }
}
