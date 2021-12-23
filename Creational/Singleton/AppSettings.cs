using System;
using System.Text;
using IniParser;
using IniParser.Model;
using IniParser.Parser;

namespace DesignPattern.Creational.Singleton
{
     class AppSettings
    {
        private static IniData Config;
        private static AppSettings Instance = null;
        private static readonly object InstanceLock = new object();

        private AppSettings()
        {
            var parser = new FileIniDataParser();
            Config = parser.ReadFile("../../../Creational/Singleton/SettingsConfig.ini");
        }
        public static AppSettings GetInstance()
        {
            lock (InstanceLock)
            {
                if (Instance == null)
                    Instance = new AppSettings();
                return Instance;
            }
        }
        public static string GetConfig(string key)
        {
            var DataCollection = Config[key];
            StringBuilder Values = new StringBuilder();
            Values.AppendLine($"Configurations of {key}");
            foreach (var Data in DataCollection)
            {
                Values.AppendLine(Data.KeyName + ":" + Data.Value);
            }
            return Values.ToString() ?? null;
        }
    }
}
