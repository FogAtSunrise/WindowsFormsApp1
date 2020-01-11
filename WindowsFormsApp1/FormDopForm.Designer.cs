namespace WindowsFormsApp1
{
    partial class FormDopForm
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
            log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            id,
            activ,
            log,
            pas,
            name,
            date});
            dataGridView1.Location = new System.Drawing.Point(2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(786, 445);
            dataGridView1.TabIndex = 0;
             
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // activ
            // 
            activ.HeaderText = "Индекс активности";
            activ.MinimumWidth = 6;
            activ.Name = "activ";
            activ.Width = 125;
            // 
            // log
            // 
            log.HeaderText = "login";
            log.MinimumWidth = 6;
            log.Name = "log";
            log.Width = 125;
             
            // pas
            // 
           pas.HeaderText = "password";
            pas.MinimumWidth = 6;
            pas.Name = "pas";
            pas.Width = 125;
            // 
            // name
            // 
            name.HeaderText = "name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 125;
            // 
            // date
            // 
            date.HeaderText = "date";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.Width = 125;
            // 
            // FormDopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(dataGridView1);
            this.Name = "FormDopForm";
            this.Text = "FormDopForm";
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public static System.Windows.Forms.DataGridView dataGridView1;
        public static System.Windows.Forms.DataGridViewTextBoxColumn id;
        public static System.Windows.Forms.DataGridViewTextBoxColumn activ;
        public static System.Windows.Forms.DataGridViewTextBoxColumn log;
        public static System.Windows.Forms.DataGridViewTextBoxColumn pas;
        public static System.Windows.Forms.DataGridViewTextBoxColumn name;
        public static System.Windows.Forms.DataGridViewTextBoxColumn date;
    }
}