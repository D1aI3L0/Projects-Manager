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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteProject = new System.Windows.Forms.Button();
            this.addNewProjectButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.editProject = new System.Windows.Forms.Button();
            this.nameComboBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // projectsListComboBox
            // 
            this.projectsListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.projectsListComboBox.FormattingEnabled = true;
            this.projectsListComboBox.Location = new System.Drawing.Point(23, 58);
            this.projectsListComboBox.Name = "projectsListComboBox";
            this.projectsListComboBox.Size = new System.Drawing.Size(280, 24);
            this.projectsListComboBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deleteProject
            // 
            this.deleteProject.Location = new System.Drawing.Point(689, 367);
            this.deleteProject.Name = "deleteProject";
            this.deleteProject.Size = new System.Drawing.Size(67, 53);
            this.deleteProject.TabIndex = 3;
            this.deleteProject.UseVisualStyleBackColor = true;
            // 
            // addNewProjectButton
            // 
            this.addNewProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewProjectButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.addNewProjectButton.Location = new System.Drawing.Point(309, 58);
            this.addNewProjectButton.Name = "addNewProjectButton";
            this.addNewProjectButton.Size = new System.Drawing.Size(26, 24);
            this.addNewProjectButton.TabIndex = 4;
            this.addNewProjectButton.Text = "+";
            this.addNewProjectButton.UseVisualStyleBackColor = true;
            this.addNewProjectButton.Click += new System.EventHandler(this.addNewProjectButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.Location = new System.Drawing.Point(23, 155);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(529, 189);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // editProject
            // 
            this.editProject.Location = new System.Drawing.Point(615, 367);
            this.editProject.Name = "editProject";
            this.editProject.Size = new System.Drawing.Size(68, 53);
            this.editProject.TabIndex = 6;
            this.editProject.UseVisualStyleBackColor = true;
            // 
            // nameComboBox
            // 
            this.nameComboBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameComboBox.Location = new System.Drawing.Point(23, 108);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(529, 22);
            this.nameComboBox.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.editProject);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.addNewProjectButton);
            this.Controls.Add(this.deleteProject);
            this.Controls.Add(this.projectsListComboBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Projects Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox projectsListComboBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button deleteProject;
        private System.Windows.Forms.Button addNewProjectButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button editProject;
        private System.Windows.Forms.TextBox nameComboBox;
    }
}

