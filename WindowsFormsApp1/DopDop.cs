using System;
using System.IO;
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
    public partial class DopDop : Form
    {
        public DopDop()
        {
            InitializeComponent();
        }
        // на вход подается логин
        public static void writefiledela()
        {
            int cout = dataGridView1.RowCount - 1;
            string puty = HelloForm.LogNow + ".dat";
            if (cout != 0)//
            {//
                StreamWriter first1 = new StreamWriter(puty, false);
                //ээ тут тип перевод на строчку все ломает в файле
                first1.Write(dataGridView1.Rows[0].Cells[0].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[1].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[2].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[3].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[4].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[5].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[6].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[7].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[8].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[9].Value.ToString() + "#");
                first1.Close();

                if (cout > 0)//
                {// 
                    StreamWriter other = new StreamWriter(puty, true);
                    for (int i = 1; i < cout; i++)
                    {

                        other.Write("\n" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[6].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[7].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[8].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[9].Value.ToString() + "#");

                    }
                    other.Close();
                }//
            }//
           // DateTime a = dataGridView1.Rows[0].Cells[2].ToString();
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
