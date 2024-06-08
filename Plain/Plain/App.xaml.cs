using Plain.Properties;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Plain
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static void ToggleBackgroundMode()
        {
            Settings.Default.LightMode = !Settings.Default.LightMode;

            Settings.Default.Save();
        }
    }
}
