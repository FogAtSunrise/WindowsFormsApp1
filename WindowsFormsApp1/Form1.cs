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

        public static string LogNow;
        public static int strnum;
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

            // string ish = "ira";
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
                int count_rows = FormDopForm.dataGridView1.RowCount-1;
                int right_row = 0;
                
                    for (int i = 0; i < count_rows; i++)
                    {
                        string dop = FormDopForm.dataGridView1.Rows[i].Cells[2].Value.ToString();
                        if (dop == login) { found_log = true; right_row = i; strnum = i; }
                    }

                    //ПОИСК ЛОГИНА В ТАБЛИЦЕ IF "НЕ НАЙДЕН", ТО LABEL2, ELSE:
                    if (found_log)//это типо если логин найден
                    {
                        // string ishod = "hello";//СЧИТЫВАЕМ ПАРОЛЬ ДЛЯ НАЙДЕННОГО ЛОГИНА

                        if (pass == "") // если ввесли пустую строчку для пароля
                            label5.Show();
                        else
                        if (pass == FormDopForm.dataGridView1.Rows[right_row].Cells[3].Value.ToString())//пароль верный
                        {
                            FormDopForm.dataGridView1.Rows[right_row].Cells[1].Value = "1";
                            textBox_password.Clear();
                            textBox_loginusing.Clear();
                            Form2 y = new Form2();
                            y.Show(this);
                            LogNow = login;
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
            textBox_loginusing.Clear();
            textBox_password.Clear();

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
            textBox_log_reg.Clear();
            textBox_name_reg.Clear();
            textBox_pass_reg.Clear();
            label_molodec.Visible = false;
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
        }

        //Запуск таймера для панели приветствия запуске программы... надо длобавить проверку наличия учетных записе
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Hide();
            panel_registr.Hide();
            panel_vhod.Show(); //ПРОВЕРКА ФЛАГА, В ЗАВИСИМОСТИ ОТ НЕГО ОТПРАВЛЯТЬ СРАЗУ В РЕГИСТРАЦИ  ИЛИ НЕТ
            timer1.Stop();

        }
        
        private void HelloForm_Load(object sender, EventArgs e)
        {
            

            //f.Show();
            string str;
            int rows = -1;

            try
            {
                StreamReader fptr = new StreamReader("data.dat");

                int i = 0;
                while (!fptr.EndOfStream)
                {
                    str = fptr.ReadLine();
                    FormDopForm.dataGridView1.Rows.Add();
                    FormDopForm.dataGridView1.Rows[i].Cells[0].Value = (i + 1);//пронумеровать (id)
                    String[] words = str.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 1; j < 6; j++)
                    {
                        FormDopForm.dataGridView1.Rows[i].Cells[j].Value = words[j - 1];
                    }
                    i++;
                    rows = i;
                }

                fptr.Close();
            }
            catch (Exception E)
            { MessageBox.Show("Ошибка данных приложения"); }

            bool found = false;
            //int for_log = 0;
            string login = "";
            string pass = "";

            if (rows >= 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    if (FormDopForm.dataGridView1.Rows[i].Cells[1].Value.ToString() == "1") { found = true; login = FormDopForm.dataGridView1.Rows[i].Cells[2].Value.ToString();
                    pass = FormDopForm.dataGridView1.Rows[i].Cells[3].Value.ToString();
                    }
                }
            }

            
            if (found)
            {
                 textBox_loginusing.Text = login;
                textBox_password.Text = pass;
                LogNow = login;
                button_vhod_Click(this, EventArgs.Empty);
                
                /*  Form2 y = new Form2();
                  y.Show();
                  this.Hide();
  */
            }
            


        }

        private void button_reg_new_Click(object sender, EventArgs e)
        {
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            label12.Hide();
            label13.Hide();
            label14.Hide();
            string name = textBox_name_reg.Text;
            string login = textBox_log_reg.Text;
            string pass = textBox_pass_reg.Text;
            bool noEmpty = true;

            if (String.IsNullOrWhiteSpace(name) || name == "") //на пустоту и пробелы 
            {
                label6.Show();
                noEmpty = false;
            }
            else
            if (name.Length < 4 || name.Length > 20)//на дилнну имени
            {
                label9.Show();
                noEmpty = false;
            }
            else
                if (name.Contains("#") || name.Contains("%") || name.Contains("$"))
            {
                label12.Show();
                noEmpty = false;
            }

            //
                if (String.IsNullOrWhiteSpace(login) ||login == "")//на пустоту и пробелы
            {
                label7.Show();
                noEmpty = false;
            }
            else
            if (login.Length < 4 || login.Length > 20)//на длину логина
            {
                label10.Show();
                noEmpty = false;
            }
            else
                if (login.Contains("#") || login.Contains("%") || login.Contains("$"))
            {
                label13.Show();
                noEmpty = false;
            }

            if (String.IsNullOrWhiteSpace(pass) || pass == "")//на пустоту и пробелы
            {
                label8.Show();
                noEmpty = false;
            }
            else
            if (pass.Length < 4 || pass.Length > 20)//на длину пароля
            {
                label11.Show();
                noEmpty = false;
            }
            else
                if (pass.Contains("#") || pass.Contains("%") || pass.Contains("$"))
            {
                label14.Show();
                noEmpty = false;
            }
            if (noEmpty == true)  //no empty and mistake
            {
                try
                {
                    //StreamWriter sw = new StreamWriter("data.dat", true);
                    using (StreamWriter sw = new StreamWriter("data.dat", true))
                   {
                        if (FormDopForm.dataGridView1.RowCount - 1 != 0)
                            sw.Write("\n");
                    sw.Write("0#" + login + "#" + pass + "#" + name + "#" + DateTime.Now.ToShortDateString()+"#");
                        sw.Close();
                   }
                   
                }
                catch (Exception E)
                {
                    MessageBox.Show("Ошибка данных приложения");
                }


                bool sozdana = false;
                int count_rows = FormDopForm.dataGridView1.RowCount - 1;
                FormDopForm.dataGridView1.Rows.Add();
                FormDopForm.dataGridView1.Rows[count_rows].Cells[0].Value = count_rows + 1;
                FormDopForm.dataGridView1.Rows[count_rows].Cells[1].Value = 0;
                FormDopForm.dataGridView1.Rows[count_rows].Cells[2].Value = login;
                FormDopForm.dataGridView1.Rows[count_rows].Cells[3].Value = pass;
                FormDopForm.dataGridView1.Rows[count_rows].Cells[4].Value = name;
                FormDopForm.dataGridView1.Rows[count_rows].Cells[5].Value = DateTime.Now.ToShortDateString();
                     sozdana = true;
                  if (sozdana)
                {
                    label_molodec.Visible = true;
                    textBox_log_reg.Text = "";
                    textBox_name_reg.Text = "";
                    textBox_pass_reg.Text = "";
                }
            }
            

        }
    }
}

