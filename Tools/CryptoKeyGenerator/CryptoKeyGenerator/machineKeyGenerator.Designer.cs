namespace CryptoKeyGenerator
{
    partial class machineKeyGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.validationFormat = new System.Windows.Forms.ComboBox();
            this.validationLength = new System.Windows.Forms.TextBox();
            this.decryptionLength = new System.Windows.Forms.TextBox();
            this.generateConfig = new System.Windows.Forms.Button();
            this.resultingConfig = new System.Windows.Forms.TextBox();
            this.decryptionFormat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Validation:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Validation Key Len:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Decryption Key Len:";
            // 
            // validationFormat
            // 
            this.validationFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validationFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validationFormat.FormattingEnabled = true;
            this.validationFormat.Items.AddRange(new object[] {
            "AES",
            "MD5",
            "SHA1",
            "3DES",
            "HMACSHA256",
            "HMACSHA384",
            "HMACSHA512",
            "alg"});
            this.validationFormat.Location = new System.Drawing.Point(136, 0);
            this.validationFormat.Name = "validationFormat";
            this.validationFormat.Size = new System.Drawing.Size(111, 21);
            this.validationFormat.TabIndex = 3;
            this.validationFormat.Text = "HMACSHA512 ";
            this.validationFormat.SelectedIndexChanged += new System.EventHandler(this.validationFormat_SelectedIndexChanged);
            // 
            // validationLength
            // 
            this.validationLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validationLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.validationLength.Location = new System.Drawing.Point(136, 27);
            this.validationLength.Name = "validationLength";
            this.validationLength.ReadOnly = true;
            this.validationLength.Size = new System.Drawing.Size(111, 20);
            this.validationLength.TabIndex = 4;
            this.validationLength.Text = "128";
            this.validationLength.WordWrap = false;
            // 
            // decryptionLength
            // 
            this.decryptionLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptionLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decryptionLength.Location = new System.Drawing.Point(136, 80);
            this.decryptionLength.Name = "decryptionLength";
            this.decryptionLength.ReadOnly = true;
            this.decryptionLength.Size = new System.Drawing.Size(111, 20);
            this.decryptionLength.TabIndex = 5;
            this.decryptionLength.Text = "64";
            this.decryptionLength.WordWrap = false;
            // 
            // generateConfig
            // 
            this.generateConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generateConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateConfig.Location = new System.Drawing.Point(15, 106);
            this.generateConfig.Name = "generateConfig";
            this.generateConfig.Size = new System.Drawing.Size(232, 24);
            this.generateConfig.TabIndex = 6;
            this.generateConfig.Text = "Generate";
            this.generateConfig.UseVisualStyleBackColor = true;
            this.generateConfig.Click += new System.EventHandler(this.generateConfig_Click);
            // 
            // resultingConfig
            // 
            this.resultingConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultingConfig.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultingConfig.Location = new System.Drawing.Point(14, 136);
            this.resultingConfig.Multiline = true;
            this.resultingConfig.Name = "resultingConfig";
            this.resultingConfig.ReadOnly = true;
            this.resultingConfig.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultingConfig.Size = new System.Drawing.Size(233, 162);
            this.resultingConfig.TabIndex = 7;
            this.resultingConfig.WordWrap = false;
            // 
            // decryptionFormat
            // 
            this.decryptionFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptionFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptionFormat.FormattingEnabled = true;
            this.decryptionFormat.Items.AddRange(new object[] {
            "Auto",
            "AES",
            "DES",
            "3DES",
            "alg"});
            this.decryptionFormat.Location = new System.Drawing.Point(136, 53);
            this.decryptionFormat.Name = "decryptionFormat";
            this.decryptionFormat.Size = new System.Drawing.Size(111, 21);
            this.decryptionFormat.TabIndex = 9;
            this.decryptionFormat.Text = "AES";
            this.decryptionFormat.SelectedIndexChanged += new System.EventHandler(this.decryptionFormat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Decryption:";
            // 
            // machineKeyGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 310);
            this.Controls.Add(this.decryptionFormat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultingConfig);
            this.Controls.Add(this.generateConfig);
            this.Controls.Add(this.decryptionLength);
            this.Controls.Add(this.validationLength);
            this.Controls.Add(this.validationFormat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(275, 240);
            this.Name = "machineKeyGenerator";
            this.Text = "Machine Key Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox validationFormat;
        private System.Windows.Forms.TextBox validationLength;
        private System.Windows.Forms.TextBox decryptionLength;
        private System.Windows.Forms.Button generateConfig;
        private System.Windows.Forms.TextBox resultingConfig;
        private System.Windows.Forms.ComboBox decryptionFormat;
        private System.Windows.Forms.Label label4;
    }
}

