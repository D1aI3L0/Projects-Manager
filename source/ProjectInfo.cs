using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace source
{
    public class ProjectInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string GitHub { get; set; }
        public string ProgLanguage { get; set; }

        public ProjectInfo() { }

        public ProjectInfo(ProjectInfo other)
        {
            Name = other.Name;
            Description = other.Description;
            Path = other.Path;
            GitHub = other.GitHub;
            ProgLanguage = other.ProgLanguage;
        }

        public ProjectInfo(string name, string description, string path, string gitHub, string progLanguage)
        {
            Name = name;
            Description = description;
            Path = path;
            GitHub = gitHub;
            ProgLanguage = progLanguage;
        }

        public bool Compare(ProjectInfo other)
        {
            if(other == null) return false;
            if(other.Name != Name) return false;
            if(other.Path != Path) return false;
            if(other.Description != Description) return false;
            if(other.ProgLanguage != ProgLanguage) return false;
            if(other.GitHub != GitHub) return false;
            return true;
        }

        public void Clear()
        {
            Name = string.Empty;
            Path = string.Empty;
            GitHub = string.Empty;
            ProgLanguage = string.Empty;
            Description = string.Empty;
        }


        public bool CheckPath()
        {
            try
            {
                File.GetAttributes(Path);
                return true;
            }
            catch { return false; }
        }

        public bool CheckPath(string path)
        {
            try
            {
                File.GetAttributes(path);
                return true;
            }
            catch { return false; }
        }


        public bool Equals(ProjectInfo _other)
        {
            if (_other == null) return false;
            if (Name != _other.Name) return false;
            if (Path != _other.Path) return false;
            if (GitHub != _other.GitHub) return false;
            if (ProgLanguage != _other.ProgLanguage) return false;
            if (Description != _other.Description) return false;
            return true;
        }
    }
}
