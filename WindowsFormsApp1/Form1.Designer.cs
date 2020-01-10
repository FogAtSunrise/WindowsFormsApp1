namespace WindowsFormsApp1
{
    partial class HelloForm
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

        #region //Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_vhod = new System.Windows.Forms.Panel();
            this.panel_registr = new System.Windows.Forms.Panel();
            this.button_vhod_reg = new System.Windows.Forms.Button();
            this.label_name_reg = new System.Windows.Forms.Label();
            this.textBox_name_reg = new System.Windows.Forms.TextBox();
            this.button_reg_new = new System.Windows.Forms.Button();
            this.label_pass_reg = new System.Windows.Forms.Label();
            this.label_login_reg = new System.Windows.Forms.Label();
            this.label_reg_reg = new System.Windows.Forms.Label();
            this.textBox_pass_reg = new System.Windows.Forms.TextBox();
            this.textBox_log_reg = new System.Windows.Forms.TextBox();
            this.button_help_reg = new System.Windows.Forms.Button();
            this.button_reg = new System.Windows.Forms.Button();
            this.button_vhod = new System.Windows.Forms.Button();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_vhod = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_loginusing = new System.Windows.Forms.TextBox();
            this.button_help = new System.Windows.Forms.Button();
            this.panel_vhod.SuspendLayout();
            this.panel_registr.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_vhod
            // 
            this.panel_vhod.BackColor = System.Drawing.SystemColors.Control;
            this.panel_vhod.Controls.Add(this.panel_registr);
            this.panel_vhod.Controls.Add(this.button_reg);
            this.panel_vhod.Controls.Add(this.button_vhod);
            this.panel_vhod.Controls.Add(this.label_pass);
            this.panel_vhod.Controls.Add(this.label_login);
            this.panel_vhod.Controls.Add(this.label_vhod);
            this.panel_vhod.Controls.Add(this.textBox_password);
            this.panel_vhod.Controls.Add(this.textBox_loginusing);
            this.panel_vhod.Controls.Add(this.button_help);
            this.panel_vhod.Location = new System.Drawing.Point(0, -2);
            this.panel_vhod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_vhod.Name = "panel_vhod";
            this.panel_vhod.Size = new System.Drawing.Size(1182, 653);
            this.panel_vhod.TabIndex = 0;
            // 
            // panel_registr
            // 
            this.panel_registr.BackColor = System.Drawing.SystemColors.Control;
            this.panel_registr.Controls.Add(this.button_vhod_reg);
            this.panel_registr.Controls.Add(this.label_name_reg);
            this.panel_registr.Controls.Add(this.textBox_name_reg);
            this.panel_registr.Controls.Add(this.button_reg_new);
            this.panel_registr.Controls.Add(this.label_pass_reg);
            this.panel_registr.Controls.Add(this.label_login_reg);
            this.panel_registr.Controls.Add(this.label_reg_reg);
            this.panel_registr.Controls.Add(this.textBox_pass_reg);
            this.panel_registr.Controls.Add(this.textBox_log_reg);
            this.panel_registr.Controls.Add(this.button_help_reg);
            this.panel_registr.Location = new System.Drawing.Point(0, 2);
            this.panel_registr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_registr.Name = "panel_registr";
            this.panel_registr.Size = new System.Drawing.Size(1178, 656);
            this.panel_registr.TabIndex = 8;
            this.panel_registr.Visible = false;
            // 
            // button_vhod_reg
            // 
            this.button_vhod_reg.Location = new System.Drawing.Point(478, 459);
            this.button_vhod_reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_vhod_reg.Name = "button_vhod_reg";
            this.button_vhod_reg.Size = new System.Drawing.Size(221, 39);
            this.button_vhod_reg.TabIndex = 10;
            this.button_vhod_reg.Text = "Войти";
            this.button_vhod_reg.UseVisualStyleBackColor = true;
            this.button_vhod_reg.Click += new System.EventHandler(this.button_vhod_reg_Click);
            // 
            // label_name_reg
            // 
            this.label_name_reg.AutoSize = true;
            this.label_name_reg.BackColor = System.Drawing.SystemColors.Control;
            this.label_name_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name_reg.Location = new System.Drawing.Point(408, 155);
            this.label_name_reg.Name = "label_name_reg";
            this.label_name_reg.Size = new System.Drawing.Size(63, 29);
            this.label_name_reg.TabIndex = 9;
            this.label_name_reg.Text = "Имя";
            // 
            // textBox_name_reg
            // 
            this.textBox_name_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name_reg.Location = new System.Drawing.Point(478, 155);
            this.textBox_name_reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_name_reg.Name = "textBox_name_reg";
            this.textBox_name_reg.Size = new System.Drawing.Size(221, 34);
            this.textBox_name_reg.TabIndex = 8;
            // 
            // button_reg_new
            // 
            this.button_reg_new.Location = new System.Drawing.Point(478, 349);
            this.button_reg_new.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_reg_new.Name = "button_reg_new";
            this.button_reg_new.Size = new System.Drawing.Size(221, 39);
            this.button_reg_new.TabIndex = 7;
            this.button_reg_new.Text = "Регистрация";
            this.button_reg_new.UseVisualStyleBackColor = true;
            // 
            // label_pass_reg
            // 
            this.label_pass_reg.AutoSize = true;
            this.label_pass_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pass_reg.Location = new System.Drawing.Point(372, 283);
            this.label_pass_reg.Name = "label_pass_reg";
            this.label_pass_reg.Size = new System.Drawing.Size(99, 29);
            this.label_pass_reg.TabIndex = 5;
            this.label_pass_reg.Text = "Пароль";
            // 
            // label_login_reg
            // 
            this.label_login_reg.AutoSize = true;
            this.label_login_reg.BackColor = System.Drawing.SystemColors.Control;
            this.label_login_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login_reg.Location = new System.Drawing.Point(388, 212);
            this.label_login_reg.Name = "label_login_reg";
            this.label_login_reg.Size = new System.Drawing.Size(83, 29);
            this.label_login_reg.TabIndex = 4;
            this.label_login_reg.Text = "Логин";
            // 
            // label_reg_reg
            // 
            this.label_reg_reg.AutoSize = true;
            this.label_reg_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_reg_reg.Location = new System.Drawing.Point(499, 101);
            this.label_reg_reg.Name = "label_reg_reg";
            this.label_reg_reg.Size = new System.Drawing.Size(173, 29);
            this.label_reg_reg.TabIndex = 3;
            this.label_reg_reg.Text = "Регистрация";
            // 
            // textBox_pass_reg
            // 
            this.textBox_pass_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pass_reg.Location = new System.Drawing.Point(478, 283);
            this.textBox_pass_reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_pass_reg.Name = "textBox_pass_reg";
            this.textBox_pass_reg.Size = new System.Drawing.Size(221, 34);
            this.textBox_pass_reg.TabIndex = 2;
            // 
            // textBox_log_reg
            // 
            this.textBox_log_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_log_reg.Location = new System.Drawing.Point(478, 212);
            this.textBox_log_reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_log_reg.Name = "textBox_log_reg";
            this.textBox_log_reg.Size = new System.Drawing.Size(221, 34);
            this.textBox_log_reg.TabIndex = 1;
            // 
            // button_help_reg
            // 
            this.button_help_reg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_help_reg.Location = new System.Drawing.Point(1064, 11);
            this.button_help_reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_help_reg.Name = "button_help_reg";
            this.button_help_reg.Size = new System.Drawing.Size(88, 26);
            this.button_help_reg.TabIndex = 0;
            this.button_help_reg.Text = "Помощь";
            this.button_help_reg.UseVisualStyleBackColor = true;
            this.button_help_reg.Click += new System.EventHandler(this.button_help_reg_Click);
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(468, 407);
            this.button_reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(221, 39);
            this.button_reg.TabIndex = 7;
            this.button_reg.Text = "Регистрация";
            this.button_reg.UseVisualStyleBackColor = true;
            // 
            // button_vhod
            // 
            this.button_vhod.Location = new System.Drawing.Point(468, 296);
            this.button_vhod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_vhod.Name = "button_vhod";
            this.button_vhod.Size = new System.Drawing.Size(221, 39);
            this.button_vhod.TabIndex = 6;
            this.button_vhod.Text = "Войти";
            this.button_vhod.UseVisualStyleBackColor = true;
            this.button_vhod.Click += new System.EventHandler(this.button_vhod_Click);
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pass.Location = new System.Drawing.Point(362, 233);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(99, 29);
            this.label_pass.TabIndex = 5;
            this.label_pass.Text = "Пароль";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.SystemColors.Control;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(378, 157);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(83, 29);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "Логин";
            // 
            // label_vhod
            // 
            this.label_vhod.AutoSize = true;
            this.label_vhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vhod.Location = new System.Drawing.Point(534, 108);
            this.label_vhod.Name = "label_vhod";
            this.label_vhod.Size = new System.Drawing.Size(75, 29);
            this.label_vhod.TabIndex = 3;
            this.label_vhod.Text = "Вход";
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(468, 228);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(221, 34);
            this.textBox_password.TabIndex = 2;
            // 
            // textBox_loginusing
            // 
            this.textBox_loginusing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_loginusing.Location = new System.Drawing.Point(468, 157);
            this.textBox_loginusing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_loginusing.Name = "textBox_loginusing";
            this.textBox_loginusing.Size = new System.Drawing.Size(221, 34);
            this.textBox_loginusing.TabIndex = 1;
            // 
            // button_help
            // 
            this.button_help.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_help.Location = new System.Drawing.Point(1064, 13);
            this.button_help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(88, 26);
            this.button_help.TabIndex = 0;
            this.button_help.Text = "Помощь";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel_vhod);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HelloForm";
            this.panel_vhod.ResumeLayout(false);
            this.panel_vhod.PerformLayout();
            this.panel_registr.ResumeLayout(false);
            this.panel_registr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_vhod;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.Button button_vhod;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_vhod;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_loginusing;
        private System.Windows.Forms.Panel panel_registr;
        private System.Windows.Forms.Label label_name_reg;
        private System.Windows.Forms.TextBox textBox_name_reg;
        private System.Windows.Forms.Button button_reg_new;
        private System.Windows.Forms.Label label_pass_reg;
        private System.Windows.Forms.Label label_login_reg;
        private System.Windows.Forms.Label label_reg_reg;
        private System.Windows.Forms.TextBox textBox_pass_reg;
        private System.Windows.Forms.TextBox textBox_log_reg;
        private System.Windows.Forms.Button button_help_reg;
        private System.Windows.Forms.Button button_vhod_reg;
    }
}

