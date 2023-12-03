using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace source
{
    public class Settings
    {
        public string Language { get; set; }

        public MainWindow MainWindow
        {
            get => default;
            set
            {
            }
        }

        public SettingsWindow SettingsWindow
        {
            get => default;
            set
            {
            }
        }

        public Settings() { }

        public Settings(Settings _other)
        {
            Language = _other.Language;
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
