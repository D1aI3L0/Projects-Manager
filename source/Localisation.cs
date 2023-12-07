using source.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace source
{
    public class Localisation
    {
        public string OpenButton { get; set; }
        public string EditButton { get; set; }
        public string DeleteButton { get; set; }
        public string ConfirmButton { get; set; }
        public string CancelButton { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string ProgLanguage { get; set; }
        public string AlreadyExistError { get; set; }
        public string DoesntExistError { get; set; }
        public string AddProjectToolTip { get; set; }
        public string RequiredFieldToolTip { get; set; }
        public string Settings { get; set; }
        public string Language { get; set; }


        public Localisation() { }

        public Localisation(string openButton, string editButton, string deleteButton, string cancelButton, string confirmButton, string name, string path, string description, string progLanguage, string alreadyExistError, string doesntExistError, string addProjectToolTip, string requiredFieldToolTip, string settings, string language)
        {
            OpenButton = openButton;
            EditButton = editButton;
            DeleteButton = deleteButton;
            CancelButton = cancelButton;
            ConfirmButton = confirmButton;
            Name = name;
            Path = path;
            Description = description;
            ProgLanguage = progLanguage;
            AlreadyExistError = alreadyExistError;
            DoesntExistError = doesntExistError;
            AddProjectToolTip = addProjectToolTip;
            RequiredFieldToolTip = requiredFieldToolTip;
            Settings = settings;
            Language = language;
        }

        public Localisation(string _language)
        {
            GetLocalisation(_language);
        }

        public void GetLocalisation(string language)
        {
            StreamReader local = new StreamReader("..\\..\\Resources\\" + language + ".txt");
            
            OpenButton = local.ReadLine();
            EditButton = local.ReadLine();
            DeleteButton = local.ReadLine();
            CancelButton = local.ReadLine();
            ConfirmButton = local.ReadLine();   
            Name = local.ReadLine();
            Path = local.ReadLine();
            Description = local.ReadLine();
            ProgLanguage = local.ReadLine();
            AlreadyExistError = local.ReadLine();
            DoesntExistError = local.ReadLine();
            AddProjectToolTip = local.ReadLine();
            RequiredFieldToolTip = local.ReadLine();
            Settings = local.ReadLine();
            Language = local.ReadLine();

            local.Close();
        }


        public bool Equals(Localisation _other)
        {
            if(_other == null) return false;
            if (OpenButton != _other.OpenButton) return false;
            if (EditButton != _other.EditButton) return false;
            if (DeleteButton != _other.DeleteButton) return false;
            if (CancelButton != _other.CancelButton) return false;
            if (ConfirmButton != _other.ConfirmButton) return false;
            if (Name != _other.Name) return false;
            if (Path != _other.Path) return false;
            if (Description != _other.Description) return false;
            if (ProgLanguage != _other.ProgLanguage) return false;
            if (AlreadyExistError != _other.AlreadyExistError) return false;
            if (DoesntExistError != _other.DoesntExistError) return false;
            if (AddProjectToolTip != _other.AddProjectToolTip) return false;
            if (RequiredFieldToolTip != _other.RequiredFieldToolTip) return false;
            if (Settings != _other.Settings) return false;
            if (Language != _other.Language) return false;
            return true;
        }
    }
}
