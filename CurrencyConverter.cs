using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CurrencyConverter
{
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void btnCurrencyConv_Click(object sender, EventArgs e)
        {
            wbBody.Navigate("https://www.exchange-rates.org/converter/");
        }

        private void CurrencyConverter_Load(object sender, EventArgs e)
        {
            string appName = Process.GetCurrentProcess().ProcessName + ".exe";
            SetIEkeyBrowserContrl(appName);
            wbBody.Navigate("https://www.exchange-rates.org/converter/");
        }
        static void SetIEkeyBrowserContrl(string appName)
        {
            RegistryKey regKey = null;
            try
            {
                if (Environment.Is64BitOperatingSystem)
                    regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Wow6432Node\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                else
                    regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                if (regKey == null)
                {
                    MessageBox.Show("Failed to save settings. Address not found");
                    return;
                }
                int key = Convert.ToInt32( regKey.GetValue(appName));
                if (key <= 0)
                    regKey.SetValue(appName, unchecked((int)0x2AF8), RegistryValueKind.DWord);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured while doing reg setup -  " + ex.Message);
            }
            finally
            {
                if (regKey != null) regKey.Close();
            }
        }

    }
}
