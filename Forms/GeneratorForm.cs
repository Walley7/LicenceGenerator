using CSACore.Core;
using CSACore.Licencing;
using Essy.Tools.InputBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LicenceGenerator.Forms {

    public partial class GeneratorForm : Form {
        //================================================================================
        //--------------------------------------------------------------------------------
        public GeneratorForm() {
            // Initialise
            InitializeComponent();

            // Application
            Text = $"Licence Generator{(!string.IsNullOrWhiteSpace(Program.ApplicationName) ? " - " + Program.ApplicationName : "")}";
            btnGenerateLicence.Enabled = Program.CanGenerate;

            // Type
            cboType.SelectedIndex = 0;

            // Expiry
            dteExpiry.Value = DateTime.Now.AddDays(1);
        }


        // NAVIGATION ================================================================================
        //-------------------------------------------------------------------------------- 
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }


        // KEY GENERATION ================================================================================
        //--------------------------------------------------------------------------------
        private void btnGenerateApplicationKeys_Click(object sender, EventArgs e) {
            // Pass phrase
            string passPhrase = InputBox.ShowInputBox("Enter a pass phrase:");
            if (string.IsNullOrWhiteSpace(passPhrase))
                return;

            // Generate
            CSA.Licencer.GenerateApplicationKeys(passPhrase, out string privateKey, out string publicKey);

            // Message
            string message = $"Pass Phrase: {passPhrase}\nPrivate Key: {privateKey}\nPublic Key: {publicKey}";
            Clipboard.SetText(message);

            // Show
            MessageBox.Show(message + "\n(These have been copied to the clipboard)", "Licence Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // TYPE ================================================================================
        //--------------------------------------------------------------------------------
        public LicenceType Type {
            get {
                switch (cboType.Text) {
                    case "Standard":    return LicenceType.STANDARD;
                    case "Trial":       return LicenceType.TRIAL;
                    default:            return LicenceType.STANDARD;
                }
            }
        }

        
        // MAXIMUM USERS ================================================================================
        //--------------------------------------------------------------------------------
        private void chkMaximumUsers_CheckedChanged(object sender, EventArgs e) {
            numMaximumUsers.Enabled = chkMaximumUsers.Checked;
        }
        
        
        // EXPIRY ================================================================================
        //--------------------------------------------------------------------------------
        private void chkExpiry_CheckedChanged(object sender, EventArgs e) {
            dteExpiry.Enabled = chkExpiry.Checked;
            btnThirtyDaysExpiry.Enabled = chkExpiry.Checked;
            btnThreeMonthsExpiry.Enabled = chkExpiry.Checked;
            btnOneYearExpiry.Enabled = chkExpiry.Checked;
        }
        
        //--------------------------------------------------------------------------------
        private void btnThirtyDaysExpiry_Click(object sender, EventArgs e) {
            dteExpiry.Value = DateTime.Now.AddDays(30);
        }
        
        //--------------------------------------------------------------------------------
        private void btnThreeMonthsExpiry_Click(object sender, EventArgs e) {
            dteExpiry.Value = DateTime.Now.AddMonths(3);
        }
        
        //--------------------------------------------------------------------------------
        private void btnOneYearExpiry_Click(object sender, EventArgs e) {
            dteExpiry.Value = DateTime.Now.AddYears(1);
        }
        
        
        // LICENCE GENERATION ================================================================================
        //--------------------------------------------------------------------------------
        private void btnGenerateLicence_Click(object sender, EventArgs e) {
            txtLicence.Text = CSA.Licencer.GenerateLicence(Program.PrivateKey, Program.PassPhrase, Type, chkMaximumUsers.Checked ? (int)numMaximumUsers.Value : 0, chkExpiry.Checked ? (DateTime?)dteExpiry.Value : null);
            Clipboard.SetText(txtLicence.Text);
        }
    }

}
