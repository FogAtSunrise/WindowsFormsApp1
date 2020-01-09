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
            this.button_help = new System.Windows.Forms.Button();
            this.textBox_loginusing = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_vhod = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.button_vhod = new System.Windows.Forms.Button();
            this.button_reg = new System.Windows.Forms.Button();
            this.panel_vhod.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_vhod
            // 
            this.panel_vhod.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel_vhod.Controls.Add(this.button_reg);
            this.panel_vhod.Controls.Add(this.button_vhod);
            this.panel_vhod.Controls.Add(this.label_pass);
            this.panel_vhod.Controls.Add(this.label_login);
            this.panel_vhod.Controls.Add(this.label_vhod);
            this.panel_vhod.Controls.Add(this.textBox_password);
            this.panel_vhod.Controls.Add(this.textBox_loginusing);
            this.panel_vhod.Controls.Add(this.button_help);
            this.panel_vhod.Location = new System.Drawing.Point(0, -2);
            this.panel_vhod.Name = "panel_vhod";
            this.panel_vhod.Size = new System.Drawing.Size(800, 459);
            this.panel_vhod.TabIndex = 0;
            // 
            // button_help
            // 
            this.button_help.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_help.Location = new System.Drawing.Point(698, 13);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(88, 26);
            this.button_help.TabIndex = 0;
            this.button_help.Text = "Помощь";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // textBox_loginusing
            // 
            this.textBox_loginusing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_loginusing.Location = new System.Drawing.Point(290, 133);
            this.textBox_loginusing.Name = "textBox_loginusing";
            this.textBox_loginusing.Size = new System.Drawing.Size(221, 34);
            this.textBox_loginusing.TabIndex = 1;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(290, 204);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(221, 34);
            this.textBox_password.TabIndex = 2;
            // 
            // label_vhod
            // 
            this.label_vhod.AutoSize = true;
            this.label_vhod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_vhod.Location = new System.Drawing.Point(357, 84);
            this.label_vhod.Name = "label_vhod";
            this.label_vhod.Size = new System.Drawing.Size(75, 29);
            this.label_vhod.TabIndex = 3;
            this.label_vhod.Text = "Вход";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(201, 133);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(83, 29);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "Логин";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pass.Location = new System.Drawing.Point(185, 209);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(99, 29);
            this.label_pass.TabIndex = 5;
            this.label_pass.Text = "Пароль";
            // 
            // button_vhod
            // 
            this.button_vhod.Location = new System.Drawing.Point(290, 272);
            this.button_vhod.Name = "button_vhod";
            this.button_vhod.Size = new System.Drawing.Size(221, 39);
            this.button_vhod.TabIndex = 6;
            this.button_vhod.Text = "Войти";
            this.button_vhod.UseVisualStyleBackColor = true;
            this.button_vhod.Click += new System.EventHandler(this.button_vhod_Click);
            // 
            // button_reg
            // 
            this.button_reg.Location = new System.Drawing.Point(290, 383);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(221, 39);
            this.button_reg.TabIndex = 7;
            this.button_reg.Text = "Регистрация";
            this.button_reg.UseVisualStyleBackColor = true;
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_vhod);
            this.Name = "HelloForm";
            this.panel_vhod.ResumeLayout(false);
            this.panel_vhod.PerformLayout();
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
    }
}

