namespace source
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.projectsListComboBox = new System.Windows.Forms.ComboBox();
            this.deleteProjectButton = new System.Windows.Forms.Button();
            this.addProjectButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.editProjectButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.githubButton = new System.Windows.Forms.Button();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.openWithButton = new System.Windows.Forms.Button();
            this.pathErrorTextBox = new System.Windows.Forms.TextBox();
            this.addProjectToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.settingsButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // projectsListComboBox
            // 
            this.projectsListComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectsListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectsListComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.projectsListComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.projectsListComboBox.FormattingEnabled = true;
            this.projectsListComboBox.Location = new System.Drawing.Point(23, 13);
            this.projectsListComboBox.Name = "projectsListComboBox";
            this.projectsListComboBox.Size = new System.Drawing.Size(280, 26);
            this.projectsListComboBox.TabIndex = 0;
            this.projectsListComboBox.TabStop = false;
            this.projectsListComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectsListComboBox_SelectedIndexChanged);
            // 
            // deleteProjectButton
            // 
            this.deleteProjectButton.BackColor = System.Drawing.SystemColors.Window;
            this.deleteProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProjectButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteProjectButton.FlatAppearance.BorderSize = 0;
            this.deleteProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteProjectButton.Location = new System.Drawing.Point(455, 352);
            this.deleteProjectButton.Name = "deleteProjectButton";
            this.deleteProjectButton.Size = new System.Drawing.Size(97, 39);
            this.deleteProjectButton.TabIndex = 3;
            this.deleteProjectButton.TabStop = false;
            this.deleteProjectButton.Text = "Delete";
            this.deleteProjectButton.UseVisualStyleBackColor = false;
            this.deleteProjectButton.Visible = false;
            this.deleteProjectButton.Click += new System.EventHandler(this.DeleteProjectButton_Click);
            // 
            // addProjectButton
            // 
            this.addProjectButton.BackColor = System.Drawing.SystemColors.Window;
            this.addProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProjectButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addProjectButton.FlatAppearance.BorderSize = 0;
            this.addProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProjectButton.ForeColor = System.Drawing.Color.Green;
            this.addProjectButton.Location = new System.Drawing.Point(309, 13);
            this.addProjectButton.Name = "addProjectButton";
            this.addProjectButton.Size = new System.Drawing.Size(28, 28);
            this.addProjectButton.TabIndex = 4;
            this.addProjectButton.TabStop = false;
            this.addProjectButton.Text = "+";
            this.addProjectButton.UseVisualStyleBackColor = false;
            this.addProjectButton.Click += new System.EventHandler(this.AddNewProjectButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.descriptionTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.descriptionTextBox.Location = new System.Drawing.Point(23, 96);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(550, 189);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.TabStop = false;
            // 
            // editProjectButton
            // 
            this.editProjectButton.BackColor = System.Drawing.SystemColors.Window;
            this.editProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editProjectButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editProjectButton.FlatAppearance.BorderSize = 0;
            this.editProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editProjectButton.Location = new System.Drawing.Point(352, 352);
            this.editProjectButton.Name = "editProjectButton";
            this.editProjectButton.Size = new System.Drawing.Size(97, 39);
            this.editProjectButton.TabIndex = 6;
            this.editProjectButton.TabStop = false;
            this.editProjectButton.Text = "Edit";
            this.editProjectButton.UseVisualStyleBackColor = false;
            this.editProjectButton.Visible = false;
            this.editProjectButton.Click += new System.EventHandler(this.EditProjectButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.White;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTextBox.Location = new System.Drawing.Point(23, 61);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(410, 23);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TabStop = false;
            // 
            // pathTextBox
            // 
            this.pathTextBox.BackColor = System.Drawing.Color.White;
            this.pathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pathTextBox.Location = new System.Drawing.Point(23, 302);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(529, 19);
            this.pathTextBox.TabIndex = 9;
            this.pathTextBox.TabStop = false;
            // 
            // githubButton
            // 
            this.githubButton.BackColor = System.Drawing.SystemColors.Window;
            this.githubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.githubButton.FlatAppearance.BorderSize = 0;
            this.githubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.githubButton.Location = new System.Drawing.Point(23, 352);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(97, 39);
            this.githubButton.TabIndex = 10;
            this.githubButton.TabStop = false;
            this.githubButton.Text = "GitHub";
            this.githubButton.UseVisualStyleBackColor = false;
            this.githubButton.Visible = false;
            this.githubButton.Click += new System.EventHandler(this.GithubButton_Click);
            // 
            // languageTextBox
            // 
            this.languageTextBox.BackColor = System.Drawing.Color.White;
            this.languageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.languageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.languageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.languageTextBox.Location = new System.Drawing.Point(439, 61);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.ReadOnly = true;
            this.languageTextBox.Size = new System.Drawing.Size(113, 23);
            this.languageTextBox.TabIndex = 11;
            this.languageTextBox.TabStop = false;
            this.languageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openWithButton
            // 
            this.openWithButton.BackColor = System.Drawing.SystemColors.Window;
            this.openWithButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openWithButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.openWithButton.FlatAppearance.BorderSize = 0;
            this.openWithButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openWithButton.Location = new System.Drawing.Point(249, 352);
            this.openWithButton.Name = "openWithButton";
            this.openWithButton.Size = new System.Drawing.Size(97, 39);
            this.openWithButton.TabIndex = 12;
            this.openWithButton.TabStop = false;
            this.openWithButton.Text = "Open";
            this.openWithButton.UseVisualStyleBackColor = false;
            this.openWithButton.Visible = false;
            this.openWithButton.Click += new System.EventHandler(this.OpenWith_Click);
            // 
            // pathErrorTextBox
            // 
            this.pathErrorTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.pathErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pathErrorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathErrorTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pathErrorTextBox.Location = new System.Drawing.Point(30, 327);
            this.pathErrorTextBox.Name = "pathErrorTextBox";
            this.pathErrorTextBox.Size = new System.Drawing.Size(242, 14);
            this.pathErrorTextBox.TabIndex = 19;
            this.pathErrorTextBox.Text = "Doesn\'t exists";
            this.pathErrorTextBox.Visible = false;
            // 
            // settingsButton
            // 
            this.settingsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.settingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settingsButton.Location = new System.Drawing.Point(524, 13);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(28, 28);
            this.settingsButton.TabIndex = 20;
            this.settingsButton.TabStop = false;
            this.settingsButton.Text = "⚙️";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(581, 401);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.pathErrorTextBox);
            this.Controls.Add(this.openWithButton);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.editProjectButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.addProjectButton);
            this.Controls.Add(this.deleteProjectButton);
            this.Controls.Add(this.projectsListComboBox);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainWindow";
            this.Text = "Projects Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox projectsListComboBox;
        private System.Windows.Forms.Button deleteProjectButton;
        private System.Windows.Forms.Button addProjectButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button editProjectButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.Button openWithButton;
        private System.Windows.Forms.TextBox pathErrorTextBox;
        private System.Windows.Forms.ToolTip addProjectToolTip;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

