namespace source
{
    partial class SettingsWindow
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
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.languageLable = new System.Windows.Forms.Label();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // languageComboBox
            // 
            this.languageComboBox.AccessibleDescription = "";
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Русский"});
            this.languageComboBox.Location = new System.Drawing.Point(167, 24);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(165, 24);
            this.languageComboBox.TabIndex = 21;
            this.languageComboBox.TabStop = false;
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // languageLable
            // 
            this.languageLable.AutoSize = true;
            this.languageLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languageLable.ForeColor = System.Drawing.SystemColors.InfoText;
            this.languageLable.Location = new System.Drawing.Point(20, 26);
            this.languageLable.Name = "languageLable";
            this.languageLable.Size = new System.Drawing.Size(127, 18);
            this.languageLable.TabIndex = 20;
            this.languageLable.Text = "Interface language";
            // 
            // cancelbutton
            // 
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelbutton.Location = new System.Drawing.Point(132, 141);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(97, 39);
            this.cancelbutton.TabIndex = 23;
            this.cancelbutton.TabStop = false;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.confirmButton.Location = new System.Drawing.Point(235, 141);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(97, 39);
            this.confirmButton.TabIndex = 22;
            this.confirmButton.TabStop = false;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 192);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.languageLable);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsWindow";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Label languageLable;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button confirmButton;
    }
}