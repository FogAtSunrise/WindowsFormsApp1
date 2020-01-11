using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormDopForm : Form
    {
        public FormDopForm()
        {
            InitializeComponent();
        }
        public static void writefile()
        {
            StreamWriter first1 = new StreamWriter("data.dat", false);
            first1.Write("0#" + dataGridView1.Rows[0].Cells[2].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[3].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[4].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[5].Value.ToString() + "#");
            first1.Close();
            int cout = dataGridView1.RowCount - 1;
            //using (
            StreamWriter other = new StreamWriter("data.dat", true);
                for (int i = 1; i < cout; i++)
                {
               
                other.Write("\n0#" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "#");

                }
            other.Close();


        }
    }
}
