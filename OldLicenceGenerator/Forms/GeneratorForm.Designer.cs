namespace LicenceGenerator.Forms {
    partial class GeneratorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm));
            this.btnGenerateKeys = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreateLicence = new DevExpress.XtraEditors.SimpleButton();
            this.memLicence = new DevExpress.XtraEditors.MemoEdit();
            this.cboType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkExpiry = new DevExpress.XtraEditors.CheckEdit();
            this.chkUnusedOption = new DevExpress.XtraEditors.CheckEdit();
            this.dteExpiry = new DevExpress.XtraEditors.DateEdit();
            this.btnThirtyDaysExpiry = new DevExpress.XtraEditors.SimpleButton();
            this.btnOneYearExpiry = new DevExpress.XtraEditors.SimpleButton();
            this.btnThreeMonthsExpiry = new DevExpress.XtraEditors.SimpleButton();
            this.spnMaximumUsers = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtLicencee = new DevExpress.XtraEditors.TextEdit();
            this.txtLicenceeEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.memLicence.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpiry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUnusedOption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteExpiry.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteExpiry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaximumUsers.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicencee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenceeEmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(17, 370);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(126, 23);
            this.btnGenerateKeys.TabIndex = 0;
            this.btnGenerateKeys.Text = "Generate Keys";
            this.btnGenerateKeys.Visible = false;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClose.Location = new System.Drawing.Point(710, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreateLicence
            // 
            this.btnCreateLicence.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateLicence.Appearance.Options.UseFont = true;
            this.btnCreateLicence.Location = new System.Drawing.Point(635, 15);
            this.btnCreateLicence.Name = "btnCreateLicence";
            this.btnCreateLicence.Size = new System.Drawing.Size(150, 72);
            this.btnCreateLicence.TabIndex = 10;
            this.btnCreateLicence.Text = "Create Licence";
            this.btnCreateLicence.Click += new System.EventHandler(this.btnCreateLicence_Click);
            // 
            // memLicence
            // 
            this.memLicence.Location = new System.Drawing.Point(15, 117);
            this.memLicence.Name = "memLicence";
            this.memLicence.Properties.ReadOnly = true;
            this.memLicence.Size = new System.Drawing.Size(770, 243);
            this.memLicence.TabIndex = 11;
            // 
            // cboType
            // 
            this.cboType.EditValue = "Standard";
            this.cboType.Location = new System.Drawing.Point(105, 15);
            this.cboType.Name = "cboType";
            this.cboType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboType.Properties.Items.AddRange(new object[] {
            "Standard",
            "Trial"});
            this.cboType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboType.Size = new System.Drawing.Size(80, 20);
            this.cboType.TabIndex = 0;
            // 
            // chkExpiry
            // 
            this.chkExpiry.Location = new System.Drawing.Point(300, 67);
            this.chkExpiry.Name = "chkExpiry";
            this.chkExpiry.Properties.Caption = "";
            this.chkExpiry.Size = new System.Drawing.Size(20, 19);
            this.chkExpiry.TabIndex = 5;
            this.chkExpiry.CheckedChanged += new System.EventHandler(this.chkExpiry_CheckedChanged);
            // 
            // chkUnusedOption
            // 
            this.chkUnusedOption.Enabled = false;
            this.chkUnusedOption.Location = new System.Drawing.Point(105, 67);
            this.chkUnusedOption.Name = "chkUnusedOption";
            this.chkUnusedOption.Properties.Caption = "";
            this.chkUnusedOption.Size = new System.Drawing.Size(21, 19);
            this.chkUnusedOption.TabIndex = 2;
            // 
            // dteExpiry
            // 
            this.dteExpiry.EditValue = null;
            this.dteExpiry.Enabled = false;
            this.dteExpiry.Location = new System.Drawing.Point(326, 67);
            this.dteExpiry.Name = "dteExpiry";
            this.dteExpiry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteExpiry.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteExpiry.Size = new System.Drawing.Size(100, 20);
            this.dteExpiry.TabIndex = 6;
            // 
            // btnThirtyDaysExpiry
            // 
            this.btnThirtyDaysExpiry.Enabled = false;
            this.btnThirtyDaysExpiry.Location = new System.Drawing.Point(432, 67);
            this.btnThirtyDaysExpiry.Name = "btnThirtyDaysExpiry";
            this.btnThirtyDaysExpiry.Size = new System.Drawing.Size(60, 20);
            this.btnThirtyDaysExpiry.TabIndex = 7;
            this.btnThirtyDaysExpiry.TabStop = false;
            this.btnThirtyDaysExpiry.Text = "30 days";
            this.btnThirtyDaysExpiry.Click += new System.EventHandler(this.btnThirtyDaysExpiry_Click);
            // 
            // btnOneYearExpiry
            // 
            this.btnOneYearExpiry.Enabled = false;
            this.btnOneYearExpiry.Location = new System.Drawing.Point(564, 67);
            this.btnOneYearExpiry.Name = "btnOneYearExpiry";
            this.btnOneYearExpiry.Size = new System.Drawing.Size(60, 20);
            this.btnOneYearExpiry.TabIndex = 9;
            this.btnOneYearExpiry.TabStop = false;
            this.btnOneYearExpiry.Text = "1 year";
            this.btnOneYearExpiry.Click += new System.EventHandler(this.btnOneYearExpiry_Click);
            // 
            // btnThreeMonthsExpiry
            // 
            this.btnThreeMonthsExpiry.Enabled = false;
            this.btnThreeMonthsExpiry.Location = new System.Drawing.Point(498, 67);
            this.btnThreeMonthsExpiry.Name = "btnThreeMonthsExpiry";
            this.btnThreeMonthsExpiry.Size = new System.Drawing.Size(60, 20);
            this.btnThreeMonthsExpiry.TabIndex = 8;
            this.btnThreeMonthsExpiry.TabStop = false;
            this.btnThreeMonthsExpiry.Text = "3 months";
            this.btnThreeMonthsExpiry.Click += new System.EventHandler(this.btnThreeMonthsExpiry_Click);
            // 
            // spnMaximumUsers
            // 
            this.spnMaximumUsers.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnMaximumUsers.Location = new System.Drawing.Point(105, 41);
            this.spnMaximumUsers.Name = "spnMaximumUsers";
            this.spnMaximumUsers.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnMaximumUsers.Properties.Mask.EditMask = "#######.";
            this.spnMaximumUsers.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.spnMaximumUsers.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.spnMaximumUsers.Size = new System.Drawing.Size(80, 20);
            this.spnMaximumUsers.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Type";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Maximum Users";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 100);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Licence";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(215, 18);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Licencee";
            // 
            // txtLicencee
            // 
            this.txtLicencee.Location = new System.Drawing.Point(300, 15);
            this.txtLicencee.Name = "txtLicencee";
            this.txtLicencee.Size = new System.Drawing.Size(324, 20);
            this.txtLicencee.TabIndex = 3;
            // 
            // txtLicenceeEmail
            // 
            this.txtLicenceeEmail.Location = new System.Drawing.Point(300, 41);
            this.txtLicenceeEmail.Name = "txtLicenceeEmail";
            this.txtLicenceeEmail.Size = new System.Drawing.Size(324, 20);
            this.txtLicenceeEmail.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(215, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Licencee E-mail";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(15, 70);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 13);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "Unused Option";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(215, 70);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 13);
            this.labelControl7.TabIndex = 22;
            this.labelControl7.Text = "Expiry";
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtLicenceeEmail);
            this.Controls.Add(this.txtLicencee);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.spnMaximumUsers);
            this.Controls.Add(this.btnThreeMonthsExpiry);
            this.Controls.Add(this.btnOneYearExpiry);
            this.Controls.Add(this.btnThirtyDaysExpiry);
            this.Controls.Add(this.dteExpiry);
            this.Controls.Add(this.chkUnusedOption);
            this.Controls.Add(this.chkExpiry);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.memLicence);
            this.Controls.Add(this.btnCreateLicence);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGenerateKeys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Me Licence Generator";
            ((System.ComponentModel.ISupportInitialize)(this.memLicence.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkExpiry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUnusedOption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteExpiry.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteExpiry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaximumUsers.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicencee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLicenceeEmail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGenerateKeys;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnCreateLicence;
        private DevExpress.XtraEditors.MemoEdit memLicence;
        private DevExpress.XtraEditors.ComboBoxEdit cboType;
        private DevExpress.XtraEditors.CheckEdit chkExpiry;
        private DevExpress.XtraEditors.CheckEdit chkUnusedOption;
        private DevExpress.XtraEditors.DateEdit dteExpiry;
        private DevExpress.XtraEditors.SimpleButton btnThirtyDaysExpiry;
        private DevExpress.XtraEditors.SimpleButton btnOneYearExpiry;
        private DevExpress.XtraEditors.SimpleButton btnThreeMonthsExpiry;
        private DevExpress.XtraEditors.SpinEdit spnMaximumUsers;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtLicencee;
        private DevExpress.XtraEditors.TextEdit txtLicenceeEmail;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}