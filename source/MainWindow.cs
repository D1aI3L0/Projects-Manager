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
        private Collection<ProjectInfo> projectsInfo;
        private Settings settings;
        public MainWindow()
        {
            InitializeComponent();
            registryControl = new RegistryControl();
            projectsInfo = new Collection<ProjectInfo>();
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
    }
}
