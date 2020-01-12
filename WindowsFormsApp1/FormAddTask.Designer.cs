﻿namespace WindowsFormsApp1
{
    partial class AddForm
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
            this.label_add_task = new System.Windows.Forms.Label();
            this.comboBox_dnm = new System.Windows.Forms.ComboBox();
            this.label_article = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_article = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_add_time = new System.Windows.Forms.Label();
            this.textBox_hour = new System.Windows.Forms.TextBox();
            this.textBox_minutes = new System.Windows.Forms.TextBox();
            this.checkBox_notifications = new System.Windows.Forms.CheckBox();
            this.panel_notifications_on = new System.Windows.Forms.Panel();
            this.textBox_interval_minutes = new System.Windows.Forms.TextBox();
            this.textBox_repeat_times = new System.Windows.Forms.TextBox();
            this.textBox_notification_minute = new System.Windows.Forms.TextBox();
            this.checkBox_interval = new System.Windows.Forms.CheckBox();
            this.checkBox_repeat = new System.Windows.Forms.CheckBox();
            this.checkBox_notification_minute = new System.Windows.Forms.CheckBox();
            this.label_error_time = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel_notifications_on.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_add_task
            // 
            this.label_add_task.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_add_task.AutoSize = true;
            this.label_add_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_task.Location = new System.Drawing.Point(83, 42);
            this.label_add_task.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_add_task.Name = "label_add_task";
            this.label_add_task.Size = new System.Drawing.Size(278, 29);
            this.label_add_task.TabIndex = 0;
            this.label_add_task.Text = "Добавление задачи на";
            // 
            // comboBox_dnm
            // 
            this.comboBox_dnm.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.comboBox_dnm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_dnm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dnm.FormattingEnabled = true;
            this.comboBox_dnm.Items.AddRange(new object[] {
            "День",
            "Неделя",
            "Месяц"});
            this.comboBox_dnm.Location = new System.Drawing.Point(441, 49);
            this.comboBox_dnm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_dnm.Name = "comboBox_dnm";
            this.comboBox_dnm.Size = new System.Drawing.Size(160, 24);
            this.comboBox_dnm.TabIndex = 1;
            // 
            // label_article
            // 
            this.label_article.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_article.AutoSize = true;
            this.label_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_article.Location = new System.Drawing.Point(125, 148);
            this.label_article.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_article.Name = "label_article";
            this.label_article.Size = new System.Drawing.Size(72, 29);
            this.label_article.TabIndex = 2;
            this.label_article.Text = "Цель";
            // 
            // label_description
            // 
            this.label_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_description.Location = new System.Drawing.Point(71, 187);
            this.label_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(131, 29);
            this.label_description.TabIndex = 3;
            this.label_description.Text = "Описание";
            // 
            // textBox_article
            // 
            this.textBox_article.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_article.Location = new System.Drawing.Point(236, 144);
            this.textBox_article.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_article.Name = "textBox_article";
            this.textBox_article.Size = new System.Drawing.Size(132, 34);
            this.textBox_article.TabIndex = 4;
            // 
            // textBox_description
            // 
            this.textBox_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_description.Location = new System.Drawing.Point(236, 187);
            this.textBox_description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(365, 79);
            this.textBox_description.TabIndex = 5;
            // 
            // label_add_time
            // 
            this.label_add_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_add_time.AutoSize = true;
            this.label_add_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_time.Location = new System.Drawing.Point(115, 97);
            this.label_add_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_add_time.Name = "label_add_time";
            this.label_add_time.Size = new System.Drawing.Size(89, 29);
            this.label_add_time.TabIndex = 6;
            this.label_add_time.Text = "Время";
            // 
            // textBox_hour
            // 
            this.textBox_hour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_hour.Location = new System.Drawing.Point(236, 97);
            this.textBox_hour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_hour.Name = "textBox_hour";
            this.textBox_hour.Size = new System.Drawing.Size(44, 34);
            this.textBox_hour.TabIndex = 7;
            // 
            // textBox_minutes
            // 
            this.textBox_minutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_minutes.Location = new System.Drawing.Point(289, 97);
            this.textBox_minutes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_minutes.Name = "textBox_minutes";
            this.textBox_minutes.Size = new System.Drawing.Size(45, 34);
            this.textBox_minutes.TabIndex = 8;
            // 
            // checkBox_notifications
            // 
            this.checkBox_notifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_notifications.AutoSize = true;
            this.checkBox_notifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_notifications.Location = new System.Drawing.Point(88, 290);
            this.checkBox_notifications.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_notifications.Name = "checkBox_notifications";
            this.checkBox_notifications.Size = new System.Drawing.Size(188, 33);
            this.checkBox_notifications.TabIndex = 9;
            this.checkBox_notifications.Text = "Оповещения";
            this.checkBox_notifications.UseVisualStyleBackColor = true;
            this.checkBox_notifications.CheckedChanged += new System.EventHandler(this.checkBox_notifications_CheckedChanged);
            // 
            // panel_notifications_on
            // 
            this.panel_notifications_on.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_notifications_on.Controls.Add(this.textBox_interval_minutes);
            this.panel_notifications_on.Controls.Add(this.textBox_repeat_times);
            this.panel_notifications_on.Controls.Add(this.textBox_notification_minute);
            this.panel_notifications_on.Controls.Add(this.checkBox_interval);
            this.panel_notifications_on.Controls.Add(this.checkBox_repeat);
            this.panel_notifications_on.Controls.Add(this.checkBox_notification_minute);
            this.panel_notifications_on.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_notifications_on.Location = new System.Drawing.Point(88, 334);
            this.panel_notifications_on.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_notifications_on.Name = "panel_notifications_on";
            this.panel_notifications_on.Size = new System.Drawing.Size(716, 161);
            this.panel_notifications_on.TabIndex = 10;
            this.panel_notifications_on.Visible = false;
            // 
            // textBox_interval_minutes
            // 
            this.textBox_interval_minutes.Location = new System.Drawing.Point(277, 116);
            this.textBox_interval_minutes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_interval_minutes.Name = "textBox_interval_minutes";
            this.textBox_interval_minutes.Size = new System.Drawing.Size(132, 34);
            this.textBox_interval_minutes.TabIndex = 5;
            // 
            // textBox_repeat_times
            // 
            this.textBox_repeat_times.Location = new System.Drawing.Point(277, 73);
            this.textBox_repeat_times.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_repeat_times.Name = "textBox_repeat_times";
            this.textBox_repeat_times.Size = new System.Drawing.Size(132, 34);
            this.textBox_repeat_times.TabIndex = 4;
            // 
            // textBox_notification_minute
            // 
            this.textBox_notification_minute.Location = new System.Drawing.Point(277, 27);
            this.textBox_notification_minute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_notification_minute.Name = "textBox_notification_minute";
            this.textBox_notification_minute.Size = new System.Drawing.Size(132, 34);
            this.textBox_notification_minute.TabIndex = 3;
            // 
            // checkBox_interval
            // 
            this.checkBox_interval.AutoSize = true;
            this.checkBox_interval.Location = new System.Drawing.Point(43, 116);
            this.checkBox_interval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_interval.Name = "checkBox_interval";
            this.checkBox_interval.Size = new System.Drawing.Size(149, 33);
            this.checkBox_interval.TabIndex = 2;
            this.checkBox_interval.Text = "Интервал";
            this.checkBox_interval.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeat
            // 
            this.checkBox_repeat.AutoSize = true;
            this.checkBox_repeat.Location = new System.Drawing.Point(43, 73);
            this.checkBox_repeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_repeat.Name = "checkBox_repeat";
            this.checkBox_repeat.Size = new System.Drawing.Size(165, 33);
            this.checkBox_repeat.TabIndex = 1;
            this.checkBox_repeat.Text = "Повторить ";
            this.checkBox_repeat.UseVisualStyleBackColor = true;
            // 
            // checkBox_notification_minute
            // 
            this.checkBox_notification_minute.AutoSize = true;
            this.checkBox_notification_minute.Location = new System.Drawing.Point(43, 30);
            this.checkBox_notification_minute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_notification_minute.Name = "checkBox_notification_minute";
            this.checkBox_notification_minute.Size = new System.Drawing.Size(212, 33);
            this.checkBox_notification_minute.TabIndex = 0;
            this.checkBox_notification_minute.Text = "Оповестить за ";
            this.checkBox_notification_minute.UseVisualStyleBackColor = true;
            // 
            // label_error_time
            // 
            this.label_error_time.AutoSize = true;
            this.label_error_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_error_time.ForeColor = System.Drawing.Color.Red;
            this.label_error_time.Location = new System.Drawing.Point(345, 97);
            this.label_error_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_error_time.Name = "label_error_time";
            this.label_error_time.Size = new System.Drawing.Size(256, 20);
            this.label_error_time.TabIndex = 11;
            this.label_error_time.Text = "Неправильно введено время";
            this.label_error_time.Visible = false;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(301, 518);
            this.button_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(183, 39);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(634, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 586);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_error_time);
            this.Controls.Add(this.panel_notifications_on);
            this.Controls.Add(this.checkBox_notifications);
            this.Controls.Add(this.textBox_minutes);
            this.Controls.Add(this.textBox_hour);
            this.Controls.Add(this.label_add_time);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_article);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_article);
            this.Controls.Add(this.comboBox_dnm);
            this.Controls.Add(this.label_add_task);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddForm";
            this.Text = "Добавление задачи";
            this.panel_notifications_on.ResumeLayout(false);
            this.panel_notifications_on.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add_task;
        private System.Windows.Forms.ComboBox comboBox_dnm;
        private System.Windows.Forms.Label label_article;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textBox_article;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label_add_time;
        private System.Windows.Forms.TextBox textBox_hour;
        private System.Windows.Forms.TextBox textBox_minutes;
        private System.Windows.Forms.CheckBox checkBox_notifications;
        private System.Windows.Forms.Panel panel_notifications_on;
        private System.Windows.Forms.TextBox textBox_interval_minutes;
        private System.Windows.Forms.TextBox textBox_repeat_times;
        private System.Windows.Forms.TextBox textBox_notification_minute;
        private System.Windows.Forms.CheckBox checkBox_interval;
        private System.Windows.Forms.CheckBox checkBox_repeat;
        private System.Windows.Forms.CheckBox checkBox_notification_minute;
        private System.Windows.Forms.Label label_error_time;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}