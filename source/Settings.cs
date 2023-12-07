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
            Language = _other.Language;
        }

        public Settings(string language)
        {
            Language = language;
        }

        public bool Compare(Settings _other) 
        {
            return Equals(_other);
        }


        public bool Equals(Settings _other)
        {
            if (Language != _other.Language) return false;
            return true;
        }
    }
}
