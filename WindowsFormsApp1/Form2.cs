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
        //int[] mas_for_time = new int[1000];
        private NotifyIcon NI = new NotifyIcon();
        private void создатьОтчетToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateDoc y = new CreateDoc();
            y.Show();
            
        }

        
        private void помощьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это главное окно для работы с делами пользователя. Чтобы посмотреть задачи на день, нажмите \"День\". Пользователь может выбирать день," +
                " чтобы посмотреть список запланированных или уже выполненных дел. Так же, пользователь может выбирать при помощи галочек записи, которые необходимо удалить " +
                "(при выделении хотя бы одной задачи, кнопка \"Удалить\" становится доступной). Таким же образом можно отмечать уже выполненные задачи. Чтобы отредактировать задачу, необходимо" +
                "ее выбрать и нажать кнопку \"Редактировать\". За раз редактировать можно только одну задачу!\n" +
                "Чтобы посмотреть список дел, запланированных на неделю, нажмите \"Неделя\". Пользователь самостоятельно выбирает день, от которого отсчитывается неделя. " +
                "В первой таблице будут указаны задачи, запланированные на недельное выполнение. " +
                "Во второй таблице будет представлен список дневных дел за указанную неделю. Так же, как и во вкладке \"День\", кнопки \"Удалить\",\"Редактировать\" и \"Выполнено\" работают аналогично." +
                "\nЧтобы посмотреть список дел, запланированных на месяц, нажмите \"Месяц\". Пользователь самостоятельно выбирает месяц и год. " +
                "В первой таблице будут указаны задачи, запланированные на месячное выполнение. " +
                "Во второй таблице будет представлен список дневных дел за указанный месяц. Так же, как и во вкладке \"День\", кнопки \"Удалить\",\"Редактировать\" и \"Выполнено\" работают аналогично." +
                "\n\nЧтобы добавить новую задачу в любой список, нажмите кнопку \"Добавить задачу\" в верхнем ленточном меню. Чтобы создать отчет по конкретному промежутку времени, нажмите кнопу" +
                "\"Создать отчет\". Для того, чтобы изменить информацию о пользователе, сменить пароль, нажмите кнопку \"Пользователь\". Чтобы сменить пользователя, нажмите кнопку \"Выход из пользователя\"");
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


            //сначала меняем  в тексте дату +6 дней
            DateTime date2 = DateTime.Today.AddDays(6);
            DateTime date1 = dateTimePicker2.Value;
            string tod = date2.ToString();
            String[] today_date = tod.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            textBox_week.Text = today_date[0];
            //dataGridView_week_daystasks
            int week = 0;
            int days = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {
                DateTime date = DateTime.Parse(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString());
                if(DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "2" && date >= date1 && date <= date2)
                {
                    dataGridView_week_weekstasks.Rows.Add();
                    
                    dataGridView_week_weekstasks.Rows[week].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[1].Value; //дата
                    dataGridView_week_weekstasks.Rows[week].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_week_weekstasks.Rows[week].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    week++;
                }
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && date >= date1 && date <= date2)
                {
                    dataGridView_week_daystasks.Rows.Add();
                    dataGridView_week_daystasks.Rows[days].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_week_daystasks.Rows[days].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_week_daystasks.Rows[days].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    days++;
                }
            }
        }

        private void button_MONTH_Click(object sender, EventArgs e)
        {
         //  panel_DAY.Hide();
           panel_dlya_nedeliiii.Hide();
            panel_dlya_mesyaca.Show();

            string today = DateTime.Today.ToString();
            String[] month = today.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            String[] year1 = month[2].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int month_today = Convert.ToInt32(month[1]);
            int year_today = Convert.ToInt32(year1[0]);
            switch (month_today)
            {
                case 1: comboBox_month.SelectedIndex = 0;
                    break;
                case 2: comboBox_month.SelectedIndex = 1;
                    break;
                case 3:
                    comboBox_month.SelectedIndex = 2;
                    break;
                case 4:
                    comboBox_month.SelectedIndex = 3;
                    break;
                case 5:
                    comboBox_month.SelectedIndex = 4;
                    break;
                case 6:
                    comboBox_month.SelectedIndex = 5;
                    break;
                case 7:
                    comboBox_month.SelectedIndex = 6;
                    break;
                case 8:
                    comboBox_month.SelectedIndex = 7;
                    break;
                case 9:
                    comboBox_month.SelectedIndex = 8;
                    break;
                case 10:
                    comboBox_month.SelectedIndex = 9;
                    break;
                case 11:
                    comboBox_month.SelectedIndex = 10;
                    break;
                case 12:
                    comboBox_month.SelectedIndex = 11;
                    break;
            }
            switch (year_today)
            {
                case 2020: comboBox_year.SelectedIndex = 0;
                    break;
                case 2021:
                    comboBox_year.SelectedIndex = 1;
                    break;
                case 2022:
                    comboBox_year.SelectedIndex = 2;
                    break;
                case 2023:
                    comboBox_year.SelectedIndex = 3;
                    break;
                case 2024:
                    comboBox_year.SelectedIndex = 4;
                    break;
                case 2025:
                    comboBox_year.SelectedIndex = 5;
                    break;
                case 2026:
                    comboBox_year.SelectedIndex = 6;
                    break;
            }
            // dont foget about date in week
            int month2 = DateTime.Today.AddMonths(1).Month;
            int month1 = DateTime.Today.Month;
            int year_1 = DateTime.Today.Year;
            int year_2 = DateTime.Today.AddYears(1).Year;



          
            //dataGridView_week_daystasks
            int year_cyc = 0;
            int days = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {
                DateTime date = DateTime.Parse(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString());
                int month_tabl = date.Month;
                int year_tabl = date.Year;
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "3" && month_tabl >= month1 && month_tabl <= month2 && 
                    year_tabl >= year_1 && year_tabl <= year_2)
                {
                    dataGridView_month_month.Rows.Add();
                    dataGridView_month_month.Rows[year_cyc].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_month_month.Rows[year_cyc].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_month_month.Rows[year_cyc].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    year_cyc++;
                }
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && month_tabl >= month1 && month_tabl <= month2 &&
                    year_tabl >= year_1 && year_tabl <= year_2)
                {
                    dataGridView_month_days.Rows.Add();
                    dataGridView_month_days.Rows[days].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_month_days.Rows[days].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_month_days.Rows[days].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    days++;
                }
            } 

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
            timer1.Start();
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
            //DopDop.dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
           // globaltable.Show();
            // сначала ищем сегодняшний день

        //    DopDop.dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
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
                    
                    //dataGridView1.Rows.Add();
                    k++;
                    //dataGridView1.Rows.Add();
                    
                }
                

            }

            

            // dataGridView1.Rows.Add();
            // готово, епта
            // dataGridView1.Sort(dataGridView1.Columns["DatTim"], ListSortDirection.Ascending);
            /// етот самый дата пикер
           
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            int rows = DopDop.dataGridView1.RowCount - 1;
            string today = dateTimePicker1.Value.ToString();
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
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {

                        dataGridView1.Rows[k].DefaultCellStyle.BackColor = Color.LightSeaGreen;

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
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {

                        dataGridView1.Rows[k].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                        
                    }

                    //dataGridView1.Rows.Add();
                    k++;
                    //dataGridView1.Rows.Add();

                }


            }
        }



       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            button_del_task.Enabled = true;
            button_edit_task.Enabled = true;
            button_done_task.Enabled = true;

            //в столбец


            
            //   int rows = dataGridView1.RowCount - 1;
            //   int[] right_row = new int[DopDop.dataGridView1.RowCount];
            //int[] del_row = new int[DopDop.dataGridView1.RowCount];

            /*  for(int i = 0, j = 0; i < rows; i++)
              {
                  if (dataGridView1.Rows[i].Cells[0].Selected) // for check box
                  {
                      right_row[j++] = i;
                  }

              }
              string poisk = "";
              if (right_row >= 0)
              {
                  poisk = dataGridView1.Rows[right_row].Cells[2].Value.ToString();
                  rows = DopDop.dataGridView1.RowCount - 1;

                  for (int i = 0; i < rows; i++)
                  {
                      if (poisk == DopDop.dataGridView1.Rows[i].Cells[3].Value.ToString())
                          if (DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString() == "0")
                              DopDop.dataGridView1.Rows[i].Cells[0].Value = "1";
                          else DopDop.dataGridView1.Rows[i].Cells[0].Value = "0";
                  }


              }
              if (del_row >= 0) // delete str
              {
                  poisk = dataGridView1.Rows[del_row].Cells[2].Value.ToString();
                  rows = DopDop.dataGridView1.RowCount - 1;

                  for (int i = 0; i < rows; i++)
                  {
                      if (poisk == DopDop.dataGridView1.Rows[i].Cells[3].Value.ToString())
                          if (rows == 1) // удаление для одной строчки
                          {
                              DopDop.dataGridView1.Rows.Clear();
                              DopDop.dataGridView1.Refresh();
                          }
                          else
                          {
                              for (int j = del_row; i < rows - 1; i++)
                                  for (int k = 0; k < 7; k++)
                                      DopDop.dataGridView1.Rows[i].Cells[j].Value = DopDop.dataGridView1.Rows[i+1].Cells[j].Value;
                          }
                  }


              }


              rows = DopDop.dataGridView1.RowCount - 1;
              string date_calendar = dateTimePicker1.Value.ToString();
              String[] words_date = date_calendar.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
              int lo = 0;

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
                      dataGridView1.Rows[lo].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                      dataGridView1.Rows[lo].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                      if (DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString() == "1") // индекс активности
                      {
                          dataGridView1.Rows[lo].Cells[0].Value = true; // поставили галочку
                      }
                      //dataGridView1.Rows.Add();
                      lo++;
                      //dataGridView1.Rows.Add();

                  }


              }



              if (edit_row >= 0) // edit str
              {
                  EditDeloForm edit = new EditDeloForm();
                  edit.Show();
              }

      */
        }

        private void button_del_task_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.RowCount - 1;
          //  int[] right_row = new int[DopDop.dataGridView1.RowCount];

            if (rows == 1)
            {
                DopDop.dataGridView1.Rows.Clear();
                DopDop.dataGridView1.Refresh();

                ///
                
            }
            else
            {
                for (int i = 0; i < rows; i++)
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == 1)
                    {
                        int k = 1;
                        string poisk = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        for (int j = 0; j < DopDop.dataGridView1.RowCount - k; j++)
                            if (poisk == DopDop.dataGridView1.Rows[j].Cells[3].Value.ToString())
                            {

                                DopDop.dataGridView1.Rows.RemoveAt(DopDop.dataGridView1.Rows[j].Index);
                                k++;
                            }
                    }
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            string date_calendar = dateTimePicker1.Value.ToString();
            String[] words_date = date_calendar.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int lo = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {

                // ищем по индексу днм: д = 1, н = 2, м = 3, если находим, то выводим данные в таблицу дня
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && words_date[0] == DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[lo].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView1.Rows[lo].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if (DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString() == "1") // индекс активности
                    {
                        dataGridView1.Rows[lo].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    //dataGridView1.Rows.Add();
                    lo++;
                    //dataGridView1.Rows.Add();

                }


            }

            button_del_task.Enabled = false;
            button_edit_task.Enabled = false;
            button_done_task.Enabled = false;

        }

        static public int edit_row = -1;

        private void button_edit_task_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.RowCount - 1;
            int found_over = 0;
            //  int[] right_row = new int[DopDop.dataGridView1.RowCount];         
            for (int i = 0; i < rows; i++)
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == 1)
                {
                    found_over++;
                }

            if (found_over == 1)
            {
                for (int i = 0; i < rows; i++)
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == 1)
                    {
                        
                        string poisk = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        for (int j = 0; j < DopDop.dataGridView1.RowCount - 1; j++)
                            if (poisk == DopDop.dataGridView1.Rows[j].Cells[3].Value.ToString())
                            {

                                edit_row = j;
                                EditDeloForm edit = new EditDeloForm();
                                edit.Show();

                            }
                    }
            }
            else
            {
                MessageBox.Show("Нельзя отредактировать несколько записей за раз. Выберите одну задачу и снова нажмите \"Редактировать\"");
            }

            button_del_task.Enabled = false;
            button_edit_task.Enabled = false;
            button_done_task.Enabled = false;
        }

        private void button_done_task_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.RowCount - 1;
            //  int[] right_row = new int[DopDop.dataGridView1.RowCount];         
                for (int i = 0; i < rows; i++)
                    if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == 1)
                    {
                        
                        string poisk = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        for (int j = 0; j < DopDop.dataGridView1.RowCount - 1; j++)
                            if (poisk == DopDop.dataGridView1.Rows[j].Cells[3].Value.ToString())
                            {

                               // dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                                DopDop.dataGridView1.Rows[j].Cells[0].Value = "1";
                                
                            }
                    }
            
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            string date_calendar = dateTimePicker1.Value.ToString();
            String[] words_date = date_calendar.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int lo = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {

                // ищем по индексу днм: д = 1, н = 2, м = 3, если находим, то выводим данные в таблицу дня
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && words_date[0] == DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[lo].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView1.Rows[lo].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if (DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString() == "1") // индекс активности
                    {
                        dataGridView1.Rows[lo].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    //dataGridView1.Rows.Add();
                    lo++;
                    //dataGridView1.Rows.Add();

                }


            }

            button_del_task.Enabled = false;
            button_edit_task.Enabled = false;
            button_done_task.Enabled = false;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // cначала очистим
            dataGridView_week_weekstasks.Rows.Clear();
            dataGridView_week_weekstasks.Refresh();
            dataGridView_week_daystasks.Rows.Clear();
            dataGridView_week_daystasks.Refresh();

            //сначала меняем  в тексте дату +6 дней
            DateTime date1 = dateTimePicker2.Value;
            DateTime date2 = date1.AddDays(6);
            
            string tod = date2.ToString();
            String[] today_date = tod.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            textBox_week.Text = today_date[0];
            //dataGridView_week_daystasks
            int week = 0;
            int days = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {
                DateTime date = DateTime.Parse(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString());
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "2" && date >= date1 && date <= date2)
                {
                    dataGridView_week_weekstasks.Rows.Add();
                    dataGridView_week_weekstasks.Rows[week].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[1].Value; //время
                    dataGridView_week_weekstasks.Rows[week].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_week_weekstasks.Rows[week].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    week++;
                }
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && date >= date1 && date <= date2)
                {
                    dataGridView_week_daystasks.Rows.Add();
                    dataGridView_week_daystasks.Rows[days].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_week_daystasks.Rows[days].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_week_daystasks.Rows[days].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    days++;
                }
            }
        }

        private void dataGridView_week_weekstasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button_week_del_task.Enabled = true;
            button_week_edit.Enabled = true;
            button_week_done.Enabled = true;
        }

        private void dataGridView_week_daystasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button_week_del_task.Enabled = true;
            button_week_edit.Enabled = true;
            button_week_done.Enabled = true;
        }

        private void button_week_del_task_Click(object sender, EventArgs e)
        {
            int rows = dataGridView_week_weekstasks.RowCount - 1;
            //  int[] right_row = new int[DopDop.dataGridView1.RowCount];

            
                for (int i = 0; i < rows; i++)
                    if (Convert.ToInt32(dataGridView_week_weekstasks.Rows[i].Cells[0].Value) == 1)
                    {
                        int k = 1;
                        string poisk = dataGridView_week_weekstasks.Rows[i].Cells[2].Value.ToString();
                        for (int j = 0; j < DopDop.dataGridView1.RowCount - k; j++)
                            if (poisk == DopDop.dataGridView1.Rows[j].Cells[3].Value.ToString())
                            {

                                DopDop.dataGridView1.Rows.RemoveAt(DopDop.dataGridView1.Rows[j].Index);
                                k++;
                            }
                    }
            int row_days = dataGridView_week_daystasks.RowCount - 1;
            
            for (int i = 0; i < row_days; i++)
                if (Convert.ToInt32(dataGridView_week_daystasks.Rows[i].Cells[0].Value) == 1)
                {
                    int k = 1;
                    string poisk = dataGridView_week_daystasks.Rows[i].Cells[2].Value.ToString();
                    for (int j = 0; j < DopDop.dataGridView1.RowCount - k; j++)
                        if (poisk == DopDop.dataGridView1.Rows[j].Cells[3].Value.ToString())
                        {

                            DopDop.dataGridView1.Rows.RemoveAt(DopDop.dataGridView1.Rows[j].Index);
                            k++;
                        }
                }


            dataGridView_week_weekstasks.Rows.Clear();
            dataGridView_week_weekstasks.Refresh();
            dataGridView_week_daystasks.Rows.Clear();
            dataGridView_week_daystasks.Refresh();

            //сначала меняем  в тексте дату +6 дней
            DateTime date2 = DateTime.Today.AddDays(6);
            DateTime date1 = dateTimePicker2.Value;
            string tod = date2.ToString();
            String[] today_date = tod.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            textBox_week.Text = today_date[0];
            //dataGridView_week_daystasks
            int week = 0;
            int days = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {
                DateTime date = DateTime.Parse(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString());
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "2" && date >= date1 && date <= date2)
                {
                    dataGridView_week_weekstasks.Rows.Add();
                    dataGridView_week_weekstasks.Rows[week].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_week_weekstasks.Rows[week].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_week_weekstasks.Rows[week].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    week++;
                }
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && date >= date1 && date <= date2)
                {
                    dataGridView_week_daystasks.Rows.Add();
                    dataGridView_week_daystasks.Rows[days].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_week_daystasks.Rows[days].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_week_daystasks.Rows[days].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    days++;
                }
            }


            button_week_del_task.Enabled = false;
            button_week_edit.Enabled = false;
            button_week_done.Enabled = false;
        }

        private void button_week_edit_Click(object sender, EventArgs e)
        {
            int rows = dataGridView_week_weekstasks.RowCount - 1;
            int rows_days = dataGridView_week_daystasks.RowCount - 1;
            int found_over = 0;
            //  int[] right_row = new int[DopDop.dataGridView1.RowCount];         
            for (int i = 0; i < rows; i++)
                if (Convert.ToInt32(dataGridView_week_weekstasks.Rows[i].Cells[0].Value) == 1)
                {
                    found_over++;
                }
            for (int i = 0; i< rows_days; i++)
                if (Convert.ToInt32(dataGridView_week_daystasks.Rows[i].Cells[0].Value) == 1)
                {
                    found_over++;
                }

            if (found_over == 1)
            {
                for (int i = 0; i < rows; i++)
                
                    if (Convert.ToInt32(dataGridView_week_weekstasks.Rows[i].Cells[0].Value) == 1)
                    {

                        string poisk = dataGridView_week_weekstasks.Rows[i].Cells[2].Value.ToString();
                        for (int k = 0; k < DopDop.dataGridView1.RowCount - 1; k++)
                            if (poisk == DopDop.dataGridView1.Rows[k].Cells[3].Value.ToString())
                            {

                                edit_row = k;
                                EditDeloForm edit = new EditDeloForm();
                                edit.Show();

                            }
                    }
                for(int j = 0; j < rows_days; j++)
                    if (Convert.ToInt32(dataGridView_week_daystasks.Rows[j].Cells[0].Value) == 1)
                    {

                        string poisk = dataGridView_week_daystasks.Rows[j].Cells[2].Value.ToString();
                        for (int k = 0; k < DopDop.dataGridView1.RowCount - 1; k++)
                            if (poisk == DopDop.dataGridView1.Rows[k].Cells[3].Value.ToString())
                            {

                                edit_row = k;
                                EditDeloForm edit = new EditDeloForm();
                                edit.Show();



                            }
                    }
                
            }
            else
            {
                MessageBox.Show("Нельзя отредактировать несколько записей за раз. Выберите одну задачу и снова нажмите \"Редактировать\"");
            }

            dataGridView_week_weekstasks.Rows.Clear();
            dataGridView_week_weekstasks.Refresh();
            dataGridView_week_daystasks.Rows.Clear();
            dataGridView_week_daystasks.Refresh();

            //сначала меняем  в тексте дату +6 дней
            DateTime date2 = DateTime.Today.AddDays(6);
            DateTime date1 = dateTimePicker2.Value;
            string tod = date2.ToString();
            String[] today_date = tod.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            textBox_week.Text = today_date[0];
            //dataGridView_week_daystasks
            int week = 0;
            int days = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {
                DateTime date = DateTime.Parse(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString());
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "2" && date >= date1 && date <= date2)
                {
                    dataGridView_week_weekstasks.Rows.Add();
                    dataGridView_week_weekstasks.Rows[week].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_week_weekstasks.Rows[week].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_week_weekstasks.Rows[week].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    week++;
                }
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && date >= date1 && date <= date2)
                {
                    dataGridView_week_daystasks.Rows.Add();
                    dataGridView_week_daystasks.Rows[days].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_week_daystasks.Rows[days].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_week_daystasks.Rows[days].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    days++;
                }
            }

            button_week_del_task.Enabled = false;
            button_week_edit.Enabled = false;
            button_week_done.Enabled = false;
        }

        private void button_week_done_Click(object sender, EventArgs e)
        {
            int rows = dataGridView_week_weekstasks.RowCount - 1;
            //  int[] right_row = new int[DopDop.dataGridView1.RowCount];         
            for (int i = 0; i < rows; i++)
                if (Convert.ToInt32(dataGridView_week_weekstasks.Rows[i].Cells[0].Value) == 1)
                {

                    string poisk = dataGridView_week_weekstasks.Rows[i].Cells[2].Value.ToString();
                    for (int j = 0; j < DopDop.dataGridView1.RowCount - 1; j++)
                        if (poisk == DopDop.dataGridView1.Rows[j].Cells[3].Value.ToString())
                        {

                            // dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                            DopDop.dataGridView1.Rows[j].Cells[0].Value = "1";

                        }
                }
            int rows_days = dataGridView_week_daystasks.RowCount - 1;
            for (int i = 0; i < rows_days; i++)
                if (Convert.ToInt32(dataGridView_week_daystasks.Rows[i].Cells[0].Value) == 1)
                {

                    string poisk = dataGridView_week_daystasks.Rows[i].Cells[2].Value.ToString();
                    for (int j = 0; j < DopDop.dataGridView1.RowCount - 1; j++)
                        if (poisk == DopDop.dataGridView1.Rows[j].Cells[3].Value.ToString())
                        {

                            // dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                            DopDop.dataGridView1.Rows[j].Cells[0].Value = "1";

                        }
                }

            dataGridView_week_weekstasks.Rows.Clear();
            dataGridView_week_weekstasks.Refresh();
            dataGridView_week_daystasks.Rows.Clear();
            dataGridView_week_daystasks.Refresh();


            //сначала меняем  в тексте дату +6 дней
            DateTime date2 = DateTime.Today.AddDays(6);
            DateTime date1 = dateTimePicker2.Value;
            string tod = date2.ToString();
            String[] today_date = tod.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            textBox_week.Text = today_date[0];
            //dataGridView_week_daystasks
            int week = 0;
            int days = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {
                DateTime date = DateTime.Parse(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString());
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "2" && date >= date1 && date <= date2)
                {
                    dataGridView_week_weekstasks.Rows.Add();
                    dataGridView_week_weekstasks.Rows[week].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_week_weekstasks.Rows[week].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_week_weekstasks.Rows[week].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    week++;
                }
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && date >= date1 && date <= date2)
                {
                    dataGridView_week_daystasks.Rows.Add();
                    dataGridView_week_daystasks.Rows[days].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_week_daystasks.Rows[days].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_week_daystasks.Rows[days].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    days++;
                }
            }


            button_week_del_task.Enabled = false;
            button_week_edit.Enabled = false;
            button_week_done.Enabled = false;
        }

        private void button_del_month_Click(object sender, EventArgs e)
        {
            int rows = dataGridView_month_month.RowCount - 1;
            //  int[] right_row = new int[DopDop.dataGridView1.RowCount];


            for (int i = 0; i < rows; i++)
                if (Convert.ToInt32(dataGridView_month_month.Rows[i].Cells[0].Value) == 1)
                {
                    int k = 1;
                    string poisk = dataGridView_month_month.Rows[i].Cells[2].Value.ToString();
                    for (int j = 0; j < DopDop.dataGridView1.RowCount - k; j++)
                        if (poisk == DopDop.dataGridView1.Rows[j].Cells[3].Value.ToString())
                        {

                            DopDop.dataGridView1.Rows.RemoveAt(DopDop.dataGridView1.Rows[j].Index);
                            k++;
                        }
                }
            int row_days = dataGridView_month_days.RowCount - 1;

            for (int i = 0; i < row_days; i++)
                if (Convert.ToInt32(dataGridView_month_days.Rows[i].Cells[0].Value) == 1)
                {
                    int k = 1;
                    string poisk = dataGridView_month_days.Rows[i].Cells[2].Value.ToString();
                    for (int j = 0; j < DopDop.dataGridView1.RowCount - k; j++)
                        if (poisk == DopDop.dataGridView1.Rows[j].Cells[3].Value.ToString())
                        {

                            DopDop.dataGridView1.Rows.RemoveAt(DopDop.dataGridView1.Rows[j].Index);
                            k++;
                        }
                }


            dataGridView_month_month.Rows.Clear();
            dataGridView_month_month.Refresh();
            dataGridView_month_days.Rows.Clear();
            dataGridView_month_days.Refresh();

            // обновляем

            int month2;// = DateTime.Today.AddMonths(1).Month;
            int month1 = 0;// = DateTime.Today.Month;
            int year_1 = 1;// = DateTime.Today.Year;
            int year_2;// = DateTime.Today.AddYears(1).Year;

            // for first month

            int choise_month = comboBox_month.SelectedIndex;
            switch (choise_month)
            {
                case 0: month1 = 1;
                    break;
                case 1:
                    month1 = 2;
                    break;
                case 2:
                    month1 = 3;
                    break;
                case 3:
                    month1 = 4;
                    break;
                case 4:
                    month1 = 5;
                    break;
                case 5:
                    month1 = 6;
                    break;
                case 6:
                    month1 = 7;
                    break;
                case 7:
                    month1 = 8;
                    break;
                case 8:
                    month1 = 9;
                    break;
                case 9:
                    month1 = 10;
                    break;
                case 10:
                    month1 = 11;
                    break;
                case 11:
                    month1 = 12;
                    break;
                default: MessageBox.Show("Месяц не выбран!");
                    break;
            }

            if (month1 == 12) month2 = 1;
            else month2 = month1 + 1;

            int choise_year = comboBox_year.SelectedIndex;
            switch (choise_year)
            {
                case 0:
                    year_1 = 2020;
                    break;
                case 1:
                    year_1 = 2021;
                    break;
                case 2:
                    year_1 = 2022;
                    break;
                case 3:
                    year_1 = 2023;
                    break;
                case 4:
                    year_1 = 2024;
                    break;
                case 5:
                    year_1 = 2025;
                    break;
                case 6:
                    year_1 = 2026;
                    break;
                case 7:
                    year_1 = 2027;
                    break;
                
                default:
                    MessageBox.Show("Месяц не выбран!");
                    break;
            }

            
            year_2 = year_1 + 1;




            //dataGridView_week_daystasks
            int year_cyc = 0;
            int days = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {
                DateTime date = DateTime.Parse(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString());
                int month_tabl = date.Month;
                int year_tabl = date.Year;
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "3" && month_tabl >= month1 && month_tabl <= month2 &&
                    year_tabl >= year_1 && year_tabl <= year_2)
                {
                    dataGridView_month_month.Rows.Add();
                    dataGridView_month_month.Rows[year_cyc].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_month_month.Rows[year_cyc].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_month_month.Rows[year_cyc].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    year_cyc++;
                }
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && month_tabl >= month1 && month_tabl <= month2 &&
                    year_tabl >= year_1 && year_tabl <= year_2)
                {
                    dataGridView_month_days.Rows.Add();
                    dataGridView_month_days.Rows[days].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_month_days.Rows[days].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_month_days.Rows[days].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    days++;
                }
            }


            button_del_month.Enabled = false;
            button_edit_month.Enabled = false;
            button_done_month.Enabled = false;
        }

        private void dataGridView_month_month_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button_del_month.Enabled = true;
            button_edit_month.Enabled = true;
            button_done_month.Enabled = true;
        }

        private void dataGridView_month_days_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button_del_month.Enabled = true;
            button_edit_month.Enabled = true;
            button_done_month.Enabled = true;
        }

        private void button_edit_month_Click(object sender, EventArgs e)
        {
            int rows = dataGridView_month_month.RowCount - 1;
            int rows_days = dataGridView_month_days.RowCount - 1;
            int found_over = 0;
            //  int[] right_row = new int[DopDop.dataGridView1.RowCount];         
            for (int i = 0; i < rows; i++)
                if (Convert.ToInt32(dataGridView_month_month.Rows[i].Cells[0].Value) == 1)
                {
                    found_over++;
                }
            for (int i = 0; i < rows_days; i++)
                if (Convert.ToInt32(dataGridView_month_days.Rows[i].Cells[0].Value) == 1)
                {
                    found_over++;
                }

            if (found_over == 1)
            {
                for (int i = 0; i < rows; i++)

                    if (Convert.ToInt32(dataGridView_month_month.Rows[i].Cells[0].Value) == 1)
                    {

                        string poisk = dataGridView_month_month.Rows[i].Cells[2].Value.ToString();
                        for (int k = 0; k < DopDop.dataGridView1.RowCount - 1; k++)
                            if (poisk == DopDop.dataGridView1.Rows[k].Cells[3].Value.ToString())
                            {

                                edit_row = k;
                                EditDeloForm edit = new EditDeloForm();
                                edit.Show();

                            }
                    }
                for (int j = 0; j < rows_days; j++)
                    if (Convert.ToInt32(dataGridView_month_days.Rows[j].Cells[0].Value) == 1)
                    {

                        string poisk = dataGridView_month_days.Rows[j].Cells[2].Value.ToString();
                        for (int k = 0; k < DopDop.dataGridView1.RowCount - 1; k++)
                            if (poisk == DopDop.dataGridView1.Rows[k].Cells[3].Value.ToString())
                            {

                                edit_row = k;
                                EditDeloForm edit = new EditDeloForm();
                                edit.Show();



                            }
                    }

            }
            else
            {
                MessageBox.Show("Нельзя отредактировать несколько записей за раз. Выберите одну задачу и снова нажмите \"Редактировать\"");
            }

        }

        private void button_done_month_Click(object sender, EventArgs e)
        {
            int rows = dataGridView_month_month.RowCount - 1;
            //  int[] right_row = new int[DopDop.dataGridView1.RowCount];         
            for (int i = 0; i < rows; i++)
                if (Convert.ToInt32(dataGridView_month_month.Rows[i].Cells[0].Value) == 1)
                {

                    string poisk = dataGridView_month_month.Rows[i].Cells[2].Value.ToString();
                    for (int j = 0; j < DopDop.dataGridView1.RowCount - 1; j++)
                        if (poisk == DopDop.dataGridView1.Rows[j].Cells[3].Value.ToString())
                        {

                            // dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                            DopDop.dataGridView1.Rows[j].Cells[0].Value = "1";

                        }
                }
            int rows_days = dataGridView_month_days.RowCount - 1;
            for (int i = 0; i < rows_days; i++)
                if (Convert.ToInt32(dataGridView_month_days.Rows[i].Cells[0].Value) == 1)
                {

                    string poisk = dataGridView_month_days.Rows[i].Cells[2].Value.ToString();
                    for (int j = 0; j < DopDop.dataGridView1.RowCount - 1; j++)
                        if (poisk == DopDop.dataGridView1.Rows[j].Cells[3].Value.ToString())
                        {

                            // dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                            DopDop.dataGridView1.Rows[j].Cells[0].Value = "1";

                        }
                }

            dataGridView_month_month.Rows.Clear();
            dataGridView_month_month.Refresh();
            dataGridView_month_days.Rows.Clear();
            dataGridView_month_days.Refresh();

            // обновляем

            int month2;// = DateTime.Today.AddMonths(1).Month;
            int month1 = 0;// = DateTime.Today.Month;
            int year_1 = 1;// = DateTime.Today.Year;
            int year_2;// = DateTime.Today.AddYears(1).Year;

            // for first month

            int choise_month = comboBox_month.SelectedIndex;
            switch (choise_month)
            {
                case 0:
                    month1 = 1;
                    break;
                case 1:
                    month1 = 2;
                    break;
                case 2:
                    month1 = 3;
                    break;
                case 3:
                    month1 = 4;
                    break;
                case 4:
                    month1 = 5;
                    break;
                case 5:
                    month1 = 6;
                    break;
                case 6:
                    month1 = 7;
                    break;
                case 7:
                    month1 = 8;
                    break;
                case 8:
                    month1 = 9;
                    break;
                case 9:
                    month1 = 10;
                    break;
                case 10:
                    month1 = 11;
                    break;
                case 11:
                    month1 = 12;
                    break;
                default:
                    MessageBox.Show("Месяц не выбран!");
                    break;
            }

            if (month1 == 12) month2 = 1;
            else month2 = month1 + 1;

            int choise_year = comboBox_year.SelectedIndex;
            switch (choise_year)
            {
                case 0:
                    year_1 = 2020;
                    break;
                case 1:
                    year_1 = 2021;
                    break;
                case 2:
                    year_1 = 2022;
                    break;
                case 3:
                    year_1 = 2023;
                    break;
                case 4:
                    year_1 = 2024;
                    break;
                case 5:
                    year_1 = 2025;
                    break;
                case 6:
                    year_1 = 2026;
                    break;
                case 7:
                    year_1 = 2027;
                    break;

                default:
                    MessageBox.Show("Месяц не выбран!");
                    break;
            }


            year_2 = year_1 + 1;




            //dataGridView_week_daystasks
            int year_cyc = 0;
            int days = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {
                DateTime date = DateTime.Parse(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString());
                int month_tabl = date.Month;
                int year_tabl = date.Year;
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "3" && month_tabl >= month1 && month_tabl <= month2 &&
                    year_tabl >= year_1 && year_tabl <= year_2)
                {
                    dataGridView_month_month.Rows.Add();
                    dataGridView_month_month.Rows[year_cyc].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_month_month.Rows[year_cyc].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_month_month.Rows[year_cyc].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    year_cyc++;
                }
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && month_tabl >= month1 && month_tabl <= month2 &&
                    year_tabl >= year_1 && year_tabl <= year_2)
                {
                    dataGridView_month_days.Rows.Add();
                    dataGridView_month_days.Rows[days].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_month_days.Rows[days].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_month_days.Rows[days].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    days++;
                }
            }


            button_del_month.Enabled = false;
            button_edit_month.Enabled = false;
            button_done_month.Enabled = false;
        }

        private void comboBox_month_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_month_month.Rows.Clear();
            dataGridView_month_month.Refresh();
            dataGridView_month_days.Rows.Clear();
            dataGridView_month_days.Refresh();

            // обновляем

            int month2;// = DateTime.Today.AddMonths(1).Month;
            int month1 = 0;// = DateTime.Today.Month;
            int year_1 = 1;// = DateTime.Today.Year;
            int year_2;// = DateTime.Today.AddYears(1).Year;

            // for first month

            int choise_month = comboBox_month.SelectedIndex;
            switch (choise_month)
            {
                case 0:
                    month1 = 1;
                    break;
                case 1:
                    month1 = 2;
                    break;
                case 2:
                    month1 = 3;
                    break;
                case 3:
                    month1 = 4;
                    break;
                case 4:
                    month1 = 5;
                    break;
                case 5:
                    month1 = 6;
                    break;
                case 6:
                    month1 = 7;
                    break;
                case 7:
                    month1 = 8;
                    break;
                case 8:
                    month1 = 9;
                    break;
                case 9:
                    month1 = 10;
                    break;
                case 10:
                    month1 = 11;
                    break;
                case 11:
                    month1 = 12;
                    break;
                default:
                    MessageBox.Show("Месяц не выбран!");
                    break;
            }

            if (month1 == 12) month2 = 1;
            else month2 = month1 + 1;

            int choise_year = comboBox_year.SelectedIndex;
            switch (choise_year)
            {
                case 0:
                    year_1 = 2020;
                    break;
                case 1:
                    year_1 = 2021;
                    break;
                case 2:
                    year_1 = 2022;
                    break;
                case 3:
                    year_1 = 2023;
                    break;
                case 4:
                    year_1 = 2024;
                    break;
                case 5:
                    year_1 = 2025;
                    break;
                case 6:
                    year_1 = 2026;
                    break;
                case 7:
                    year_1 = 2027;
                    break;

                default:
                    MessageBox.Show("Месяц не выбран!");
                    break;
            }


            year_2 = year_1 + 1;




            //dataGridView_week_daystasks
            int year_cyc = 0;
            int days = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {
                DateTime date = DateTime.Parse(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString());
                int month_tabl = date.Month;
                int year_tabl = date.Year;
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "3" && month_tabl >= month1 && month_tabl <= month2 &&
                    year_tabl >= year_1 && year_tabl <= year_2)
                {
                    dataGridView_month_month.Rows.Add();
                    dataGridView_month_month.Rows[year_cyc].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_month_month.Rows[year_cyc].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_month_month.Rows[year_cyc].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    year_cyc++;
                }
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && month_tabl >= month1 && month_tabl <= month2 &&
                    year_tabl >= year_1 && year_tabl <= year_2)
                {
                    dataGridView_month_days.Rows.Add();
                    dataGridView_month_days.Rows[days].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_month_days.Rows[days].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_month_days.Rows[days].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    days++;
                }
            }
        }

        private void comboBox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_month_month.Rows.Clear();
            dataGridView_month_month.Refresh();
            dataGridView_month_days.Rows.Clear();
            dataGridView_month_days.Refresh();

            // обновляем

            int month2;// = DateTime.Today.AddMonths(1).Month;
            int month1 = 0;// = DateTime.Today.Month;
            int year_1 = 1;// = DateTime.Today.Year;
            int year_2;// = DateTime.Today.AddYears(1).Year;

            // for first month

            int choise_month = comboBox_month.SelectedIndex;
            switch (choise_month)
            {
                case 0:
                    month1 = 1;
                    break;
                case 1:
                    month1 = 2;
                    break;
                case 2:
                    month1 = 3;
                    break;
                case 3:
                    month1 = 4;
                    break;
                case 4:
                    month1 = 5;
                    break;
                case 5:
                    month1 = 6;
                    break;
                case 6:
                    month1 = 7;
                    break;
                case 7:
                    month1 = 8;
                    break;
                case 8:
                    month1 = 9;
                    break;
                case 9:
                    month1 = 10;
                    break;
                case 10:
                    month1 = 11;
                    break;
                case 11:
                    month1 = 12;
                    break;
                default:
                    MessageBox.Show("Месяц не выбран!");
                    break;
            }

            if (month1 == 12) month2 = 1;
            else month2 = month1 + 1;

            int choise_year = comboBox_year.SelectedIndex;
            switch (choise_year)
            {
                case 0:
                    year_1 = 2020;
                    break;
                case 1:
                    year_1 = 2021;
                    break;
                case 2:
                    year_1 = 2022;
                    break;
                case 3:
                    year_1 = 2023;
                    break;
                case 4:
                    year_1 = 2024;
                    break;
                case 5:
                    year_1 = 2025;
                    break;
                case 6:
                    year_1 = 2026;
                    break;
                case 7:
                    year_1 = 2027;
                    break;

                default:
                    MessageBox.Show("Месяц не выбран!");
                    break;
            }


            year_2 = year_1 + 1;




            //dataGridView_week_daystasks
            int year_cyc = 0;
            int days = 0;
            for (int i = 0; i < DopDop.dataGridView1.RowCount - 1; i++)
            {
                DateTime date = DateTime.Parse(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString());
                int month_tabl = date.Month;
                int year_tabl = date.Year;
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "3" && month_tabl >= month1 && month_tabl <= month2 &&
                    year_tabl >= year_1 && year_tabl <= year_2)
                {
                    dataGridView_month_month.Rows.Add();
                    dataGridView_month_month.Rows[year_cyc].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_month_month.Rows[year_cyc].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_month_month.Rows[year_cyc].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    year_cyc++;
                }
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && month_tabl >= month1 && month_tabl <= month2 &&
                    year_tabl >= year_1 && year_tabl <= year_2)
                {
                    dataGridView_month_days.Rows.Add();
                    dataGridView_month_days.Rows[days].Cells[1].Value = DopDop.dataGridView1.Rows[i].Cells[2].Value; //время
                    dataGridView_month_days.Rows[days].Cells[2].Value = DopDop.dataGridView1.Rows[i].Cells[3].Value; //заголовок
                    if ("1" == DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString())
                    {
                        dataGridView_month_days.Rows[days].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                    }
                    days++;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ///просматриваем таблицу
            ///ищем день сегодняшний, если да, то сравниваем время
            ///если все совпало с нынешним временм, то выводим уведомление и все классно
            ///
            DateTime date_now = DateTime.Now.Date;
            int time_hours_now = DateTime.Now.Hour;
            int time_minutes_now = DateTime.Now.Minute;
            
            int rows = DopDop.dataGridView1.RowCount - 1;
            for(int i = 0; i < rows; i++)
            {
                if (DopDop.dataGridView1.Rows[i].Cells[6].Value.ToString() == "1" && DopDop.dataGridView1.Rows[i].Cells[5].Value.ToString() == "1")
                {
                    DateTime date_tabl = DateTime.Parse(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString());
                    if (date_tabl == date_now)
                    {
                        String[] time_tabl = DopDop.dataGridView1.Rows[i].Cells[2].Value.ToString().Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                        int time_hours_tabl = Convert.ToInt32(time_tabl[0]);
                        int time_minutes_tabl = Convert.ToInt32(time_tabl[1]);
                        if(time_hours_now == time_hours_tabl && time_minutes_now == time_minutes_tabl)
                        {
                            NI.BalloonTipText = DopDop.dataGridView1.Rows[i].Cells[4].Value.ToString();
                            NI.BalloonTipTitle = DopDop.dataGridView1.Rows[i].Cells[3].Value.ToString();
                            NI.BalloonTipIcon = ToolTipIcon.Info;
                            NI.Icon = this.Icon;
                            NI.Visible = true;
                            NI.ShowBalloonTip(1000);
                         //   timer1.Stop(); // в обяз, потому что в моем алгоритме эта сука спамится как ненормальная
                        }
                    }
                }
            }
        }
    }
        

       
}

