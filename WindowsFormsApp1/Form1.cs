using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

	

namespace WindowsFormsApp1
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

       

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Описание");
        }

        private void button_vhod_Click(object sender, EventArgs e)
        {
            Form2 y = new Form2();
            y.Show();
            this.Hide();
        }

        private void button_help_reg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Описание");
        }

        private void button_vhod_reg_Click(object sender, EventArgs e)
        {

        }
    }
}

