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
    }
}
