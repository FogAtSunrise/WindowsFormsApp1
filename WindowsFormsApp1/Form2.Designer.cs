namespace WindowsFormsApp1
{
    partial class Form2
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
            this.panel_DAY = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_date = new System.Windows.Forms.Label();
            this.panel_gde_budut_zapisi = new System.Windows.Forms.Panel();
            this.panel_menu_dlya_paneli_day = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button_OFF_opoveschalku = new System.Windows.Forms.Button();
            this.button_ON_opoveschalku = new System.Windows.Forms.Button();
            this.button_user = new System.Windows.Forms.Button();
            this.main_menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.создатьОтчетToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button_DAY = new System.Windows.Forms.Button();
            this.button_WEEK = new System.Windows.Forms.Button();
            this.button_MONTH = new System.Windows.Forms.Button();
            this.button1_user = new System.Windows.Forms.Button();
            this.panel_DAY.SuspendLayout();
            this.panel_menu_dlya_paneli_day.SuspendLayout();
            this.main_menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_DAY
            // 
            this.panel_DAY.Controls.Add(this.dateTimePicker1);
            this.panel_DAY.Controls.Add(this.label_date);
            this.panel_DAY.Controls.Add(this.panel_gde_budut_zapisi);
            this.panel_DAY.Controls.Add(this.panel_menu_dlya_paneli_day);
            this.panel_DAY.Location = new System.Drawing.Point(0, 67);
            this.panel_DAY.Name = "panel_DAY";
            this.panel_DAY.Size = new System.Drawing.Size(937, 458);
            this.panel_DAY.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(210, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 34);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_date.Location = new System.Drawing.Point(108, 10);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(67, 29);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "Дата";
            // 
            // panel_gde_budut_zapisi
            // 
            this.panel_gde_budut_zapisi.Location = new System.Drawing.Point(4, 51);
            this.panel_gde_budut_zapisi.Name = "panel_gde_budut_zapisi";
            this.panel_gde_budut_zapisi.Size = new System.Drawing.Size(660, 404);
            this.panel_gde_budut_zapisi.TabIndex = 1;
           
            // panel_menu_dlya_paneli_day
            // 
            this.panel_menu_dlya_paneli_day.Controls.Add(this.button3);
            this.panel_menu_dlya_paneli_day.Controls.Add(this.button_OFF_opoveschalku);
            this.panel_menu_dlya_paneli_day.Controls.Add(this.button_ON_opoveschalku);
            this.panel_menu_dlya_paneli_day.Location = new System.Drawing.Point(664, 0);
            this.panel_menu_dlya_paneli_day.Name = "panel_menu_dlya_paneli_day";
            this.panel_menu_dlya_paneli_day.Size = new System.Drawing.Size(272, 458);
            this.panel_menu_dlya_paneli_day.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(0, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 56);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить все";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button_OFF_opoveschalku
            // 
            this.button_OFF_opoveschalku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_OFF_opoveschalku.Location = new System.Drawing.Point(0, 51);
            this.button_OFF_opoveschalku.Name = "button_OFF_opoveschalku";
            this.button_OFF_opoveschalku.Size = new System.Drawing.Size(272, 56);
            this.button_OFF_opoveschalku.TabIndex = 1;
            this.button_OFF_opoveschalku.Text = "Выключить все оповещения";
            this.button_OFF_opoveschalku.UseVisualStyleBackColor = true;
            // 
            // button_ON_opoveschalku
            // 
            this.button_ON_opoveschalku.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ON_opoveschalku.Location = new System.Drawing.Point(0, 0);
            this.button_ON_opoveschalku.Name = "button_ON_opoveschalku";
            this.button_ON_opoveschalku.Size = new System.Drawing.Size(272, 56);
            this.button_ON_opoveschalku.TabIndex = 0;
            this.button_ON_opoveschalku.Text = "Включить все оповещения";
            this.button_ON_opoveschalku.UseVisualStyleBackColor = true;
            // 
            // button_user
            // 
            this.button_user.Location = new System.Drawing.Point(945, 4);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(120, 24);
            this.button_user.TabIndex = 1;
            this.button_user.Text = "Пользователь";
            this.button_user.UseVisualStyleBackColor = true;
            // 
            // main_menuStrip1
            // 
            this.main_menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.main_menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьОтчетToolStripMenuItem1,
            this.настройкиToolStripMenuItem1,
            this.помощьToolStripMenuItem1});
            this.main_menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.main_menuStrip1.Name = "main_menuStrip1";
            this.main_menuStrip1.Size = new System.Drawing.Size(937, 28);
            this.main_menuStrip1.TabIndex = 2;
            this.main_menuStrip1.Text = "menuStrip1";
            // 
            // создатьОтчетToolStripMenuItem1
            // 
            this.создатьОтчетToolStripMenuItem1.Name = "создатьОтчетToolStripMenuItem1";
            this.создатьОтчетToolStripMenuItem1.Size = new System.Drawing.Size(119, 24);
            this.создатьОтчетToolStripMenuItem1.Text = "Создать отчет";
            // 
            // настройкиToolStripMenuItem1
            // 
            this.настройкиToolStripMenuItem1.Name = "настройкиToolStripMenuItem1";
            this.настройкиToolStripMenuItem1.Size = new System.Drawing.Size(98, 24);
            this.настройкиToolStripMenuItem1.Text = "Настройки";
            // 
            // помощьToolStripMenuItem1
            // 
            this.помощьToolStripMenuItem1.Name = "помощьToolStripMenuItem1";
            this.помощьToolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem1.Text = "Помощь";
            // 
            // button_DAY
            // 
            this.button_DAY.Location = new System.Drawing.Point(0, 31);
            this.button_DAY.Name = "button_DAY";
            this.button_DAY.Size = new System.Drawing.Size(306, 36);
            this.button_DAY.TabIndex = 3;
            this.button_DAY.Text = "ДЕНЬ";
            this.button_DAY.UseVisualStyleBackColor = true;
            // 
            // button_WEEK
            // 
            this.button_WEEK.Location = new System.Drawing.Point(304, 31);
            this.button_WEEK.Name = "button_WEEK";
            this.button_WEEK.Size = new System.Drawing.Size(339, 36);
            this.button_WEEK.TabIndex = 4;
            this.button_WEEK.Text = "НЕДЕЛЯ";
            this.button_WEEK.UseVisualStyleBackColor = true;
            // 
            // button_MONTH
            // 
            this.button_MONTH.Location = new System.Drawing.Point(639, 31);
            this.button_MONTH.Name = "button_MONTH";
            this.button_MONTH.Size = new System.Drawing.Size(298, 36);
            this.button_MONTH.TabIndex = 5;
            this.button_MONTH.Text = "МЕСЯЦ";
            this.button_MONTH.UseVisualStyleBackColor = true;
            // 
            // button1_user
            // 
            this.button1_user.Location = new System.Drawing.Point(811, 0);
            this.button1_user.Name = "button1_user";
            this.button1_user.Size = new System.Drawing.Size(114, 28);
            this.button1_user.TabIndex = 6;
            this.button1_user.Text = "Пользователь";
            this.button1_user.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 519);
            this.Controls.Add(this.button1_user);
            this.Controls.Add(this.button_MONTH);
            this.Controls.Add(this.button_WEEK);
            this.Controls.Add(this.button_DAY);
            this.Controls.Add(this.button_user);
            this.Controls.Add(this.main_menuStrip1);
            this.Controls.Add(this.panel_DAY);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel_DAY.ResumeLayout(false);
            this.panel_DAY.PerformLayout();
            this.panel_menu_dlya_paneli_day.ResumeLayout(false);
            this.main_menuStrip1.ResumeLayout(false);
            this.main_menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_DAY;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Panel panel_gde_budut_zapisi;
        private System.Windows.Forms.Panel panel_menu_dlya_paneli_day;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_OFF_opoveschalku;
        private System.Windows.Forms.Button button_ON_opoveschalku;
        private System.Windows.Forms.Button button_user;
        private System.Windows.Forms.MenuStrip main_menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьОтчетToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem1;
        private System.Windows.Forms.Button button_DAY;
        private System.Windows.Forms.Button button_WEEK;
        private System.Windows.Forms.Button button_MONTH;
        private System.Windows.Forms.Button button1_user;
    }
}