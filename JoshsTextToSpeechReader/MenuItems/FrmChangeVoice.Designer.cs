namespace JoshsTextToSpeechReader.MenuItems
{
    partial class FrmChangeVoice
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
            this.cmboVoiceList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoiceConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmboVoiceList
            // 
            this.cmboVoiceList.FormattingEnabled = true;
            this.cmboVoiceList.Location = new System.Drawing.Point(74, 31);
            this.cmboVoiceList.Name = "cmboVoiceList";
            this.cmboVoiceList.Size = new System.Drawing.Size(253, 21);
            this.cmboVoiceList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voices:";
            // 
            // btnVoiceConfirm
            // 
            this.btnVoiceConfirm.Location = new System.Drawing.Point(149, 75);
            this.btnVoiceConfirm.Name = "btnVoiceConfirm";
            this.btnVoiceConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnVoiceConfirm.TabIndex = 2;
            this.btnVoiceConfirm.Text = "Ok";
            this.btnVoiceConfirm.UseVisualStyleBackColor = true;
            this.btnVoiceConfirm.Click += new System.EventHandler(this.btnVoiceConfirm_Click);
            // 
            // FrmChangeVoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 110);
            this.Controls.Add(this.btnVoiceConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboVoiceList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangeVoice";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Text To Speech Voice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboVoiceList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoiceConfirm;
    }
}