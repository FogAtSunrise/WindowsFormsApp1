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
            DopDop.writefiledela();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //Заполнение таблицы дня
            // DopDop.Show();

            DopDop globaltable = new DopDop();
            
            // зашел пользователь и для начала заполняем глобальную таблицу, а затем только таблицу дня
            string str;
            int rows = -1;
            string puty = HelloForm.LogNow + ".dat";
            try
            {
                StreamReader fptr = new StreamReader(puty);

                int i = 0;
                while (!fptr.EndOfStream)
                {
                    str = fptr.ReadLine();
                    DopDop.dataGridView1.Rows.Add();
                   // FormDopForm.dataGridView1.Rows[i].Cells[0].Value = (i + 1);//пронумеровать (id)
                    String[] words = str.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < 7; j++)
                    {
                        DopDop.dataGridView1.Rows[i].Cells[j].Value = words[j];
                    }
                    i++;
                    rows = i;
                }

                fptr.Close();
            }
            catch (Exception E)
            { MessageBox.Show("Ошибка данных приложения в глобальной таблице"); }

            globaltable.Show();
            // сначала ищем сегодняшний день


            string today = DateTime.Today.ToString();
            String[] words_date = today.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int k = 0;
            // Теперь составляем таблицу дня
            for (int i = 0; i < rows; i++)
            {
                
                // ищем по индексу днм: д = 1, н = 2, м = 3, если находим, то выводим данные в таблицу дня
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && words_date[0] == DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[k].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView1.Rows[k].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if (DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString() == "1") // индекс активности
                    {
                        dataGridView1.Rows[k].Cells[0].Value = true; // поставили галочку
                    }
                    //dataGridView1.Rows.Add();
                    k++;
                    //dataGridView1.Rows.Add();
                    
                }
                

            }

           // dataGridView1.Rows.Add();
            // готово, епта


        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            int rows = DopDop.dataGridView1.RowCount - 1;
            string today = DateTime.Today.ToString();
            String[] words_date = today.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int k = 0;
            // cначала очистим
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            // Теперь составляем таблицу дня
            for (int i = 0; i < rows; i++)
            {

                // ищем по индексу днм: д = 1, н = 2, м = 3, если находим, то выводим данные в таблицу дня
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && words_date[0] == DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[k].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView1.Rows[k].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if (DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString() == "1") // индекс активности
                    {
                        dataGridView1.Rows[k].Cells[0].Value = true; // поставили галочку
                    }
                    //dataGridView1.Rows.Add();
                    k++;
                    //dataGridView1.Rows.Add();

                }


            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int rows = DopDop.dataGridView1.RowCount - 1;
            string date_calendar = dateTimePicker1.Value.ToString();
            String[] words_date = date_calendar.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int k = 0;

            // cначала очистим
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            // Теперь составляем таблицу дня
            for (int i = 0; i < rows; i++)
            {

                // ищем по индексу днм: д = 1, н = 2, м = 3, если находим, то выводим данные в таблицу дня
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && words_date[0] == DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[k].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView1.Rows[k].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if (DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString() == "1") // индекс активности
                    {
                        dataGridView1.Rows[k].Cells[0].Value = true; // поставили галочку
                    }
                    //dataGridView1.Rows.Add();
                    k++;
                    //dataGridView1.Rows.Add();

                }


            }
        }
    }
        

       
    }

