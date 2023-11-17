using Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace source
{
    public partial class MainWindow : Form
    {
        private RegistryControl registryControl;
        private ProjectInfo projectInfo;
        private Settings settings;
        public MainWindow()
        {
            InitializeComponent();
            registryControl = new RegistryControl();
            projectInfo = new ProjectInfo();
        }
    }
}
