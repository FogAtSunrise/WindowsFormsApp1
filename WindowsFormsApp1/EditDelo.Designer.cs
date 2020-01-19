namespace WindowsFormsApp1
{
    partial class EditDeloForm
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
            this.dateTimePicker_edit = new System.Windows.Forms.DateTimePicker();
            this.textBox_article = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_time = new System.Windows.Forms.Label();
            this.label_article = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_error_time = new System.Windows.Forms.Label();
            this.label_molodec = new System.Windows.Forms.Label();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.checkBox_notifications = new System.Windows.Forms.CheckBox();
            this.textBox_hours = new System.Windows.Forms.TextBox();
            this.textBox_minutes = new System.Windows.Forms.TextBox();
            this.panel_notifications = new System.Windows.Forms.Panel();
            this.textBox_notif_interval = new System.Windows.Forms.TextBox();
            this.textBox_notif_repeat = new System.Windows.Forms.TextBox();
            this.textBox_notif_before = new System.Windows.Forms.TextBox();
            this.checkBox_notif_interval = new System.Windows.Forms.CheckBox();
            this.checkBox_notif_repeat = new System.Windows.Forms.CheckBox();
            this.checkBox_notif_before = new System.Windows.Forms.CheckBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.checkBox_done = new System.Windows.Forms.CheckBox();
            this.panel_notifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker_edit
            // 
            this.dateTimePicker_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_edit.Location = new System.Drawing.Point(403, 30);
            this.dateTimePicker_edit.Name = "dateTimePicker_edit";
            this.dateTimePicker_edit.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_edit.TabIndex = 0;
            // 
            // textBox_article
            // 
            this.textBox_article.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_article.Location = new System.Drawing.Point(97, 78);
            this.textBox_article.Name = "textBox_article";
            this.textBox_article.Size = new System.Drawing.Size(227, 20);
            this.textBox_article.TabIndex = 1;
            // 
            // textBox_description
            // 
            this.textBox_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_description.Location = new System.Drawing.Point(97, 115);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(269, 92);
            this.textBox_description.TabIndex = 2;
            // 
            // label_time
            // 
            this.label_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(30, 32);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(40, 13);
            this.label_time.TabIndex = 3;
            this.label_time.Text = "Время";
            // 
            // label_article
            // 
            this.label_article.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_article.AutoSize = true;
            this.label_article.Location = new System.Drawing.Point(30, 81);
            this.label_article.Name = "label_article";
            this.label_article.Size = new System.Drawing.Size(61, 13);
            this.label_article.TabIndex = 4;
            this.label_article.Text = "Заголовок";
            // 
            // label_description
            // 
            this.label_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_description.AutoSize = true;
            this.label_description.Location = new System.Drawing.Point(30, 118);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(57, 13);
            this.label_description.TabIndex = 5;
            this.label_description.Text = "Описание";
            // 
            // label_error_time
            // 
            this.label_error_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_error_time.AutoSize = true;
            this.label_error_time.ForeColor = System.Drawing.Color.Red;
            this.label_error_time.Location = new System.Drawing.Point(94, 62);
            this.label_error_time.Name = "label_error_time";
            this.label_error_time.Size = new System.Drawing.Size(155, 13);
            this.label_error_time.TabIndex = 6;
            this.label_error_time.Text = "Неправильно введено время";
            this.label_error_time.Visible = false;
            // 
            // label_molodec
            // 
            this.label_molodec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_molodec.AutoSize = true;
            this.label_molodec.ForeColor = System.Drawing.Color.Green;
            this.label_molodec.Location = new System.Drawing.Point(201, 394);
            this.label_molodec.Name = "label_molodec";
            this.label_molodec.Size = new System.Drawing.Size(100, 13);
            this.label_molodec.TabIndex = 7;
            this.label_molodec.Text = "Запись изменена!";
            this.label_molodec.Visible = false;
            // 
            // comboBox_month
            // 
            this.comboBox_month.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Items.AddRange(new object[] {
            "(Пусто)",
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.comboBox_month.Location = new System.Drawing.Point(235, 29);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(121, 21);
            this.comboBox_month.TabIndex = 8;
            // 
            // checkBox_notifications
            // 
            this.checkBox_notifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_notifications.AutoSize = true;
            this.checkBox_notifications.Location = new System.Drawing.Point(97, 231);
            this.checkBox_notifications.Name = "checkBox_notifications";
            this.checkBox_notifications.Size = new System.Drawing.Size(91, 17);
            this.checkBox_notifications.TabIndex = 9;
            this.checkBox_notifications.Text = "Оповещения";
            this.checkBox_notifications.UseVisualStyleBackColor = true;
            this.checkBox_notifications.CheckedChanged += new System.EventHandler(this.checkBox_notifications_CheckedChanged);
            // 
            // textBox_hours
            // 
            this.textBox_hours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_hours.Location = new System.Drawing.Point(97, 29);
            this.textBox_hours.Name = "textBox_hours";
            this.textBox_hours.Size = new System.Drawing.Size(40, 20);
            this.textBox_hours.TabIndex = 10;
            // 
            // textBox_minutes
            // 
            this.textBox_minutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_minutes.Location = new System.Drawing.Point(150, 29);
            this.textBox_minutes.Name = "textBox_minutes";
            this.textBox_minutes.Size = new System.Drawing.Size(39, 20);
            this.textBox_minutes.TabIndex = 11;
            // 
            // panel_notifications
            // 
            this.panel_notifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_notifications.Controls.Add(this.textBox_notif_interval);
            this.panel_notifications.Controls.Add(this.textBox_notif_repeat);
            this.panel_notifications.Controls.Add(this.textBox_notif_before);
            this.panel_notifications.Controls.Add(this.checkBox_notif_interval);
            this.panel_notifications.Controls.Add(this.checkBox_notif_repeat);
            this.panel_notifications.Controls.Add(this.checkBox_notif_before);
            this.panel_notifications.Location = new System.Drawing.Point(97, 266);
            this.panel_notifications.Name = "panel_notifications";
            this.panel_notifications.Size = new System.Drawing.Size(306, 115);
            this.panel_notifications.TabIndex = 12;
            this.panel_notifications.Visible = false;
            // 
            // textBox_notif_interval
            // 
            this.textBox_notif_interval.Location = new System.Drawing.Point(124, 83);
            this.textBox_notif_interval.Name = "textBox_notif_interval";
            this.textBox_notif_interval.Size = new System.Drawing.Size(100, 20);
            this.textBox_notif_interval.TabIndex = 5;
            // 
            // textBox_notif_repeat
            // 
            this.textBox_notif_repeat.Location = new System.Drawing.Point(124, 50);
            this.textBox_notif_repeat.Name = "textBox_notif_repeat";
            this.textBox_notif_repeat.Size = new System.Drawing.Size(100, 20);
            this.textBox_notif_repeat.TabIndex = 4;
            // 
            // textBox_notif_before
            // 
            this.textBox_notif_before.Location = new System.Drawing.Point(124, 14);
            this.textBox_notif_before.Name = "textBox_notif_before";
            this.textBox_notif_before.Size = new System.Drawing.Size(100, 20);
            this.textBox_notif_before.TabIndex = 3;
            // 
            // checkBox_notif_interval
            // 
            this.checkBox_notif_interval.AutoSize = true;
            this.checkBox_notif_interval.Location = new System.Drawing.Point(12, 83);
            this.checkBox_notif_interval.Name = "checkBox_notif_interval";
            this.checkBox_notif_interval.Size = new System.Drawing.Size(75, 17);
            this.checkBox_notif_interval.TabIndex = 2;
            this.checkBox_notif_interval.Text = "Интервал";
            this.checkBox_notif_interval.UseVisualStyleBackColor = true;
            // 
            // checkBox_notif_repeat
            // 
            this.checkBox_notif_repeat.AutoSize = true;
            this.checkBox_notif_repeat.Location = new System.Drawing.Point(12, 50);
            this.checkBox_notif_repeat.Name = "checkBox_notif_repeat";
            this.checkBox_notif_repeat.Size = new System.Drawing.Size(80, 17);
            this.checkBox_notif_repeat.TabIndex = 1;
            this.checkBox_notif_repeat.Text = "Повторить";
            this.checkBox_notif_repeat.UseVisualStyleBackColor = true;
            // 
            // checkBox_notif_before
            // 
            this.checkBox_notif_before.AutoSize = true;
            this.checkBox_notif_before.Location = new System.Drawing.Point(12, 14);
            this.checkBox_notif_before.Name = "checkBox_notif_before";
            this.checkBox_notif_before.Size = new System.Drawing.Size(101, 17);
            this.checkBox_notif_before.TabIndex = 0;
            this.checkBox_notif_before.Text = "Оповестить за";
            this.checkBox_notif_before.UseVisualStyleBackColor = true;
            // 
            // button_edit
            // 
            this.button_edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_edit.Location = new System.Drawing.Point(226, 419);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 23);
            this.button_edit.TabIndex = 13;
            this.button_edit.Text = "Изменить";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // checkBox_done
            // 
            this.checkBox_done.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_done.AutoSize = true;
            this.checkBox_done.Location = new System.Drawing.Point(426, 118);
            this.checkBox_done.Name = "checkBox_done";
            this.checkBox_done.Size = new System.Drawing.Size(128, 17);
            this.checkBox_done.TabIndex = 14;
            this.checkBox_done.Text = "Задание выполнено";
            this.checkBox_done.UseVisualStyleBackColor = true;
            // 
            // EditDeloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 479);
            this.Controls.Add(this.checkBox_done);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.panel_notifications);
            this.Controls.Add(this.textBox_minutes);
            this.Controls.Add(this.textBox_hours);
            this.Controls.Add(this.checkBox_notifications);
            this.Controls.Add(this.comboBox_month);
            this.Controls.Add(this.label_molodec);
            this.Controls.Add(this.label_error_time);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_article);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_article);
            this.Controls.Add(this.dateTimePicker_edit);
            this.Name = "EditDeloForm";
            this.Text = "Редактирование записи";
            this.Load += new System.EventHandler(this.EditDeloForm_Load);
            this.panel_notifications.ResumeLayout(false);
            this.panel_notifications.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_edit;
        private System.Windows.Forms.TextBox textBox_article;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_article;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_error_time;
        private System.Windows.Forms.Label label_molodec;
        private System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.CheckBox checkBox_notifications;
        private System.Windows.Forms.TextBox textBox_hours;
        private System.Windows.Forms.TextBox textBox_minutes;
        private System.Windows.Forms.Panel panel_notifications;
        private System.Windows.Forms.TextBox textBox_notif_interval;
        private System.Windows.Forms.TextBox textBox_notif_repeat;
        private System.Windows.Forms.TextBox textBox_notif_before;
        private System.Windows.Forms.CheckBox checkBox_notif_interval;
        private System.Windows.Forms.CheckBox checkBox_notif_repeat;
        private System.Windows.Forms.CheckBox checkBox_notif_before;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.CheckBox checkBox_done;
    }
}