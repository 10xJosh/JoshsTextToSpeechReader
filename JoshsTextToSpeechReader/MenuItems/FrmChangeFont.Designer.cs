namespace JoshsTextToSpeechReader.MenuItems
{
    partial class FrmChangeFont
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmboFonts = new System.Windows.Forms.ComboBox();
            this.FontSettings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboFontSize = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(84, 96);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmboFonts
            // 
            this.cmboFonts.FormattingEnabled = true;
            this.cmboFonts.Location = new System.Drawing.Point(64, 24);
            this.cmboFonts.Name = "cmboFonts";
            this.cmboFonts.Size = new System.Drawing.Size(264, 21);
            this.cmboFonts.TabIndex = 1;
            // 
            // FontSettings
            // 
            this.FontSettings.AutoSize = true;
            this.FontSettings.Location = new System.Drawing.Point(27, 27);
            this.FontSettings.Name = "FontSettings";
            this.FontSettings.Size = new System.Drawing.Size(31, 13);
            this.FontSettings.TabIndex = 2;
            this.FontSettings.Text = "Font:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Font Size:";
            // 
            // cmboFontSize
            // 
            this.cmboFontSize.FormattingEnabled = true;
            this.cmboFontSize.Location = new System.Drawing.Point(262, 62);
            this.cmboFontSize.Name = "cmboFontSize";
            this.cmboFontSize.Size = new System.Drawing.Size(66, 21);
            this.cmboFontSize.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(201, 96);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmChangeFont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(372, 140);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cmboFontSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FontSettings);
            this.Controls.Add(this.cmboFonts);
            this.Controls.Add(this.btnConfirm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangeFont";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Font Settings";
            this.Load += new System.EventHandler(this.FrmChangeFont_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmboFonts;
        private System.Windows.Forms.Label FontSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboFontSize;
        private System.Windows.Forms.Button btnClose;
    }
}