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
           // HelloForm j = new HelloForm();
           // FormDopForm f = new FormDopForm();
           // int right_row = 0;
            //string dat, nams;
         /*   int count_rows = FormDopForm.dataGridView1.RowCount-1;
            for (int i = 0; i < count_rows; i++)
            {
                string dop = FormDopForm.dataGridView1.Rows[i].Cells[2].Value.ToString();
               
                if (dop == HelloForm.LogNow)
                { right_row = i;
                    break;
                    }
            }*/
            
            textBoxName.Text = FormDopForm.dataGridView1.Rows[HelloForm.strnum].Cells[4].Value.ToString();
            textBoxLog.Text = HelloForm.LogNow;
            textBoxDate.Text = FormDopForm.dataGridView1.Rows[HelloForm.strnum].Cells[5].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Hide();
            label6.Hide();
            label8.Hide();
            string name = textBoxName.Text;
            bool noEmpty = true;
            if (String.IsNullOrWhiteSpace(name) || name == "") //на пустоту и пробелы 
            {
                label4.Show();
                noEmpty = false;
            }
            else
           if (name.Length < 4 || name.Length > 20)//на дилнну имени
            {
                label6.Show();
                noEmpty = false;
            }
            else
               if (name.Contains("#") || name.Contains("%") || name.Contains("$"))
            {
                label8.Show();
                noEmpty = false;
            }
            if (noEmpty == true)
            {
                FormDopForm.dataGridView1.Rows[HelloForm.strnum].Cells[4].Value = textBoxName.Text;

            }
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            FormDopForm.writefile();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            label5.Hide();
            label7.Hide();
            label9.Hide();
            string name = textBoxLog.Text;
            bool noEmpty = true;
            if (String.IsNullOrWhiteSpace(name) || name == "") //на пустоту и пробелы 
            {
                label5.Show();
                noEmpty = false;
            }
            else
           if (name.Length < 4 || name.Length > 20)//на дилнну имени
            {
                label7.Show();
                noEmpty = false;
            }
            else
               if (name.Contains("#") || name.Contains("%") || name.Contains("$"))
            {
                label9.Show();
                noEmpty = false;
            }
            if (noEmpty == true)
            {
                FormDopForm.dataGridView1.Rows[HelloForm.strnum].Cells[2].Value = textBoxLog.Text;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label_error_old_pass.Hide();
            label_error_new_pass.Hide();

            
            string dop = textBox_old_pass.Text;
            int count_rows = FormDopForm.dataGridView1.RowCount - 1;
            int row = 0;
            bool found_pass = false;
            for(int i = 0; i< count_rows; i++)
            {
                if (FormDopForm.dataGridView1.Rows[i].Cells[1].Value.ToString() == "1" && dop == FormDopForm.dataGridView1.Rows[i].Cells[3].Value.ToString())
                {
                    found_pass = true; row = i;
                }
                
            }

            if (!found_pass)
            {
                label_error_old_pass.Show();
            }
            else
            {
                string dop1 = textBox_new_pass.Text;
                string dop2 = textBox_new_pass_con.Text;
                if (dop1 == dop2) // если совпадают, то добавляем, инче показываем лейбл нового реп-исполнителя в наказание
                {
                    FormDopForm.dataGridView1.Rows[row].Cells[3].Value = dop1;
                    label_pass_change.Show();
                }
                else label_error_new_pass.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int row = 0;
            int count_row = FormDopForm.dataGridView1.RowCount - 1;
           // bool found = false;
            for (int i = 0; i < count_row; i++)
            {
                if (FormDopForm.dataGridView1.Rows[i].Cells[1].Value.ToString() == "1")
                {
                   // found = true;
                    row = i;
                }
            }
            FormDopForm.dataGridView1.Rows.RemoveAt(row);


            /* if (count_row > 1)
             {
                 for (int i = row; i < count_row - 1; i++)
                 {
                     for (int j = 0; j < 6; j++)
                         FormDopForm.dataGridView1.Rows[i].Cells[j].Value = FormDopForm.dataGridView1.Rows[i + 1].Cells[j].Value;
                 }
             }
             else if (count_row == 1) // если запись одна
             {
                 for (int j = 0; j < 6; j++)
                     FormDopForm.dataGridView1.Rows[0].Cells[j].Value = "";
             }
             */
            // перезаписываем файл и открываем форму входа

            FormDopForm.writefile();
            this.Hide();

            

            Form2.ActiveForm.Hide();
            FormDopForm.ActiveForm.Hide();
            
            HelloForm frm = new HelloForm();
            frm.Show();



        }
    }
}
