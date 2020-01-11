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
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        FormDopForm f = new FormDopForm();

        private void button_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Описание");
        }

        private void button_vhod_Click(object sender, EventArgs e)
        {
            //скрыть ошибки, если вдруг открыты
            label3.Hide();
            label2.Hide();
            label4.Hide();
            label5.Hide();

            string ish = "ira";
            string login = textBox_loginusing.Text;
            string pass = textBox_password.Text;//введенный пароль
            if (login == "") // если строчка пустая
            {
                label4.Show();
                if (pass == "")
                    label5.Show();
                else label3.Show();
            }
            else // иначе производим поиск
            {

                bool found_log = false;
                int count_rows = f.dataGridView1.RowCount - 1;
                int right_row = 0;

                for(int i= 0; i< count_rows; i++)
                {
                    string dop = f.dataGridView1.Rows[i].Cells[2].Value.ToString();
                    if (dop == login) { found_log = true; right_row = i; }
                }

                //ПОИСК ЛОГИНА В ТАБЛИЦЕ IF "НЕ НАЙДЕН", ТО LABEL2, ELSE:
                if (found_log)//это типо если логин найден
                {
                    // string ishod = "hello";//СЧИТЫВАЕМ ПАРОЛЬ ДЛЯ НАЙДЕННОГО ЛОГИНА

                    if (pass == "") // если ввесли пустую строчку для пароля
                        label5.Show();
                    else
                    if (pass == f.dataGridView1.Rows[right_row].Cells[3].Value.ToString())//пароль верный
                    {
                        textBox_password.Clear();
                        textBox_loginusing.Clear();
                        Form2 y = new Form2();
                        y.Show(this);
                        this.Hide();

                    }
                    else label3.Show();

                }
                else
                {
                    label2.Show();
                    if (pass == "")
                        label5.Show();
                    else label3.Show();
                }
            }
        }

        private void button_help_reg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Описание");
        }

      

        private void HelloForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //перехлд к панели регистрации с панели входа
        private void button_reg_Click(object sender, EventArgs e)
        {
            panel_vhod.Hide();
            panel_registr.Show();
            //очистка полей при переходе
            textBox_password.Clear();
            textBox_loginusing.Clear();
            //скрываем все ошибки
            label3.Hide();
            label2.Hide();
            label4.Hide();
            label5.Hide();

        }
        private void button_vhod_reg_Click(object sender, EventArgs e)
        {
            panel_vhod.Show();
            panel_registr.Hide();
        }

        //Запуск таймера для панели приветствия запуске программы... надо длобавить проверку наличия учетных записе
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Hide();
            panel_vhod.Show(); //ПРОВЕРКА ФЛАГА, В ЗАВИСИМОСТИ ОТ НЕГО ОТПРАВЛЯТЬ СРАЗУ В РЕГИСТРАЦИ  ИЛИ НЕТ
           timer1.Stop();

        }

        private void HelloForm_Load(object sender, EventArgs e)
        {
            
            
            f.Show();
            string str;

            try {
                StreamReader  fptr = new StreamReader("data.dat");
          
                int i = 0;
                while (!fptr.EndOfStream)
                {
                    str = fptr.ReadLine();
                    f.dataGridView1.Rows.Add();
                    f.dataGridView1.Rows[i].Cells[0].Value = (i + 1);//пронумеровать (id)
                    String[] words = str.Split(new char[] {'#'}, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 1; j < 6; j++)
                    {
                        f.dataGridView1.Rows[i].Cells[j].Value = words[j - 1];
                    }
                    i++;
                }
                
                fptr.Close();
            }
            catch (Exception E)
            { MessageBox.Show("Ошибка данных приложения"); }


        }

        private void button_reg_new_Click(object sender, EventArgs e)
        {
            string name = textBox_name_reg.Text;
            string login = textBox_log_reg.Text;
            string pass = textBox_pass_reg.Text;

            try
            {
                using (StreamWriter sw = new StreamWriter("data.dat", true))
                {
                    sw.Write("\n0#" + login + "#" + pass + "#"+name+"#"+"11.22.5555#");
                }
                
            }
            catch (Exception E)
            {
                MessageBox.Show("Ошибка данных приложения");
            }

            string str;

            try
            {
                StreamReader fptr = new StreamReader("data.dat");

                int i = 0;
                while (!fptr.EndOfStream)
                {
                    str = fptr.ReadLine();
                    f.dataGridView1.Rows.Add();
                    f.dataGridView1.Rows[i].Cells[0].Value = (i + 1);//пронумеровать (id)
                    String[] words = str.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 1; j < 6; j++)
                    {
                        f.dataGridView1.Rows[i].Cells[j].Value = words[j - 1];
                    }
                    i++;
                }

                fptr.Close();
            }
            catch (Exception E)
            { MessageBox.Show("Ошибка данных приложения"); }
        }
    }
}

