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
            this.txtLicence = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerateLicence = new System.Windows.Forms.Button();
            this.btnOneYearExpiry = new System.Windows.Forms.Button();
            this.btnThreeMonthsExpiry = new System.Windows.Forms.Button();
            this.btnThirtyDaysExpiry = new System.Windows.Forms.Button();
            this.chkMaximumUsers = new System.Windows.Forms.CheckBox();
            this.dteExpiry = new System.Windows.Forms.DateTimePicker();
            this.chkExpiry = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMaximumUsers = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnGenerateApplicationKeys = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximumUsers)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLicence
            // 
            this.txtLicence.Location = new System.Drawing.Point(244, 30);
            this.txtLicence.Multiline = true;
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.ReadOnly = true;
            this.txtLicence.Size = new System.Drawing.Size(500, 208);
            this.txtLicence.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Licence";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(670, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGenerateLicence);
            this.panel1.Controls.Add(this.btnOneYearExpiry);
            this.panel1.Controls.Add(this.btnThreeMonthsExpiry);
            this.panel1.Controls.Add(this.btnThirtyDaysExpiry);
            this.panel1.Controls.Add(this.chkMaximumUsers);
            this.panel1.Controls.Add(this.dteExpiry);
            this.panel1.Controls.Add(this.chkExpiry);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numMaximumUsers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cboType);
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 213);
            this.panel1.TabIndex = 16;
            // 
            // btnGenerateLicence
            // 
            this.btnGenerateLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateLicence.Location = new System.Drawing.Point(12, 159);
            this.btnGenerateLicence.Name = "btnGenerateLicence";
            this.btnGenerateLicence.Size = new System.Drawing.Size(205, 40);
            this.btnGenerateLicence.TabIndex = 27;
            this.btnGenerateLicence.Text = "Generate Licence";
            this.btnGenerateLicence.UseVisualStyleBackColor = true;
            this.btnGenerateLicence.Click += new System.EventHandler(this.btnGenerateLicence_Click);
            // 
            // btnOneYearExpiry
            // 
            this.btnOneYearExpiry.Enabled = false;
            this.btnOneYearExpiry.Location = new System.Drawing.Point(116, 131);
            this.btnOneYearExpiry.Name = "btnOneYearExpiry";
            this.btnOneYearExpiry.Size = new System.Drawing.Size(101, 22);
            this.btnOneYearExpiry.TabIndex = 26;
            this.btnOneYearExpiry.Text = "1 year";
            this.btnOneYearExpiry.UseVisualStyleBackColor = true;
            this.btnOneYearExpiry.Click += new System.EventHandler(this.btnOneYearExpiry_Click);
            // 
            // btnThreeMonthsExpiry
            // 
            this.btnThreeMonthsExpiry.Enabled = false;
            this.btnThreeMonthsExpiry.Location = new System.Drawing.Point(116, 109);
            this.btnThreeMonthsExpiry.Name = "btnThreeMonthsExpiry";
            this.btnThreeMonthsExpiry.Size = new System.Drawing.Size(101, 22);
            this.btnThreeMonthsExpiry.TabIndex = 25;
            this.btnThreeMonthsExpiry.Text = "3 months";
            this.btnThreeMonthsExpiry.UseVisualStyleBackColor = true;
            this.btnThreeMonthsExpiry.Click += new System.EventHandler(this.btnThreeMonthsExpiry_Click);
            // 
            // btnThirtyDaysExpiry
            // 
            this.btnThirtyDaysExpiry.Enabled = false;
            this.btnThirtyDaysExpiry.Location = new System.Drawing.Point(116, 87);
            this.btnThirtyDaysExpiry.Name = "btnThirtyDaysExpiry";
            this.btnThirtyDaysExpiry.Size = new System.Drawing.Size(101, 22);
            this.btnThirtyDaysExpiry.TabIndex = 24;
            this.btnThirtyDaysExpiry.Text = "30 days";
            this.btnThirtyDaysExpiry.UseVisualStyleBackColor = true;
            this.btnThirtyDaysExpiry.Click += new System.EventHandler(this.btnThirtyDaysExpiry_Click);
            // 
            // chkMaximumUsers
            // 
            this.chkMaximumUsers.AutoSize = true;
            this.chkMaximumUsers.Location = new System.Drawing.Point(96, 42);
            this.chkMaximumUsers.Name = "chkMaximumUsers";
            this.chkMaximumUsers.Size = new System.Drawing.Size(15, 14);
            this.chkMaximumUsers.TabIndex = 23;
            this.chkMaximumUsers.UseVisualStyleBackColor = true;
            this.chkMaximumUsers.CheckedChanged += new System.EventHandler(this.chkMaximumUsers_CheckedChanged);
            // 
            // dteExpiry
            // 
            this.dteExpiry.CustomFormat = "";
            this.dteExpiry.Enabled = false;
            this.dteExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteExpiry.Location = new System.Drawing.Point(117, 66);
            this.dteExpiry.Name = "dteExpiry";
            this.dteExpiry.Size = new System.Drawing.Size(100, 20);
            this.dteExpiry.TabIndex = 22;
            // 
            // chkExpiry
            // 
            this.chkExpiry.AutoSize = true;
            this.chkExpiry.Location = new System.Drawing.Point(96, 68);
            this.chkExpiry.Name = "chkExpiry";
            this.chkExpiry.Size = new System.Drawing.Size(15, 14);
            this.chkExpiry.TabIndex = 21;
            this.chkExpiry.UseVisualStyleBackColor = true;
            this.chkExpiry.CheckedChanged += new System.EventHandler(this.chkExpiry_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Expiry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Maximum Users";
            // 
            // numMaximumUsers
            // 
            this.numMaximumUsers.Enabled = false;
            this.numMaximumUsers.Location = new System.Drawing.Point(117, 40);
            this.numMaximumUsers.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMaximumUsers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaximumUsers.Name = "numMaximumUsers";
            this.numMaximumUsers.Size = new System.Drawing.Size(100, 20);
            this.numMaximumUsers.TabIndex = 18;
            this.numMaximumUsers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Standard",
            "Trial"});
            this.cboType.Location = new System.Drawing.Point(117, 13);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 21);
            this.cboType.TabIndex = 16;
            // 
            // btnGenerateApplicationKeys
            // 
            this.btnGenerateApplicationKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateApplicationKeys.Location = new System.Drawing.Point(12, 12);
            this.btnGenerateApplicationKeys.Name = "btnGenerateApplicationKeys";
            this.btnGenerateApplicationKeys.Size = new System.Drawing.Size(205, 40);
            this.btnGenerateApplicationKeys.TabIndex = 17;
            this.btnGenerateApplicationKeys.Text = "Generate Application Keys";
            this.btnGenerateApplicationKeys.UseVisualStyleBackColor = true;
            this.btnGenerateApplicationKeys.Click += new System.EventHandler(this.btnGenerateApplicationKeys_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnGenerateApplicationKeys);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 66);
            this.panel2.TabIndex = 18;
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 279);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLicence);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneratorForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaximumUsers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLicence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerateLicence;
        private System.Windows.Forms.Button btnOneYearExpiry;
        private System.Windows.Forms.Button btnThreeMonthsExpiry;
        private System.Windows.Forms.Button btnThirtyDaysExpiry;
        private System.Windows.Forms.CheckBox chkMaximumUsers;
        private System.Windows.Forms.DateTimePicker dteExpiry;
        private System.Windows.Forms.CheckBox chkExpiry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMaximumUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnGenerateApplicationKeys;
        private System.Windows.Forms.Panel panel2;
    }
}