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
        }
    }
}
