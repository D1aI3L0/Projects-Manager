using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace source
{
    public partial class MainWindow : Form
    {
        private RegistryControl registryControl;
        private List<ProjectInfo> projectsInfo;
        private ProjectInfo curProject;
        private Settings settings;
        public MainWindow()
        {
            InitializeComponent();
            registryControl = new RegistryControl();
            projectsInfo = new List<ProjectInfo>();
            projectsListComboBox.Items.AddRange(registryControl.GetNames());
            foreach (var item in projectsListComboBox.Items)
            {
                projectsInfo.Add(registryControl.GetProjectInfo(item.ToString()));
            }
        }

        private void addNewProjectButton_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject();
            addProject.ShowDialog();

            if(addProject.isOk)
            {
                projectsInfo.Add(addProject.projectInfo);
                registryControl.SetProjectInfo(addProject.projectInfo);
            }
        }

        private void projectsListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            curProject = registryControl.GetProjectInfo(projectsListComboBox.Text);
            nameTextBox.Text = curProject.Name;
            descriptionTextBox.Text = curProject.Description;
            languageTextBox.Text = curProject.ProgLanguage;

            pathTextBox.Text = curProject.Path;
            if(curProject.GitHub != "")
                if(!githubButton.Visible) githubButton.Visible = true;
            else
                if (githubButton.Visible) githubButton.Visible = false;

        }

        private void githubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Yandex.exe", githubButton.Text);
        }
    }
}
