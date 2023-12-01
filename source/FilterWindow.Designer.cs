namespace source
{
    partial class FilterWindow
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
            this.progLangListCheckedBox = new System.Windows.Forms.CheckedListBox();
            this.progLangLable = new System.Windows.Forms.Label();
            this.nameLable = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progLangListCheckedBox
            // 
            this.progLangListCheckedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progLangListCheckedBox.CheckOnClick = true;
            this.progLangListCheckedBox.ColumnWidth = 150;
            this.progLangListCheckedBox.FormattingEnabled = true;
            this.progLangListCheckedBox.Items.AddRange(new object[] {
            "C#",
            "C/C++",
            "Java",
            "Python",
            "Ruby",
            "Scala",
            "PHP",
            "Delphi",
            "Swift",
            "F#",
            "VB.NET",
            "JavaScript",
            "Object-C"});
            this.progLangListCheckedBox.Location = new System.Drawing.Point(12, 125);
            this.progLangListCheckedBox.MultiColumn = true;
            this.progLangListCheckedBox.Name = "progLangListCheckedBox";
            this.progLangListCheckedBox.Size = new System.Drawing.Size(302, 119);
            this.progLangListCheckedBox.TabIndex = 0;
            // 
            // progLangLable
            // 
            this.progLangLable.AutoSize = true;
            this.progLangLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progLangLable.Location = new System.Drawing.Point(8, 93);
            this.progLangLable.Name = "progLangLable";
            this.progLangLable.Size = new System.Drawing.Size(116, 20);
            this.progLangLable.TabIndex = 1;
            this.progLangLable.Text = "Prog language";
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLable.Location = new System.Drawing.Point(8, 19);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(53, 20);
            this.nameLable.TabIndex = 2;
            this.nameLable.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(12, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(302, 17);
            this.nameTextBox.TabIndex = 3;
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.SystemColors.Window;
            this.cancelbutton.FlatAppearance.BorderSize = 0;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cancelbutton.Location = new System.Drawing.Point(114, 266);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(97, 39);
            this.cancelbutton.TabIndex = 25;
            this.cancelbutton.TabStop = false;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.SystemColors.Window;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.confirmButton.Location = new System.Drawing.Point(217, 266);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(97, 39);
            this.confirmButton.TabIndex = 24;
            this.confirmButton.TabStop = false;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // FilterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 319);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.progLangLable);
            this.Controls.Add(this.progLangListCheckedBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FilterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox progLangListCheckedBox;
        private System.Windows.Forms.Label progLangLable;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button confirmButton;
    }
}