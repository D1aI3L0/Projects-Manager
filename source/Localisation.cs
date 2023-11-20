using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace source
{
    internal class Localisation
    {
        private readonly string BaseFilePath = "~\\Resources\\localn_";
        public void GetLocalisation(string language)
        {
            StreamReader local = new StreamReader(BaseFilePath+language+".txt");
        }
    }
}
