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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void checkBox_notifications_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string dop1 = textBox_hour.Text;
            string dop2 = textBox_minutes.Text;


            if (dop2 != String.Empty && dop1 != String.Empty)
            { // если время заполнено
                if (String.IsNullOrWhiteSpace(dop1) || (textBox_hour.Text) == String.Empty || String.IsNullOrWhiteSpace(dop2) || (textBox_minutes.Text) == String.Empty)
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
                            string date = dateTimePicker1.Value.ToString();
                            String[] words_date = date.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            int row = DopDop.dataGridView1.RowCount - 1;
                            DopDop.dataGridView1.Rows.Add();
                            DopDop.dataGridView1.Rows[row].Cells[0].Value = "0";
                            DopDop.dataGridView1.Rows[row].Cells[1].Value = words_date[0];
                            DopDop.dataGridView1.Rows[row].Cells[2].Value = dop1 + ":" + dop2;
                            DopDop.dataGridView1.Rows[row].Cells[3].Value = textBox_article.Text;
                            DopDop.dataGridView1.Rows[row].Cells[4].Value = textBox_description.Text;
                            if (checkBox_notifications.Checked == true)
                            {
                                DopDop.dataGridView1.Rows[row].Cells[5].Value = "1";
                                
 
                            }
                            else
                            {
                                DopDop.dataGridView1.Rows[row].Cells[5].Value = "0";
                                
                            }
                            DopDop.dataGridView1.Rows[row].Cells[6].Value = "1"; // because day
                                                                                 // DopDop.dataGridView1.Rows.Add();

                            label_molodec.Visible = true;
                            dateTimePicker1.Value = DateTime.Today;
                            if (checkBox_notifications.Checked)
                            {
                                checkBox_notifications.Checked = false;
                                
                            }
                            comboBox1.Text = "";
                            textBox_article.Text = "";
                            textBox_description.Text = "";
                            textBox_hour.Text = "";
                            
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
                if (comboBox1.Text.ToString() == String.Empty || comboBox1.Text.ToString() == "(Пусто)")
                {

                    string date = dateTimePicker1.Value.ToString();
                    String[] words_date = date.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int row = DopDop.dataGridView1.RowCount - 1;
                    DopDop.dataGridView1.Rows.Add();
                    DopDop.dataGridView1.Rows[row].Cells[0].Value = "0";
                    DopDop.dataGridView1.Rows[row].Cells[1].Value = words_date[0];
                    DopDop.dataGridView1.Rows[row].Cells[2].Value = "0";
                    DopDop.dataGridView1.Rows[row].Cells[3].Value = textBox_article.Text;
                    DopDop.dataGridView1.Rows[row].Cells[4].Value = textBox_description.Text;
                    if (checkBox_notifications.Checked == true)
                    {
                        DopDop.dataGridView1.Rows[row].Cells[5].Value = "1";
                        
                    }
                    else
                    {
                        DopDop.dataGridView1.Rows[row].Cells[5].Value = "0";
                        
                    }

                    DopDop.dataGridView1.Rows[row].Cells[6].Value = "2"; // because week

                    label_molodec.Visible = true;
                    if (checkBox_notifications.Checked)
                    {
                        checkBox_notifications.Checked = false;
                        
                    }
                    dateTimePicker1.Value = DateTime.Today;
                    comboBox1.Text = "";
                    textBox_article.Text = "";
                    textBox_description.Text = "";
                    textBox_hour.Text = "";
                   
                    textBox_minutes.Text = "";
                    
                    label_error_time.Hide();
                }
                else  // MONTH
                {

                    string date = dateTimePicker1.Value.ToString();
                    String[] words_date = date.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    String[] words_datepath = words_date[0].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
                    String month = "";
                    if (comboBox1.Text.ToString() == "Январь") month = "01";
                    if (comboBox1.Text.ToString() == "Февраль") month = "02";
                    if (comboBox1.Text.ToString() == "Март") month = "03";
                    if (comboBox1.Text.ToString() == "Апрель") month = "04";
                    if (comboBox1.Text.ToString() == "Май") month = "05";
                    if (comboBox1.Text.ToString() == "Июнь") month = "06";
                    if (comboBox1.Text.ToString() == "Июль") month = "07";
                    if (comboBox1.Text.ToString() == "Август") month = "08";
                    if (comboBox1.Text.ToString() == "Сентябрь") month = "09";
                    if (comboBox1.Text.ToString() == "Октябрь") month = "10";
                    if (comboBox1.Text.ToString() == "Ноябрь") month = "11";
                    if (comboBox1.Text.ToString() == "Декабрь") month = "12";
                    int row = DopDop.dataGridView1.RowCount - 1;
                    DopDop.dataGridView1.Rows.Add();
                    DopDop.dataGridView1.Rows[row].Cells[0].Value = "0";
                    DopDop.dataGridView1.Rows[row].Cells[1].Value = words_datepath[0]+"." + month + "." + words_datepath[2];
                    DopDop.dataGridView1.Rows[row].Cells[2].Value = "0";
                    DopDop.dataGridView1.Rows[row].Cells[3].Value = textBox_article.Text;
                    DopDop.dataGridView1.Rows[row].Cells[4].Value = textBox_description.Text;
                    if (checkBox_notifications.Checked == true)
                    {
                        DopDop.dataGridView1.Rows[row].Cells[5].Value = "1";
                       
                    }
                    else
                    {
                        DopDop.dataGridView1.Rows[row].Cells[5].Value = "0";
                        
                    }
                    DopDop.dataGridView1.Rows[row].Cells[6].Value = "3"; // because month

                    label_molodec.Visible = true;
                    if (checkBox_notifications.Checked)
                    {
                        checkBox_notifications.Checked = false;
                       
                    }
                    dateTimePicker1.Value = DateTime.Today;
                    comboBox1.Text = "";
                    textBox_article.Text = "";
                    textBox_description.Text = "";
                    textBox_hour.Text = "";
                    
                    textBox_minutes.Text = "";
                    
                    label_error_time.Hide();
                }
               // else { MessageBox.Show("ничего не выбралось"); }

            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_dnm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAddTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            DopDop.writefiledela();
            
           // Application.Exit();
        }
    }   
}
