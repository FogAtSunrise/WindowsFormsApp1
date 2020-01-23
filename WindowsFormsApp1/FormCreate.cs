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
    public partial class CreateDoc : Form
    {
        public CreateDoc()
        {
            InitializeComponent();
        }
        string puty;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_create_Click(object sender, EventArgs e)
        {
            bool proverka = false;
            // проверяем текстбокс
            string tex = textBox_file_name.Text.ToString();
            if (tex == HelloForm.LogNow)
            {
                label_error.Text = "Придумайте другое название файла!";
                label_error.Visible = true;
            }
            else if(tex == "")
            {
                label_error.Text = "Введите название файла";
                label_error.Visible = true;
            }
            else if(tex.Contains("!") || tex.Contains("@") || tex.Contains("#") || tex.Contains("$") || tex.Contains("%") || tex.Contains("^") || tex.Contains("&") ||
                tex.Contains(">") || tex.Contains("<") || tex.Contains("?") || tex.Contains("/") || tex.Contains("\\") || tex.Contains(",") || tex.Contains(".") || tex.Contains("+")
                || tex.Contains("№") || tex.Contains(";") || tex.Contains(":") || tex.Contains("*") || tex.Contains("=") || tex.Contains("\"") || tex.Contains("\'") || tex.Contains("{")
                || tex.Contains("}") || tex.Contains("[") || tex.Contains("]") || tex.Contains("~") || tex.Contains("`"))
            {
                label_error.Text = "Недопустимые символы, используйте только буквы или цифры";
                label_error.Visible = true;
            }

            // проверяем чекбокс - все выполненые дела
            if (checkBox_period_all.Checked == false) {
                if (dateTimePicker_one.Value.Date > dateTimePicker_two.Value.Date)
                {
                    label_error.Text = "Период указан неверно";
                    label_error.Visible = true;
                }
                else
                {//если период указан верно, создаем файл в пути, который указал пользователь
                    string puty1 = puty + "\\" + tex + ".txt";
                    string data1 = dateTimePicker_one.Value.ToString();
                    string data2 = dateTimePicker_two.Value.ToString();
                    
                    String[] data11 = data1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    String[] data22 = data2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    String[] data111 = data11[0].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    String[] data222 = data22[0].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                    int day1 = Convert.ToInt32(data111[0]);
                    int month1 = Convert.ToInt32(data111[1]);
                    int year1 = Convert.ToInt32(data111[2]);
                    int day2 = Convert.ToInt32(data222[0]);
                    int month2 = Convert.ToInt32(data222[1]);
                    int year2 = Convert.ToInt32(data222[2]);



                    int cout = DopDop.dataGridView1.RowCount - 1;
                 //   File.Create(puty);
                    StreamWriter other = new StreamWriter(puty1, false);
                    for (int i = 0; i < cout; i++)
                    {
                        string data_tab = DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString();
                        String[] data = data_tab.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                        int day = Convert.ToInt32(data[0]);
                        int month = Convert.ToInt32(data[1]);
                        int year = Convert.ToInt32(data[2]);

                        if (DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString() == "1")
                            if (year1 == year2) // если год периода равен друг между другом, то смотрим по месяцу
                            {
                                if (month1 == month2) // если месяцы равны между собой, смотрим по дням
                                {
                                    if (day1 == day2) // тогда выводим список выполненных дел за этот день
                                    {
                                        if (day == day1)
                                            other.WriteLine(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + DopDop.dataGridView1.Rows[i].Cells[3].Value.ToString() + "\t" + DopDop.dataGridView1.Rows[i].Cells[4].Value.ToString());
                                    }
                                    else // если дни не совпадают, то проверяем 
                                    {
                                        if (day < day2 && day > day1)
                                            other.WriteLine(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + DopDop.dataGridView1.Rows[i].Cells[3].Value.ToString() + "\t" + DopDop.dataGridView1.Rows[i].Cells[4].Value.ToString());
                                    }

                                }
                                else // если месяцы не равны между собой, то смотрим по месяцу
                                {
                                    if(month < month2 && month > month1)
                                        other.WriteLine(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + DopDop.dataGridView1.Rows[i].Cells[3].Value.ToString() + "\t" + DopDop.dataGridView1.Rows[i].Cells[4].Value.ToString());

                                }
                            }
                            else // если года не равны
                            {
                                if (year > year1 && year < year2)
                                    other.WriteLine(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + DopDop.dataGridView1.Rows[i].Cells[3].Value.ToString() + "\t" + DopDop.dataGridView1.Rows[i].Cells[4].Value.ToString());
                            }

                    }
                    other.Close();

                }

                

            }
            else
            {
                string puty1 = puty + "\\" + tex + ".txt";

                int cout = DopDop.dataGridView1.RowCount - 1;

                StreamWriter other = new StreamWriter(puty1, false);
                for (int i = 0; i < cout; i++)
                {
                    if (DopDop.dataGridView1.Rows[i].Cells[0].Value.ToString() == "1")
                        other.WriteLine(DopDop.dataGridView1.Rows[i].Cells[1].Value.ToString() + "\t" + DopDop.dataGridView1.Rows[i].Cells[3].Value.ToString() + "\t" + DopDop.dataGridView1.Rows[i].Cells[4].Value.ToString());

                }
                other.Close();
            }

            dateTimePicker_one.Value = DateTime.Today;
            dateTimePicker_two.Value = DateTime.Today;
            textBox_file_name.Text = "";
            checkBox_period_all.Checked = false;
            label_error.Text = "Файл успешно создан!";
            label_error.ForeColor = Color.Green;
            label_error.Visible = true;
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            puty = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создание отчета.\nЧтобы создать отчет по выполненным делам, выберите промежуток при помощи" +
                "двух календарей. Если необходим отчет за один день, достаточно того, чтобы даты совпадали.\n" +
                "Если необходим отчет за все время, достаточно отметить галочкой \"Показать все выполненные задачи за все время\"" +
                "\nПосле этого, впишите название файла и выбирите папку, в котором должен находиться файл с отчетом.\n" +
                "Файл автоматически записывается в разрешении .txt, точки и иные символы кроме букв и цифр использовать для имени " +
                "файла нельзя. \nПо окончании нажмите кнопку \"Создать!\".");
        }
    }
}
