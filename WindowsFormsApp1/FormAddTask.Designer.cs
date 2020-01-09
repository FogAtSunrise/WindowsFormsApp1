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
            this.checkBox_notification_minute = new System.Windows.Forms.CheckBox();
            this.checkBox_repeat = new System.Windows.Forms.CheckBox();
            this.checkBox_interval = new System.Windows.Forms.CheckBox();
            this.textBox_notification_minute = new System.Windows.Forms.TextBox();
            this.textBox_repeat_times = new System.Windows.Forms.TextBox();
            this.textBox_interval_minutes = new System.Windows.Forms.TextBox();
            this.panel_notifications_on.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_add_task
            // 
            this.label_add_task.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_add_task.AutoSize = true;
            this.label_add_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_task.Location = new System.Drawing.Point(62, 22);
            this.label_add_task.Name = "label_add_task";
            this.label_add_task.Size = new System.Drawing.Size(215, 24);
            this.label_add_task.TabIndex = 0;
            this.label_add_task.Text = "Добавление задачи на";
            // 
            // comboBox_dnm
            // 
            this.comboBox_dnm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox_dnm.FormattingEnabled = true;
            this.comboBox_dnm.Items.AddRange(new object[] {
            "День",
            "Неделя",
            "Месяц"});
            this.comboBox_dnm.Location = new System.Drawing.Point(331, 27);
            this.comboBox_dnm.Name = "comboBox_dnm";
            this.comboBox_dnm.Size = new System.Drawing.Size(121, 21);
            this.comboBox_dnm.TabIndex = 1;
            // 
            // label_article
            // 
            this.label_article.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_article.AutoSize = true;
            this.label_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_article.Location = new System.Drawing.Point(94, 107);
            this.label_article.Name = "label_article";
            this.label_article.Size = new System.Drawing.Size(54, 24);
            this.label_article.TabIndex = 2;
            this.label_article.Text = "Цель";
            // 
            // label_description
            // 
            this.label_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_description.Location = new System.Drawing.Point(53, 139);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(100, 24);
            this.label_description.TabIndex = 3;
            this.label_description.Text = "Описание";
            // 
            // textBox_article
            // 
            this.textBox_article.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_article.Location = new System.Drawing.Point(177, 104);
            this.textBox_article.Name = "textBox_article";
            this.textBox_article.Size = new System.Drawing.Size(100, 29);
            this.textBox_article.TabIndex = 4;
            // 
            // textBox_description
            // 
            this.textBox_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_description.Location = new System.Drawing.Point(177, 139);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(275, 65);
            this.textBox_description.TabIndex = 5;
            // 
            // label_add_time
            // 
            this.label_add_time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_add_time.AutoSize = true;
            this.label_add_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_time.Location = new System.Drawing.Point(86, 66);
            this.label_add_time.Name = "label_add_time";
            this.label_add_time.Size = new System.Drawing.Size(67, 24);
            this.label_add_time.TabIndex = 6;
            this.label_add_time.Text = "Время";
            // 
            // textBox_hour
            // 
            this.textBox_hour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_hour.Location = new System.Drawing.Point(177, 66);
            this.textBox_hour.Name = "textBox_hour";
            this.textBox_hour.Size = new System.Drawing.Size(34, 29);
            this.textBox_hour.TabIndex = 7;
            // 
            // textBox_minutes
            // 
            this.textBox_minutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_minutes.Location = new System.Drawing.Point(217, 66);
            this.textBox_minutes.Name = "textBox_minutes";
            this.textBox_minutes.Size = new System.Drawing.Size(35, 29);
            this.textBox_minutes.TabIndex = 8;
            // 
            // checkBox_notifications
            // 
            this.checkBox_notifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_notifications.AutoSize = true;
            this.checkBox_notifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_notifications.Location = new System.Drawing.Point(66, 223);
            this.checkBox_notifications.Name = "checkBox_notifications";
            this.checkBox_notifications.Size = new System.Drawing.Size(144, 28);
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
            this.panel_notifications_on.Location = new System.Drawing.Point(66, 258);
            this.panel_notifications_on.Name = "panel_notifications_on";
            this.panel_notifications_on.Size = new System.Drawing.Size(537, 180);
            this.panel_notifications_on.TabIndex = 10;
            this.panel_notifications_on.Visible = false;
            // 
            // checkBox_notification_minute
            // 
            this.checkBox_notification_minute.AutoSize = true;
            this.checkBox_notification_minute.Location = new System.Drawing.Point(32, 24);
            this.checkBox_notification_minute.Name = "checkBox_notification_minute";
            this.checkBox_notification_minute.Size = new System.Drawing.Size(170, 28);
            this.checkBox_notification_minute.TabIndex = 0;
            this.checkBox_notification_minute.Text = "Оповестить за ";
            this.checkBox_notification_minute.UseVisualStyleBackColor = true;
            // 
            // checkBox_repeat
            // 
            this.checkBox_repeat.AutoSize = true;
            this.checkBox_repeat.Location = new System.Drawing.Point(32, 59);
            this.checkBox_repeat.Name = "checkBox_repeat";
            this.checkBox_repeat.Size = new System.Drawing.Size(133, 28);
            this.checkBox_repeat.TabIndex = 1;
            this.checkBox_repeat.Text = "Повторить ";
            this.checkBox_repeat.UseVisualStyleBackColor = true;
            // 
            // checkBox_interval
            // 
            this.checkBox_interval.AutoSize = true;
            this.checkBox_interval.Location = new System.Drawing.Point(32, 94);
            this.checkBox_interval.Name = "checkBox_interval";
            this.checkBox_interval.Size = new System.Drawing.Size(116, 28);
            this.checkBox_interval.TabIndex = 2;
            this.checkBox_interval.Text = "Интервал";
            this.checkBox_interval.UseVisualStyleBackColor = true;
            // 
            // textBox_notification_minute
            // 
            this.textBox_notification_minute.Location = new System.Drawing.Point(208, 22);
            this.textBox_notification_minute.Name = "textBox_notification_minute";
            this.textBox_notification_minute.Size = new System.Drawing.Size(100, 29);
            this.textBox_notification_minute.TabIndex = 3;
            // 
            // textBox_repeat_times
            // 
            this.textBox_repeat_times.Location = new System.Drawing.Point(208, 59);
            this.textBox_repeat_times.Name = "textBox_repeat_times";
            this.textBox_repeat_times.Size = new System.Drawing.Size(100, 29);
            this.textBox_repeat_times.TabIndex = 4;
            // 
            // textBox_interval_minutes
            // 
            this.textBox_interval_minutes.Location = new System.Drawing.Point(208, 94);
            this.textBox_interval_minutes.Name = "textBox_interval_minutes";
            this.textBox_interval_minutes.Size = new System.Drawing.Size(100, 29);
            this.textBox_interval_minutes.TabIndex = 5;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}