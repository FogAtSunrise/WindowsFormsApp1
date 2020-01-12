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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void создатьОтчетToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateDoc y = new CreateDoc();
            y.Show();
            
        }

        
        private void помощьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Описание");
        }

        private void добавитьЗадачуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddForm z = new AddForm();
            z.Show();
        }

       

        //
        //ПЕРЕКЛЮЧЕННИЕ МЕЖДУ ПАНЕЛЯМИ
        //
        private void button_DAY_Click(object sender, EventArgs e)
        {
            
              //  panel_DAY.Show();
                panel_dlya_nedeliiii.Hide();
                panel_dlya_mesyaca.Hide();
        }

        private void button_WEEK_Click(object sender, EventArgs e)
        {
            //  panel_DAY.Hide();
           /* if (!panel_dlya_nedeliiii.Visible)
                panel_dlya_nedeliiii.Visible = true;*/
            panel_dlya_nedeliiii.Show();
            panel_dlya_mesyaca.Hide();
        }

        private void button_MONTH_Click(object sender, EventArgs e)
        {
         //  panel_DAY.Hide();
           panel_dlya_nedeliiii.Hide();
            panel_dlya_mesyaca.Show();
        }


        //
        //ЗАКРЫЛИ ФОРМУ, НЕ ВЫХОДЯ ИЗ УЧЕТНОЙ ЗАПИСИ, НАДО ФЛАЖОК СДЕЛАТЬ, ЧТО ПРИ СЛЕДУЮЩЕМ ВХОДЕ ОТКРЫЛАСЬ ЭТА УЧЕТНАЯ ЗАПИСЬ
        //
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDopForm.writefile();
            Application.Exit();
        }

        //
        //Переход в форму пользователя
        //
        private void button_user_Click(object sender, EventArgs e)
        {
            
            UserForm y = new UserForm();
            y.Show();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            HelloForm frm = (HelloForm)this.Owner;
            int count_rows = FormDopForm.dataGridView1.RowCount - 1;
            
            for (int i = 0; i < count_rows; i++) 
            {
                if (FormDopForm.dataGridView1.Rows[i].Cells[1].Value.ToString() == "1") FormDopForm.dataGridView1.Rows[i].Cells[1].Value = "0";
            }

            frm.Show();
            this.Hide();
            
            
        }


       
    }
        

       
    }

