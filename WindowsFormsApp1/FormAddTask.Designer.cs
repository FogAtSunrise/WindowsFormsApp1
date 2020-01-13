namespace WindowsFormsApp1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_molodec = new System.Windows.Forms.Label();
            this.panel_notifications_on.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_add_task
            // 
            this.label_add_task.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_add_task.AutoSize = true;
            this.label_add_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_add_task.Location = new System.Drawing.Point(62, 34);
            this.label_add_task.Name = "label_add_task";
            this.label_add_task.Size = new System.Drawing.Size(215, 24);
            this.label_add_task.TabIndex = 0;
            this.label_add_task.Text = "Добавление задачи на";
            // 
            // label_article
            // 
            this.label_article.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_article.AutoSize = true;
            this.label_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_article.Location = new System.Drawing.Point(94, 120);
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
            this.label_description.Location = new System.Drawing.Point(53, 152);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(100, 24);
            this.label_description.TabIndex = 3;
            this.label_description.Text = "Описание";
            // 
            // textBox_article
            // 
            this.textBox_article.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_article.Location = new System.Drawing.Point(177, 117);
            this.textBox_article.Name = "textBox_article";
            this.textBox_article.Size = new System.Drawing.Size(100, 29);
            this.textBox_article.TabIndex = 4;
            // 
            // textBox_description
            // 
            this.textBox_description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_description.Location = new System.Drawing.Point(177, 152);
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
            this.label_add_time.Location = new System.Drawing.Point(86, 79);
            this.label_add_time.Name = "label_add_time";
            this.label_add_time.Size = new System.Drawing.Size(67, 24);
            this.label_add_time.TabIndex = 6;
            this.label_add_time.Text = "Время";
            // 
            // textBox_hour
            // 
            this.textBox_hour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_hour.Location = new System.Drawing.Point(177, 79);
            this.textBox_hour.Name = "textBox_hour";
            this.textBox_hour.Size = new System.Drawing.Size(34, 29);
            this.textBox_hour.TabIndex = 7;
            // 
            // textBox_minutes
            // 
            this.textBox_minutes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_minutes.Location = new System.Drawing.Point(217, 79);
            this.textBox_minutes.Name = "textBox_minutes";
            this.textBox_minutes.Size = new System.Drawing.Size(35, 29);
            this.textBox_minutes.TabIndex = 8;
            // 
            // checkBox_notifications
            // 
            this.checkBox_notifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_notifications.AutoSize = true;
            this.checkBox_notifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_notifications.Location = new System.Drawing.Point(66, 236);
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
            this.panel_notifications_on.Location = new System.Drawing.Point(66, 271);
            this.panel_notifications_on.Name = "panel_notifications_on";
            this.panel_notifications_on.Size = new System.Drawing.Size(537, 131);
            this.panel_notifications_on.TabIndex = 10;
            this.panel_notifications_on.Visible = false;
            // 
            // textBox_interval_minutes
            // 
            this.textBox_interval_minutes.Location = new System.Drawing.Point(208, 94);
            this.textBox_interval_minutes.Name = "textBox_interval_minutes";
            this.textBox_interval_minutes.Size = new System.Drawing.Size(100, 29);
            this.textBox_interval_minutes.TabIndex = 5;
            // 
            // textBox_repeat_times
            // 
            this.textBox_repeat_times.Location = new System.Drawing.Point(208, 59);
            this.textBox_repeat_times.Name = "textBox_repeat_times";
            this.textBox_repeat_times.Size = new System.Drawing.Size(100, 29);
            this.textBox_repeat_times.TabIndex = 4;
            // 
            // textBox_notification_minute
            // 
            this.textBox_notification_minute.Location = new System.Drawing.Point(208, 22);
            this.textBox_notification_minute.Name = "textBox_notification_minute";
            this.textBox_notification_minute.Size = new System.Drawing.Size(100, 29);
            this.textBox_notification_minute.TabIndex = 3;
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
            // label_error_time
            // 
            this.label_error_time.AutoSize = true;
            this.label_error_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_error_time.ForeColor = System.Drawing.Color.Red;
            this.label_error_time.Location = new System.Drawing.Point(259, 79);
            this.label_error_time.Name = "label_error_time";
            this.label_error_time.Size = new System.Drawing.Size(199, 16);
            this.label_error_time.TabIndex = 11;
            this.label_error_time.Text = "Неправильно введено время";
            this.label_error_time.Visible = false;
            // 
            // button_add
            // 
            this.button_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_add.Location = new System.Drawing.Point(226, 432);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(137, 32);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(476, 71);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 26);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(667, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_molodec
            // 
            this.label_molodec.AutoSize = true;
            this.label_molodec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_molodec.ForeColor = System.Drawing.Color.Green;
            this.label_molodec.Location = new System.Drawing.Point(217, 413);
            this.label_molodec.Name = "label_molodec";
            this.label_molodec.Size = new System.Drawing.Size(178, 16);
            this.label_molodec.TabIndex = 15;
            this.label_molodec.Text = "Дело добавлено в список!";
            this.label_molodec.Visible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.label_molodec);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_molodec;
    }
}