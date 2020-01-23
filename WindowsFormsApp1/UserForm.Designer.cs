namespace WindowsFormsApp1
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_old_pass = new System.Windows.Forms.TextBox();
            this.textBox_new_pass = new System.Windows.Forms.TextBox();
            this.textBox_new_pass_con = new System.Windows.Forms.TextBox();
            this.label_old_pass = new System.Windows.Forms.Label();
            this.label_new_pass = new System.Windows.Forms.Label();
            this.label_new_pass_con = new System.Windows.Forms.Label();
            this.label_error_old_pass = new System.Windows.Forms.Label();
            this.label_error_new_pass = new System.Windows.Forms.Label();
            this.label_pass_change = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя...........................................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин........................................";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата регистрации.................";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(208, 11);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(113, 21);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(210, 73);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(113, 21);
            this.textBoxLog.TabIndex = 5;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(210, 127);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(113, 21);
            this.textBoxDate.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 67);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(116, 301);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 27);
            this.button3.TabIndex = 9;
            this.button3.Text = "Изменить пароль";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(207, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Пустая запись";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(207, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Пустая запись";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(207, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Должно быть не меньше 4 и не больше 20 символов";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(205, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Должно быть не меньше 4 и не больше 20 символов";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(205, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Запись не должна содержать символов \"#\", \"%\", \"$\"";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(207, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(304, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Запись не должна содержать символов \"#\", \"%\", \"$\"";
            this.label9.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(380, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 30);
            this.button4.TabIndex = 16;
            this.button4.Text = "Удалить учетную запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_old_pass
            // 
            this.textBox_old_pass.Location = new System.Drawing.Point(208, 163);
            this.textBox_old_pass.Name = "textBox_old_pass";
            this.textBox_old_pass.PasswordChar = '*';
            this.textBox_old_pass.Size = new System.Drawing.Size(113, 21);
            this.textBox_old_pass.TabIndex = 17;
            // 
            // textBox_new_pass
            // 
            this.textBox_new_pass.Location = new System.Drawing.Point(208, 205);
            this.textBox_new_pass.Name = "textBox_new_pass";
            this.textBox_new_pass.PasswordChar = '*';
            this.textBox_new_pass.Size = new System.Drawing.Size(111, 21);
            this.textBox_new_pass.TabIndex = 18;
            // 
            // textBox_new_pass_con
            // 
            this.textBox_new_pass_con.Location = new System.Drawing.Point(208, 243);
            this.textBox_new_pass_con.Name = "textBox_new_pass_con";
            this.textBox_new_pass_con.PasswordChar = '*';
            this.textBox_new_pass_con.Size = new System.Drawing.Size(109, 21);
            this.textBox_new_pass_con.TabIndex = 19;
            // 
            // label_old_pass
            // 
            this.label_old_pass.AutoSize = true;
            this.label_old_pass.Location = new System.Drawing.Point(24, 169);
            this.label_old_pass.Name = "label_old_pass";
            this.label_old_pass.Size = new System.Drawing.Size(97, 15);
            this.label_old_pass.TabIndex = 20;
            this.label_old_pass.Text = "Старый пароль";
            // 
            // label_new_pass
            // 
            this.label_new_pass.AutoSize = true;
            this.label_new_pass.Location = new System.Drawing.Point(24, 205);
            this.label_new_pass.Name = "label_new_pass";
            this.label_new_pass.Size = new System.Drawing.Size(91, 15);
            this.label_new_pass.TabIndex = 21;
            this.label_new_pass.Text = "Новый пароль";
            // 
            // label_new_pass_con
            // 
            this.label_new_pass_con.AutoSize = true;
            this.label_new_pass_con.Location = new System.Drawing.Point(24, 246);
            this.label_new_pass_con.Name = "label_new_pass_con";
            this.label_new_pass_con.Size = new System.Drawing.Size(171, 15);
            this.label_new_pass_con.TabIndex = 22;
            this.label_new_pass_con.Text = "Подтвердите новый пароль";
            // 
            // label_error_old_pass
            // 
            this.label_error_old_pass.AutoSize = true;
            this.label_error_old_pass.ForeColor = System.Drawing.Color.Red;
            this.label_error_old_pass.Location = new System.Drawing.Point(207, 187);
            this.label_error_old_pass.Name = "label_error_old_pass";
            this.label_error_old_pass.Size = new System.Drawing.Size(143, 15);
            this.label_error_old_pass.TabIndex = 23;
            this.label_error_old_pass.Text = "Неправильный пароль!";
            this.label_error_old_pass.Visible = false;
            // 
            // label_error_new_pass
            // 
            this.label_error_new_pass.AutoSize = true;
            this.label_error_new_pass.ForeColor = System.Drawing.Color.Red;
            this.label_error_new_pass.Location = new System.Drawing.Point(208, 271);
            this.label_error_new_pass.Name = "label_error_new_pass";
            this.label_error_new_pass.Size = new System.Drawing.Size(138, 15);
            this.label_error_new_pass.TabIndex = 24;
            this.label_error_new_pass.Text = "Пароли не совпадают!";
            this.label_error_new_pass.Visible = false;
            // 
            // label_pass_change
            // 
            this.label_pass_change.AutoSize = true;
            this.label_pass_change.ForeColor = System.Drawing.Color.Green;
            this.label_pass_change.Location = new System.Drawing.Point(113, 271);
            this.label_pass_change.Name = "label_pass_change";
            this.label_pass_change.Size = new System.Drawing.Size(158, 15);
            this.label_pass_change.TabIndex = 25;
            this.label_pass_change.Text = "Пароль успешно изменен!";
            this.label_pass_change.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(507, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Помощь";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(594, 356);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label_pass_change);
            this.Controls.Add(this.label_error_new_pass);
            this.Controls.Add(this.label_error_old_pass);
            this.Controls.Add(this.label_new_pass_con);
            this.Controls.Add(this.label_new_pass);
            this.Controls.Add(this.label_old_pass);
            this.Controls.Add(this.textBox_new_pass_con);
            this.Controls.Add(this.textBox_new_pass);
            this.Controls.Add(this.textBox_old_pass);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserForm";
            this.Text = "Пользователь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserForm_FormClosed);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox_old_pass;
        private System.Windows.Forms.TextBox textBox_new_pass;
        private System.Windows.Forms.TextBox textBox_new_pass_con;
        private System.Windows.Forms.Label label_old_pass;
        private System.Windows.Forms.Label label_new_pass;
        private System.Windows.Forms.Label label_new_pass_con;
        private System.Windows.Forms.Label label_error_old_pass;
        private System.Windows.Forms.Label label_error_new_pass;
        private System.Windows.Forms.Label label_pass_change;
        private System.Windows.Forms.Button button5;
    }
}