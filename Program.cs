using CSACore.Core;
using LicenceGenerator.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LicenceGenerator {

    static class Program {
        //================================================================================
        // https://github.com/junian/Standard.Licensing
        //================================================================================
        public const string                     CONFIGURATION_PATH = "LicenceGenerator.json";


        //================================================================================
        private static string                   sApplicationName;
        private static string                   sPrivateKey;
        private static string                   sPublicKey;
        private static string                   sPassPhrase;


        //================================================================================
        //--------------------------------------------------------------------------------
        [STAThread]
        static void Main() {
            // Initialise - winforms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Initialise - CSA
            try { CSA.Initialise(CONFIGURATION_PATH); }
            catch (Exception e) {
                MessageBox.Show("Failed to initialise: " + e.Message, "Licence Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Settings
            try {
                sApplicationName = CSA.Setting("ApplicationName", false, false);
                sPrivateKey = CSA.Setting("PrivateKey", false, false);
                sPublicKey = CSA.Setting("PublicKey", false, false);
                sPassPhrase = CSA.Setting("PassPhrase", false, false);
            }
            catch (Exception e) {
                MessageBox.Show("Failed to read configuration: " + e.Message, "Licence Generator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Run
            try { Application.Run(new GeneratorForm()); }
            finally {
                // Shutdown
                CSA.Shutdown();
            }
        }


        // LICENCING ================================================================================
        //--------------------------------------------------------------------------------
        public static string ApplicationName { get { return sApplicationName; } }
        public static string PrivateKey { get { return sPrivateKey; } }
        public static string PublicKey { get { return sPublicKey; } }
        public static string PassPhrase { get { return sPassPhrase; } }
        public static bool CanGenerate { get { return !string.IsNullOrWhiteSpace(sApplicationName) && !string.IsNullOrWhiteSpace(sPrivateKey) && !string.IsNullOrWhiteSpace(sPassPhrase); } }
    }

}
