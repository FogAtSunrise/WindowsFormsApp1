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
    public partial class EditDeloForm : Form
    {
        public EditDeloForm()
        {
            InitializeComponent();
        }

        private void EditDeloForm_Load(object sender, EventArgs e)
        {
            textBox_article.Text = DopDop.dataGridView1.Rows[Form2.edit_row].Cells[3].Value.ToString();
            textBox_description.Text = DopDop.dataGridView1.Rows[Form2.edit_row].Cells[4].Value.ToString();
            if (DopDop.dataGridView1.Rows[Form2.edit_row].Cells[0].Value.ToString() == "1")
                checkBox_done.Checked = true;
            string date;
            
            date = DopDop.dataGridView1.Rows[Form2.edit_row].Cells[1].Value.ToString();
            dateTimePicker_edit.Value = DateTime.Parse(date);
            if (DopDop.dataGridView1.Rows[Form2.edit_row].Cells[5].Value.ToString() == "1")
            {
                checkBox_notifications.Checked = true;
                
            }

            if (DopDop.dataGridView1.Rows[Form2.edit_row].Cells[6].Value.ToString() == "1") // for a day
            {
                string hour, minutes;
                string dop = DopDop.dataGridView1.Rows[Form2.edit_row].Cells[2].Value.ToString();
                String[] time = dop.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                hour = time[0];
                minutes = time[1];
                textBox_hours.Text = hour;
                textBox_minutes.Text = minutes;
                
                
            }

            //for a week
            if(DopDop.dataGridView1.Rows[Form2.edit_row].Cells[6].Value.ToString() == "2")
            {
                
                
            }

            //for a month
            if(DopDop.dataGridView1.Rows[Form2.edit_row].Cells[6].Value.ToString() == "3")
            {
                string dop = DopDop.dataGridView1.Rows[Form2.edit_row].Cells[1].Value.ToString();
                String[] date_path = dop.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                comboBox_month.SelectedIndex = Convert.ToInt32(date_path[1]);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            string dop1 = textBox_hours.Text;
            string dop2 = textBox_minutes.Text;


            if (dop2 != String.Empty && dop1 != String.Empty)
            { // если время заполнено
                if (String.IsNullOrWhiteSpace(dop1) || (textBox_hours.Text) == String.Empty || String.IsNullOrWhiteSpace(dop2) || (textBox_minutes.Text) == String.Empty)
                    label_error_time.Show();
                else
                    if (dop1.Contains(" ") || dop1.Contains("#") || dop1.Contains("%") || dop1.Contains("$") || dop2.Contains(" ") || dop2.Contains("#") || dop2.Contains("%") || dop2.Contains("$"))
                    label_error_time.Show();
                else if (dop1.Length < 2 || dop1.Length > 2 || dop2.Length < 2 || dop2.Length > 2) label_error_time.Show();
                else
                {
                    try
                    {
                        int hour = Convert.ToInt32(dop1);
                        int minutes = Convert.ToInt32(dop2);
                        if (hour > 24 || hour < 00 || minutes > 60 || minutes < 00) label_error_time.Show();
                        else // добавляем соответствующую запись конкретно о дне
                        {
                            string date = dateTimePicker_edit.Value.ToString();
                            String[] words_date = date.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            int row = Form2.edit_row;
                         //   DopDop.dataGridView1.Rows.Add();
                         if(checkBox_done.Checked == true)
                            DopDop.dataGridView1.Rows[row].Cells[0].Value = "1";
                         else DopDop.dataGridView1.Rows[row].Cells[0].Value = "0";
                            DopDop.dataGridView1.Rows[row].Cells[1].Value = words_date[0];
                            DopDop.dataGridView1.Rows[row].Cells[2].Value = dop1 + ":" + dop2;
                            DopDop.dataGridView1.Rows[row].Cells[3].Value = textBox_article.Text;
                            DopDop.dataGridView1.Rows[row].Cells[4].Value = textBox_description.Text;

                            if (checkBox_notifications.Checked == true)
                            {
                                DopDop.dataGridView1.Rows[row].Cells[5].Value = "1";
                                
                            }
                            else DopDop.dataGridView1.Rows[row].Cells[5].Value = "0";
                            DopDop.dataGridView1.Rows[row].Cells[6].Value = "1"; // because day
                                                                                 // DopDop.dataGridView1.Rows.Add();

                            label_molodec.Visible = true;
                            dateTimePicker_edit.Value = DateTime.Today;
                            if (checkBox_notifications.Checked)
                            {
                                checkBox_notifications.Checked = false;
                                
                            }
                            comboBox_month.Text = "";
                            textBox_article.Text = "";
                            textBox_description.Text = "";
                            textBox_hours.Text = "";
                            
                            textBox_minutes.Text = "";
                           
                            label_error_time.Hide();
                        }


                    }
                    catch (Exception E)
                    {
                        label_error_time.Show();
                    }
                }
            }
            else
            { // если время не заполнено, тогда неделя
                if (comboBox_month.Text.ToString() == String.Empty || comboBox_month.Text.ToString() == "(Пусто)")
                {

                    string date = dateTimePicker_edit.Value.ToString();
                    String[] words_date = date.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int row = Form2.edit_row;
                    // DopDop.dataGridView1.Rows.Add();
                    if (checkBox_done.Checked == true)
                        DopDop.dataGridView1.Rows[row].Cells[0].Value = "1";
                    else DopDop.dataGridView1.Rows[row].Cells[0].Value = "0";
                    DopDop.dataGridView1.Rows[row].Cells[1].Value = words_date[0];
                    DopDop.dataGridView1.Rows[row].Cells[2].Value = "0";
                    DopDop.dataGridView1.Rows[row].Cells[3].Value = textBox_article.Text;
                    DopDop.dataGridView1.Rows[row].Cells[4].Value = textBox_description.Text;
                    if (checkBox_notifications.Checked == true)
                    {
                        DopDop.dataGridView1.Rows[row].Cells[5].Value = "1";
                        
                    }
                    else DopDop.dataGridView1.Rows[row].Cells[5].Value = "0";
                    DopDop.dataGridView1.Rows[row].Cells[6].Value = "2"; // because week

                    label_molodec.Visible = true;
                    dateTimePicker_edit.Value = DateTime.Today;
                    if (checkBox_notifications.Checked)
                    {
                        checkBox_notifications.Checked = false;
                        
                    }
                    comboBox_month.Text = "";
                    textBox_article.Text = "";
                    textBox_description.Text = "";
                    textBox_hours.Text = "";
                    
                    textBox_minutes.Text = "";
                    
                    label_error_time.Hide();
                }
                else  // MONTH
                {

                    string date = dateTimePicker_edit.Value.ToString();
                    String[] words_date = date.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    String[] words_datepath = words_date[0].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    String month = "";
                    if (comboBox_month.Text.ToString() == "Январь") month = "01";
                    if (comboBox_month.Text.ToString() == "Февраль") month = "02";
                    if (comboBox_month.Text.ToString() == "Март") month = "03";
                    if (comboBox_month.Text.ToString() == "Апрель") month = "04";
                    if (comboBox_month.Text.ToString() == "Май") month = "05";
                    if (comboBox_month.Text.ToString() == "Июнь") month = "06";
                    if (comboBox_month.Text.ToString() == "Июль") month = "07";
                    if (comboBox_month.Text.ToString() == "Август") month = "08";
                    if (comboBox_month.Text.ToString() == "Сентябрь") month = "09";
                    if (comboBox_month.Text.ToString() == "Октябрь") month = "10";
                    if (comboBox_month.Text.ToString() == "Ноябрь") month = "11";
                    if (comboBox_month.Text.ToString() == "Декабрь") month = "12";
                    int row = Form2.edit_row;
                    //DopDop.dataGridView1.Rows.Add();
                    if (checkBox_done.Checked == true)
                        DopDop.dataGridView1.Rows[row].Cells[0].Value = "1";
                    else DopDop.dataGridView1.Rows[row].Cells[0].Value = "0";
                    DopDop.dataGridView1.Rows[row].Cells[1].Value = words_datepath[0] + "." + month + "." + words_datepath[2];
                    DopDop.dataGridView1.Rows[row].Cells[2].Value = "0";
                    DopDop.dataGridView1.Rows[row].Cells[3].Value = textBox_article.Text;
                    DopDop.dataGridView1.Rows[row].Cells[4].Value = textBox_description.Text;
                    if (checkBox_notifications.Checked == true)
                    {
                        DopDop.dataGridView1.Rows[row].Cells[5].Value = "1";
                        
                    }
                    else DopDop.dataGridView1.Rows[row].Cells[5].Value = "0";
                    DopDop.dataGridView1.Rows[row].Cells[6].Value = "3"; // because month

                    label_molodec.Visible = true;
                    if (checkBox_notifications.Checked)
                    {
                        checkBox_notifications.Checked = false;
                        
                    }
                    dateTimePicker_edit.Value = DateTime.Today;
                    comboBox_month.Text = "";
                    textBox_article.Text = "";
                    textBox_description.Text = "";
                    textBox_hours.Text = "";
                    
                    textBox_minutes.Text = "";
                    
                    label_error_time.Hide();
                }
                // else { MessageBox.Show("ничего не выбралось"); }

            }
        }

        private void EditDelo_FormClosed(object sender, FormClosedEventArgs e)
        {
            DopDop.writefiledela();

            // Application.Exit();
        }

        private void checkBox_notifications_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Редактирование записи." +
                "\nВсе поля автоматически заполняются информацией о задаче, которую выделил пользователь." +
                " Для того, чтобы изменить промежуток выполнения задачи на \"дневное\" необходимо выбрать время и день в календаре." +
                " Чтобы изменить на \"недельное\", достаточно изменить только дату в календаре - неделя будет отсчитываться от выбранного дня. " +
                "А для дела, которое нужно сделать в течение месяца, необходимо выбрать только месяц в правой колонке.\n" +
                "После этого можно изменить графы \"Заголовок\" и \"Описание\", если это необходимо. Так же можно изменить, выполнена ли задача. Если необходимо оповещение для задачи, нужно отметить " +
                "галочкой графу \"Оповещения\". Для добавления задачи в список, нажмите \"Изменить\"");

        }
    }
}
