using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopDesktop.DesktopConfiguration;

namespace SuperShopDesktop.Main.Menu
{
    public partial class Settings : UserControl
    {
        public Settings ()
        {
            InitializeComponent();
        }

        private void gcb_language_SelectedIndexChanged (object sender, EventArgs e)
        {
            LanguageConfig.WriteLanguage(gcb_language.SelectedValue.ToString());
            LanguageConfig.LoadResource();
        }

        private void Settings_Load (object sender, EventArgs e)
        {
            var list = new List<Language>();
            list.Add(new Language("az", LanguageConfig.RM.GetString("Main_Settings_cb_azerbaijan")));
            list.Add(new Language("en", LanguageConfig.RM.GetString("Main_Settings_cb_english")));
            gcb_language.DataSource = list;
            gcb_language.DisplayMember = "Name";
            gcb_language.ValueMember = "Id";

            switch (LanguageConfig.language)
            {
                case LanguageConfig.Language.Az:
                    gcb_language.SelectedValue = "az";
                    break;
                case LanguageConfig.Language.En:
                    gcb_language.SelectedValue = "en";
                    break;
            }

            LoadControlTexts();
        }

        private void LoadControlTexts ()
        {
            lbl_language.Text = LanguageConfig.RM.GetString("Main_Settings_lbl_language");
        }
    }

    class Language
    {
        public Language (string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}
