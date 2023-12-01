using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace source
{
    public partial class SettingsWindow : Form
    {
        public Settings originalSettings;
        public Settings settings;
        public SettingsWindow(Settings _settings, Localisation _locale)
        {
            InitializeComponent();
            settings = _settings;
            originalSettings = _settings;
            SetLocale(_locale);
            SetText();
        }

        public void SetText()
        {
            languageComboBox.Text = settings.Language;
        }

        public void SetLocale(Localisation _locale)
        {
            languageLable.Text = _locale.Language;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            settings.Language = languageComboBox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (!originalSettings.Compare(settings) || DialogResult != DialogResult.OK)
            {
                if (MessageBox.Show("Do you want to save changes?", "Settings",
                       MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.Language = languageComboBox.Text;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
