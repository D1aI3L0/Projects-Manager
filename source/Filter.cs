using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace source
{
    public class Filter
    {
        public string SubName { get; set; }
        public List<string> ProgLanguages { get; set; }

        public Filter()
        {
            SubName = string.Empty;
            ProgLanguages = new List<string>();
        }

        public Filter(string _subName, List<string> _progLanguages) 
        { 
            SubName = _subName;
            ProgLanguages = _progLanguages;
        }

        public bool Compare(Filter _other)
        {
            if (SubName != _other.SubName) return false;
            if (ProgLanguages != _other.ProgLanguages) return false;
            return true;
        }

        public void Clear()
        {
            SubName = string.Empty;
            ProgLanguages.Clear();
        }

        public bool IsEmpty()
        {
            return ProgLanguages.Count == 0 && SubName == string.Empty;
        }


        public bool Equals(Filter _other)
        {
            if (SubName != _other.SubName) return false;
            if (ProgLanguages != _other.ProgLanguages) return false;
            return true;
        }
    }
}
