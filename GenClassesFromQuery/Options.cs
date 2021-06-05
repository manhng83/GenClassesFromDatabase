using JsonSettings.Library;
using System.IO;
using WinForms.Library.Models;

namespace GenClassesFromDatabase
{
    public class Options : SettingsBase
    {
        public FormPosition MainFormPosition { get; set; }
        public string ActiveConnection { get; set; }

        public override string Filename => BuildPath(System.Environment.SpecialFolder.ApplicationData, "GenClassesFromDatabase", "settings.json");

        public string Folder { get => Path.GetDirectoryName(Filename); }
    }
}