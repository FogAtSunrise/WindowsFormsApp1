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
            int cout = dataGridView1.RowCount - 1;
            if (cout != 0)//
            {//
                StreamWriter first1 = new StreamWriter("data.dat", false);
                //ээ тут тип перевод на строчку все ломает в файле
                first1.Write(dataGridView1.Rows[0].Cells[1].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[2].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[3].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[4].Value.ToString() + "#" + dataGridView1.Rows[0].Cells[5].Value.ToString() + "#");
                first1.Close();
                if (cout > 1)//
                { //
                    StreamWriter other = new StreamWriter("data.dat", true);
                    for (int i = 1; i < cout; i++)
                    {

                        other.Write("\n" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[3].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[4].Value.ToString() + "#" + dataGridView1.Rows[i].Cells[5].Value.ToString() + "#");

                    }
                    other.Close();
                }//
            }//
        }
    }

}