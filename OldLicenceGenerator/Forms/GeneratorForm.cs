using DevExpress.XtraEditors;
using Standard.Licensing;
using Standard.Licensing.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace LicenceGenerator.Forms {

    public partial class GeneratorForm : DevExpress.XtraEditors.XtraForm {
        //================================================================================
        // https://github.com/junian/Standard.Licensing
        //================================================================================
        public const string                     PRIVATE_KEY = @"MHcwIwYKKoZIhvcNAQwBAzAVBBBn9fV46fn5X2nufUtaQyiTAgEKBFDCNkPjoI7NSRcafbC4NI/MO5QC0MDWJHf836vkULT/7OFfIDvGOI0sWvNCOOYO7t3WpIPToVlscGYkfFsc7R00e7gYA6Ok0vvLRbqmZ2rmSg==";
        public const string                     PASS_PHRASE = @"FileMeMasterKey";


        //================================================================================
        private License                         mLicence;


        //================================================================================
        //--------------------------------------------------------------------------------
        public GeneratorForm() {
            InitializeComponent();
        }


        // NAVIGATION ================================================================================
        //-------------------------------------------------------------------------------- 
        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }


        // LICENCES ================================================================================
        //--------------------------------------------------------------------------------
        private void btnCreateLicence_Click(object sender, EventArgs e) {
            // Checks
            if (string.IsNullOrWhiteSpace(txtLicencee.Text)) {
                XtraMessageBox.Show("Please enter a licencee.", "File Me Licence Generator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLicencee.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLicenceeEmail.Text)) {
                XtraMessageBox.Show("Please enter a licencee e-mail.", "File Me Licence Generator", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLicenceeEmail.Focus();
                return;
            }

            // Licence builder
            ILicenseBuilder licenceBuilder = License.New()
                .WithUniqueIdentifier(Guid.NewGuid())
                .As(cboType.SelectedIndex == 0 ? LicenseType.Standard : LicenseType.Trial)
                //.WithProductFeatures(new Dictionary<string, string> { { "Unused Options", chkUnusedOption.Checked.ToString() } })
                .LicensedTo(txtLicencee.Text, txtLicenceeEmail.Text);

            // Maximum users
            if (spnMaximumUsers.Value > 0)
                licenceBuilder.WithMaximumUtilization((int)spnMaximumUsers.Value);

            // Expiry
            if (chkExpiry.Checked)
                licenceBuilder.ExpiresAt(dteExpiry.DateTime);

            // Licence
            mLicence = licenceBuilder.CreateAndSignWithPrivateKey(PRIVATE_KEY, PASS_PHRASE);
            memLicence.Text = mLicence.ToString();
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
            dteExpiry.DateTime = DateTime.Now.AddDays(30);
        }
        
        //--------------------------------------------------------------------------------
        private void btnThreeMonthsExpiry_Click(object sender, EventArgs e) {
            dteExpiry.DateTime = DateTime.Now.AddMonths(3);
        }

        //--------------------------------------------------------------------------------
        private void btnOneYearExpiry_Click(object sender, EventArgs e) {
            dteExpiry.DateTime = DateTime.Now.AddYears(1);
        }


        // KEY GENERATION ================================================================================
        //--------------------------------------------------------------------------------
        private void btnGenerateKeys_Click(object sender, EventArgs e) {
            // Pass phrase
            string passPhrase = XtraInputBox.Show("Enter a pass phrase:", "File Me Licence Generator", "");
            if (passPhrase.Equals(""))
                return;

            // Keys
            KeyGenerator keyGenerator = KeyGenerator.Create();
            KeyPair keyPair = keyGenerator.GenerateKeyPair();
            string privateKey = keyPair.ToEncryptedPrivateKeyString(passPhrase);
            string publicKey = keyPair.ToPublicKeyString();

            // Message
            string message = "Pass Phrase: " + passPhrase + "\nPrivate Key: " + privateKey + "\nPublic Key: " + publicKey;
            Clipboard.SetText(message);

            // Show
            XtraMessageBox.Show(message + "\n(These have been copied to the clipboard)",
                                "File Me Licence Generator", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
