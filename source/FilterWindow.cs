using source.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Windows.Forms;

namespace source
{
    public partial class FilterWindow : Form
    {
        public Filter filter;

        public FilterWindow(Localisation _locale)
        {
            InitializeComponent();
            SetLocale(_locale);
        }

        public FilterWindow(Filter _filter, Localisation _locale)
        {
            InitializeComponent();
            filter = _filter;
            SetFilter();
            SetLocale(_locale);
        }

        public MainWindow MainWindow
        {
            get => default;
            set
            {
            }
        }

        public void SetLocale(Localisation _locale)
        {
            progLangLable.Text = _locale.ProgLanguage;
            nameLable.Text = _locale.Name;
            confirmButton.Text = _locale.ConfirmButton;
            cancelbutton.Text = _locale.CancelButton;
        }

        public void SetFilter()
        {
            nameTextBox.Text = filter.SubName;
            foreach(var name in filter.ProgLanguages)
                progLangListCheckedBox.SetItemChecked(progLangListCheckedBox.FindStringExact(name), true);
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            SaveFilter();
            DialogResult = DialogResult.OK;
            Close();
        }

        public void SaveFilter()
        {
            filter.SubName = nameTextBox.Text;
            filter.ProgLanguages.Clear();
            foreach (var checkedItem in progLangListCheckedBox.CheckedItems)
                filter.ProgLanguages.Add(checkedItem.ToString());
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (DialogResult != DialogResult.Cancel)
            {
                if (DialogResult != DialogResult.OK)
                {
                    if (MessageBox.Show("Do you want to save filter?", "Filter",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SaveFilter();
                        DialogResult = DialogResult.OK;
                    }
                }
            }

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
