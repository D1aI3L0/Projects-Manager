using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace source
{
    public class Settings
    {
        public string Language { get; set; }

        public Settings() { }

        public Settings(Settings _other)
        {
            this.Language = _other.Language;
        }

        public bool Compare(Settings _other) 
        {
            if(this.Language != _other.Language) return false;
            return true;
        }
    }
}
