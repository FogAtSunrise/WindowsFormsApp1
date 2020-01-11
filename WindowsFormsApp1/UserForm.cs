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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            FormDopForm f = new FormDopForm();
            int right_row = 0;
            string dat, nams;
            int count_rows = f.dataGridView1.RowCount - 1;
            for (int i = 0; i < count_rows; i++)
            {
                string dop = f.dataGridView1.Rows[i].Cells[2].Value.ToString();
                if (dop == HelloForm.LogNow)
                { right_row = i;
                    }
            }
            //заибало уже все нахер в жопу эту хуйню
          //  nams = f.dataGridView1.Rows[right_row].Cells[4].Value.ToString();
          //  dat = f.dataGridView1.Rows[right_row].Cells[5].Value.ToString();
           // textBoxName.Text = nams;
            textBoxLog.Text = HelloForm.LogNow;
          //  textBoxDate.Text = dat;
            
        }

    }
}
