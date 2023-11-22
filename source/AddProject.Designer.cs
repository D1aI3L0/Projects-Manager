namespace source
{
    partial class AddProject
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.languageLable = new System.Windows.Forms.Label();
            this.nameLable = new System.Windows.Forms.Label();
            this.descriptionLable = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.githubTextBox = new System.Windows.Forms.TextBox();
            this.githubLable = new System.Windows.Forms.Label();
            this.pathLable = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.pathChoiceButton = new System.Windows.Forms.Button();
            this.errorImageBox3 = new System.Windows.Forms.PictureBox();
            this.errorImageBox1 = new System.Windows.Forms.PictureBox();
            this.errorImageBox2 = new System.Windows.Forms.PictureBox();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorImageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorImageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorImageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(305, 412);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(87, 39);
            this.confirmButton.TabIndex = 1;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(212, 412);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(87, 39);
            this.cancelbutton.TabIndex = 2;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // languageLable
            // 
            this.languageLable.AutoSize = true;
            this.languageLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languageLable.Location = new System.Drawing.Point(300, 29);
            this.languageLable.Name = "languageLable";
            this.languageLable.Size = new System.Drawing.Size(72, 18);
            this.languageLable.TabIndex = 3;
            this.languageLable.Text = "Language";
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLable.Location = new System.Drawing.Point(26, 29);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(48, 18);
            this.nameLable.TabIndex = 4;
            this.nameLable.Text = "Name";
            // 
            // descriptionLable
            // 
            this.descriptionLable.AutoSize = true;
            this.descriptionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLable.Location = new System.Drawing.Point(26, 159);
            this.descriptionLable.Name = "descriptionLable";
            this.descriptionLable.Size = new System.Drawing.Size(83, 18);
            this.descriptionLable.TabIndex = 5;
            this.descriptionLable.Text = "Description";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(29, 52);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(242, 24);
            this.nameTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Location = new System.Drawing.Point(29, 180);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(363, 170);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // githubTextBox
            // 
            this.githubTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.githubTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.githubTextBox.Location = new System.Drawing.Point(29, 383);
            this.githubTextBox.Name = "githubTextBox";
            this.githubTextBox.Size = new System.Drawing.Size(363, 24);
            this.githubTextBox.TabIndex = 8;
            // 
            // githubLable
            // 
            this.githubLable.AutoSize = true;
            this.githubLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.githubLable.Location = new System.Drawing.Point(26, 362);
            this.githubLable.Name = "githubLable";
            this.githubLable.Size = new System.Drawing.Size(54, 18);
            this.githubLable.TabIndex = 10;
            this.githubLable.Text = "GitHub";
            // 
            // pathLable
            // 
            this.pathLable.AutoSize = true;
            this.pathLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathLable.Location = new System.Drawing.Point(26, 97);
            this.pathLable.Name = "pathLable";
            this.pathLable.Size = new System.Drawing.Size(38, 18);
            this.pathLable.TabIndex = 13;
            this.pathLable.Text = "Path";
            // 
            // pathTextBox
            // 
            this.pathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathTextBox.Location = new System.Drawing.Point(29, 118);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(335, 24);
            this.pathTextBox.TabIndex = 12;
            // 
            // pathChoiceButton
            // 
            this.pathChoiceButton.BackColor = System.Drawing.SystemColors.Window;
            this.pathChoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pathChoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pathChoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathChoiceButton.Location = new System.Drawing.Point(363, 118);
            this.pathChoiceButton.Name = "pathChoiceButton";
            this.pathChoiceButton.Size = new System.Drawing.Size(29, 24);
            this.pathChoiceButton.TabIndex = 14;
            this.pathChoiceButton.Text = "...";
            this.pathChoiceButton.UseVisualStyleBackColor = false;
            this.pathChoiceButton.Click += new System.EventHandler(this.pathChoiceButton_Click);
            // 
            // errorImageBox3
            // 
            this.errorImageBox3.BackgroundImage = global::source.Properties.Resources._0WO;
            this.errorImageBox3.Location = new System.Drawing.Point(394, 118);
            this.errorImageBox3.Name = "errorImageBox3";
            this.errorImageBox3.Size = new System.Drawing.Size(27, 24);
            this.errorImageBox3.TabIndex = 15;
            this.errorImageBox3.TabStop = false;
            this.errorImageBox3.Visible = false;
            this.errorImageBox3.WaitOnLoad = true;
            // 
            // errorImageBox1
            // 
            this.errorImageBox1.BackgroundImage = global::source.Properties.Resources._0WO;
            this.errorImageBox1.Location = new System.Drawing.Point(272, 52);
            this.errorImageBox1.Name = "errorImageBox1";
            this.errorImageBox1.Size = new System.Drawing.Size(27, 24);
            this.errorImageBox1.TabIndex = 16;
            this.errorImageBox1.TabStop = false;
            this.errorImageBox1.Visible = false;
            // 
            // errorImageBox2
            // 
            this.errorImageBox2.BackgroundImage = global::source.Properties.Resources._0WO;
            this.errorImageBox2.Location = new System.Drawing.Point(394, 52);
            this.errorImageBox2.Name = "errorImageBox2";
            this.errorImageBox2.Size = new System.Drawing.Size(27, 24);
            this.errorImageBox2.TabIndex = 17;
            this.errorImageBox2.TabStop = false;
            this.errorImageBox2.Visible = false;
            // 
            // errorTextBox
            // 
            this.errorTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.errorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorTextBox.Location = new System.Drawing.Point(33, 77);
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.Size = new System.Drawing.Size(242, 14);
            this.errorTextBox.TabIndex = 18;
            this.errorTextBox.Text = "Already exists";
            this.errorTextBox.Visible = false;
            // 
            // languageComboBox
            // 
            this.languageComboBox.AccessibleDescription = "";
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "C#",
            "C++",
            "C",
            "Java",
            "Python",
            "Ruby"});
            this.languageComboBox.Location = new System.Drawing.Point(301, 52);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(87, 24);
            this.languageComboBox.TabIndex = 19;
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 466);
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.errorTextBox);
            this.Controls.Add(this.errorImageBox2);
            this.Controls.Add(this.errorImageBox1);
            this.Controls.Add(this.errorImageBox3);
            this.Controls.Add(this.pathChoiceButton);
            this.Controls.Add(this.pathLable);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.githubLable);
            this.Controls.Add(this.githubTextBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.descriptionLable);
            this.Controls.Add(this.nameLable);
            this.Controls.Add(this.languageLable);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.confirmButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddProject";
            this.Text = "AddProject";
            ((System.ComponentModel.ISupportInitialize)(this.errorImageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorImageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorImageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Label languageLable;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.Label descriptionLable;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox githubTextBox;
        private System.Windows.Forms.Label githubLable;
        private System.Windows.Forms.Label pathLable;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button pathChoiceButton;
        private System.Windows.Forms.PictureBox errorImageBox3;
        private System.Windows.Forms.PictureBox errorImageBox1;
        private System.Windows.Forms.PictureBox errorImageBox2;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.ComboBox languageComboBox;
    }
}