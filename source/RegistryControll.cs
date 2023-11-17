using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Manager
{
    internal class RegistryControl
    {
        private static readonly string ManagerKeyName = "ProjectsManager";

        public RegistryControl()
        {
            RegistryKey key;
            while ((key = Registry.CurrentUser.OpenSubKey("Software\\" + ManagerKeyName)) == null)
                CreateProjectsKeys();
        }

        private void CreateProjectsKeys()
        {
            RegistryKey managerKey = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey(ManagerKeyName);
            managerKey.SetValue("Language", (string)"English");
            managerKey.Close();
        }

        private ProjectInfo GetProjectInfo(string name)
        {
            ProjectInfo projectInfo = new ProjectInfo();
            RegistryKey managerKey = Registry.CurrentUser.OpenSubKey("Software\\" + ManagerKeyName + "\\" + name);
            projectInfo.Name = name;
            projectInfo.Path = (string)managerKey.GetValue("Path");
            projectInfo.Description = (string)managerKey.GetValue("Description");
            projectInfo.GitHub = (string)managerKey.GetValue("GitHub");
            return projectInfo;
        }

        private void SetProjectInfo(ProjectInfo projectInfo)
        {
            RegistryKey managerKey = Registry.CurrentUser.OpenSubKey("Software\\" + ManagerKeyName, true).CreateSubKey(projectInfo.Name);
            managerKey.SetValue("Path", projectInfo.Path);
            managerKey.SetValue("Description", projectInfo.Description);
            managerKey.SetValue("GitHub", projectInfo.GitHub);
        }

        private void DeleteProject(string name)
        {
            Registry.CurrentUser.OpenSubKey("Software\\" + ManagerKeyName, true).DeleteSubKeyTree(name);
        }
    }
}
