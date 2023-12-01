using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace source
{
    public partial class MainWindow : Form
    {
        private readonly RegistryControl registryControl;
        private List<ProjectInfo> projectsInfo;
        private ProjectInfo curProject;
        private Settings settings;
        private Localisation locale;

        public MainWindow()
        {
            InitializeComponent();
            registryControl = new RegistryControl();
            projectsInfo = new List<ProjectInfo>();
            RefreshList();
            foreach (var item in projectsListComboBox.Items)
                projectsInfo.Add(registryControl.GetProjectInfo(item.ToString()));
            settings = registryControl.GetSettings();
            locale = new Localisation();
            locale.GetLocalisation(settings.Language);
            SetLocale();
        }

        private void SetLocale()
        {
            openWithButton.Text = locale.OpenButton;
            editProjectButton.Text = locale.EditButton;
            deleteProjectButton.Text = locale.DeleteButton;
            pathErrorTextBox.Text = locale.DoesntExistError;
            addProjectToolTip.SetToolTip(addProjectButton, locale.AddProjectToolTip);
            toolTip.SetToolTip(addProjectButton, locale.AddProjectToolTip);
            toolTip.SetToolTip(settingsButton, locale.Settings);
        }

        private void ProjectsListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            curProject = registryControl.GetProjectInfo(projectsListComboBox.Text);
            ShowInfo();
        }

        private void ShowInfo()
        {
            nameTextBox.Text = curProject.Name;
            descriptionTextBox.Text = curProject.Description;
            languageTextBox.Text = curProject.ProgLanguage;

            pathTextBox.Text = curProject.Path;
            if (curProject.CheckPath())
            {
                if (!openWithButton.Visible) openWithButton.Visible = true;
                if (pathErrorTextBox.Visible) pathErrorTextBox.Visible = false;
            }
            else
            {
                if (!pathErrorTextBox.Visible) pathErrorTextBox.Visible = true;
                if (openWithButton.Visible) openWithButton.Visible = false;
            }


            if (curProject.GitHub != string.Empty)
            {
                if (!githubButton.Visible) githubButton.Visible = true;
            }
            else
                if (githubButton.Visible) githubButton.Visible = false;


            if (!editProjectButton.Visible) editProjectButton.Visible = true;
            if (!deleteProjectButton.Visible) deleteProjectButton.Visible = true;
        }

        private void RefreshList()
        {
            projectsListComboBox.Items.Clear();
            projectsListComboBox.Items.AddRange(registryControl.GetNames());
            projectsListComboBox.Update();
            projectsListComboBox.Text = string.Empty;
        }

        private void AddNewProjectButton_Click(object sender, EventArgs e)
        {
            SetProjectInfoWindow setProjectInfo = new SetProjectInfoWindow(locale);
            
            if (setProjectInfo.ShowDialog() == DialogResult.OK)
            {
                projectsInfo.Add(setProjectInfo.projectInfo);
                registryControl.SetProjectInfo(setProjectInfo.projectInfo);
                RefreshList();
            }
        }

        private void GithubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(curProject.GitHub);
        }

        private void EditProjectButton_Click(object sender, EventArgs e)
        {
            SetProjectInfoWindow setProjectInfo = new SetProjectInfoWindow(curProject, locale);

            if (setProjectInfo.ShowDialog() == DialogResult.OK)
            {
                if (!curProject.Compare(setProjectInfo.projectInfo))
                {
                    if (curProject.Name != setProjectInfo.projectInfo.Name)
                        registryControl.DeleteProject(curProject.Name);
                    curProject = setProjectInfo.projectInfo;
                    registryControl.SetProjectInfo(curProject);
                    ShowInfo();

                    RefreshList();
                    projectsListComboBox.Text = setProjectInfo.projectInfo.Name;
                }
            }
        }

        private void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm deleting project \"" + curProject.Name + "\"", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                registryControl.DeleteProject(curProject.Name);
                curProject.Clear();
                ShowInfo();
                RefreshList();

                openWithButton.Visible = false;
                editProjectButton.Visible = false;
                deleteProjectButton.Visible = false;
                if (pathErrorTextBox.Visible) pathErrorTextBox.Visible = false;
            }
        }

        private void OpenWith_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(curProject.Path);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow(settings, locale);

            if(settingsWindow.ShowDialog() == DialogResult.OK)
            {
                if(!settings.Compare(settingsWindow.settings))
                    settings = settingsWindow.settings;

                locale.GetLocalisation(settings.Language);
                SetLocale();
            }
        }
    }
}
