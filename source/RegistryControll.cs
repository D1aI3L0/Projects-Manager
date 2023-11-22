using Microsoft.Win32;
using source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace source
{
    internal class RegistryControl
    {
        public RegistryControl()
        {
            RegistryKey key;
            while ((key = Registry.CurrentUser.OpenSubKey("Software\\ProjectsManager", true)) == null)
                CreateProjectsKeys();
        }

        public void CreateProjectsKeys()
        {
            RegistryKey managerKey = Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey("ProjectsManager");
            managerKey.SetValue("Language", (string)"English");
            managerKey.Close();
        }

        public ProjectInfo GetProjectInfo(string name)
        {
            ProjectInfo projectInfo = new ProjectInfo();
            RegistryKey managerKey = Registry.CurrentUser.OpenSubKey("Software\\ProjectsManager\\" + name);
            projectInfo.Name = name;
            projectInfo.Path = (string)managerKey.GetValue("Path");
            projectInfo.Description = (string)managerKey.GetValue("Description");
            projectInfo.GitHub = (string)managerKey.GetValue("GitHub");
            projectInfo.ProgLanguage = (string)managerKey.GetValue("ProgLanguage");
            return projectInfo;
        }

        public void SetProjectInfo(ProjectInfo projectInfo)
        {
            RegistryKey managerKey = Registry.CurrentUser.OpenSubKey("Software\\ProjectsManager\\" + projectInfo.Name, true);
            if (managerKey == null)
              managerKey = Registry.CurrentUser.OpenSubKey("Software\\ProjectsManager", true).CreateSubKey(projectInfo.Name);
            managerKey.SetValue("Path", projectInfo.Path);
            managerKey.SetValue("Description", projectInfo.Description);
            managerKey.SetValue("GitHub", projectInfo.GitHub);
            managerKey.SetValue("ProgLanguage", projectInfo.ProgLanguage);
        }

        public void DeleteProject(string name)
        {
            Registry.CurrentUser.OpenSubKey("Software\\ProjectsManager", true).DeleteSubKeyTree(name);
        }

        public bool CheckName(string name)
        {
            return GetNames().Contains(name);
        }

        public string[] GetNames()
        {
            return Registry.CurrentUser.OpenSubKey("Software\\ProjectsManager", true).GetSubKeyNames();
        }
    }
}
