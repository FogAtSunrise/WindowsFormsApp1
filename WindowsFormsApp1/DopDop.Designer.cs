namespace WindowsFormsApp1
{
    partial class DopDop
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            activ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            id,
            activ,
            time,
            log,
            pas,
            name,
            date});
            dataGridView1.Location = new System.Drawing.Point(1, -6);
            dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(805, 362);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            id.HeaderText = "индекс выполнения";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // activ
            // 
            activ.HeaderText = "дата";
            activ.MinimumWidth = 6;
            activ.Name = "activ";
            activ.Width = 125;
            // 
            // time
            // 
            time.HeaderText = "время";
            time.Name = "time";
            // 
            // log
            // 
            log.HeaderText = "Заголовок";
            log.MinimumWidth = 6;
            log.Name = "log";
            log.Width = 125;
            // 
            // pas
            // 
            pas.HeaderText = "Описание";
            pas.MinimumWidth = 6;
            pas.Name = "pas";
            pas.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "информация об оповещении";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // date
            // 
            date.HeaderText = "dnm";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // DopDop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 366);
            this.Controls.Add(dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DopDop";
            this.Text = "DopDop";
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public static System.Windows.Forms.DataGridViewTextBoxColumn id;
        public static System.Windows.Forms.DataGridViewTextBoxColumn activ;
        public static System.Windows.Forms.DataGridViewTextBoxColumn time;
        public static System.Windows.Forms.DataGridViewTextBoxColumn log;
        public static System.Windows.Forms.DataGridViewTextBoxColumn pas;
        public static System.Windows.Forms.DataGridViewTextBoxColumn name;
        public static System.Windows.Forms.DataGridViewTextBoxColumn date;
        public static System.Windows.Forms.DataGridView dataGridView1;
    }
}