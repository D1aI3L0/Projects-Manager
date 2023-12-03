using Microsoft.Win32;
using source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace source
{
    public class RegistryControl
    {
        public RegistryControl()
        {
            while (Registry.CurrentUser.OpenSubKey("Software\\ProjectsManager", true) == null)
                CreateProjectsKeys();
        }

        public MainWindow MainWindow
        {
            get => default;
            set
            {
            }
        }

        public SetProjectInfoWindow SetProjectInfoWindow
        {
            get => default;
            set
            {
            }
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

        public string[] GetNamesFiltered(Filter filter)
        {
            List<string> names = new List<string>();
            foreach (var name in Registry.CurrentUser.OpenSubKey("Software\\ProjectsManager", true).GetSubKeyNames())
            {
                if (filter.SubName != string.Empty)
                    if (!name.Contains(filter.SubName))
                        continue;

                RegistryKey managerKey = Registry.CurrentUser.OpenSubKey("Software\\ProjectsManager\\" + name);

                if (filter.ProgLanguages.Count != 0)
                    if (!filter.ProgLanguages.Contains((string)managerKey.GetValue("ProgLanguage")))
                        continue;

                names.Add(name);
            }

            return names.ToArray();
        }

        public Settings GetSettings() 
        {
            Settings settings = new Settings();
            RegistryKey managerKey = Registry.CurrentUser.OpenSubKey("Software\\ProjectsManager\\", true);
            settings.Language = (string)managerKey.GetValue("Language");
            return settings;
        }

        public void SetSettings(Settings settings)
        {
            RegistryKey managerKey = Registry.CurrentUser.OpenSubKey("Software\\ProjectsManager\\", true);
            managerKey.SetValue("Language", settings.Language);
        }
    }
}
