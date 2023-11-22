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
            this.projectsListComboBox = new System.Windows.Forms.ComboBox();
            this.deleteProject = new System.Windows.Forms.Button();
            this.addNewProjectButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.editProject = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.githubButton = new System.Windows.Forms.Button();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // projectsListComboBox
            // 
            this.projectsListComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectsListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectsListComboBox.FormattingEnabled = true;
            this.projectsListComboBox.Location = new System.Drawing.Point(23, 39);
            this.projectsListComboBox.Name = "projectsListComboBox";
            this.projectsListComboBox.Size = new System.Drawing.Size(280, 24);
            this.projectsListComboBox.TabIndex = 0;
            this.projectsListComboBox.TabStop = false;
            this.projectsListComboBox.SelectedIndexChanged += new System.EventHandler(this.projectsListComboBox_SelectedIndexChanged);
            // 
            // deleteProject
            // 
            this.deleteProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProject.Location = new System.Drawing.Point(689, 367);
            this.deleteProject.Name = "deleteProject";
            this.deleteProject.Size = new System.Drawing.Size(67, 53);
            this.deleteProject.TabIndex = 3;
            this.deleteProject.TabStop = false;
            this.deleteProject.UseVisualStyleBackColor = true;
            // 
            // addNewProjectButton
            // 
            this.addNewProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewProjectButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.addNewProjectButton.Location = new System.Drawing.Point(309, 39);
            this.addNewProjectButton.Name = "addNewProjectButton";
            this.addNewProjectButton.Size = new System.Drawing.Size(26, 24);
            this.addNewProjectButton.TabIndex = 4;
            this.addNewProjectButton.TabStop = false;
            this.addNewProjectButton.Text = "+";
            this.addNewProjectButton.UseVisualStyleBackColor = true;
            this.addNewProjectButton.Click += new System.EventHandler(this.addNewProjectButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.descriptionTextBox.Location = new System.Drawing.Point(23, 97);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(550, 189);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.TabStop = false;
            // 
            // editProject
            // 
            this.editProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editProject.Location = new System.Drawing.Point(615, 367);
            this.editProject.Name = "editProject";
            this.editProject.Size = new System.Drawing.Size(68, 53);
            this.editProject.TabIndex = 6;
            this.editProject.TabStop = false;
            this.editProject.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(23, 69);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(410, 22);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TabStop = false;
            // 
            // pathTextBox
            // 
            this.pathTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.pathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathTextBox.Location = new System.Drawing.Point(23, 292);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(529, 22);
            this.pathTextBox.TabIndex = 9;
            this.pathTextBox.TabStop = false;
            // 
            // githubButton
            // 
            this.githubButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.githubButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.githubButton.Location = new System.Drawing.Point(23, 367);
            this.githubButton.Name = "githubButton";
            this.githubButton.Size = new System.Drawing.Size(68, 53);
            this.githubButton.TabIndex = 10;
            this.githubButton.TabStop = false;
            this.githubButton.Text = "GitHub";
            this.githubButton.UseVisualStyleBackColor = true;
            this.githubButton.Visible = false;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // languageTextBox
            // 
            this.languageTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.languageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.languageTextBox.Location = new System.Drawing.Point(439, 69);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.ReadOnly = true;
            this.languageTextBox.Size = new System.Drawing.Size(113, 22);
            this.languageTextBox.TabIndex = 11;
            this.languageTextBox.TabStop = false;
            this.languageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.editProject);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.addNewProjectButton);
            this.Controls.Add(this.deleteProject);
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
        private System.Windows.Forms.Button deleteProject;
        private System.Windows.Forms.Button addNewProjectButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button editProject;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button githubButton;
        private System.Windows.Forms.TextBox languageTextBox;
    }
}

