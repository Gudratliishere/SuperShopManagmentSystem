using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDesktop.DesktopConfiguration
{
    public class LanguageConfig
    {
        public enum Language { Az, En };

        private const string iniFilePath = "language.ini";
        private static IniFile ini = new IniFile(iniFilePath);

        public static Language language = Language.En;
        public static ResourceManager RM =
            new ResourceManager("SuperShopDesktop.Language.Az", Assembly.GetExecutingAssembly());

        public static void WriteLanguage (string lang)
        {
            if (lang.ToLower().Equals("az") || lang.ToLower().Equals("en"))
                ini.Write("Language", lang.ToLower());
        }

        public static void LoadResource ()
        {
            ReadLanguage();
            switch (language)
            {
                case Language.En:
                    RM = new ResourceManager("SuperShopDesktop.Language.En", Assembly.GetExecutingAssembly());
                    break;
                case Language.Az:
                    RM = new ResourceManager("SuperShopDesktop.Language.Az", Assembly.GetExecutingAssembly());
                    break;
            }
        }

        private static void ReadLanguage ()
        {
            if (ini.KeyExists("Language"))
            {
                switch (ini.Read("Language"))
                {
                    case "az":
                        language = Language.Az;
                        break;
                    case "en":
                        language = Language.En;
                        break;
                }
            }
        }
    }
}
