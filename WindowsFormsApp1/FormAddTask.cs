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
            if (!panel_notifications_on.Visible)
                panel_notifications_on.Visible = true;
            else panel_notifications_on.Visible = false;
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
                            string date = dateTimePicker1.ToString();
                            String[] words_date = date.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            int row = DopDop.dataGridView1.RowCount -1;
                            DopDop.dataGridView1.Rows.Add();
                            DopDop.dataGridView1.Rows[row].Cells[0].Value = "0";
                            DopDop.dataGridView1.Rows[row].Cells[1].Value = words_date[0];
                            DopDop.dataGridView1.Rows[row].Cells[2].Value = dop1 + ":" + dop2;
                            DopDop.dataGridView1.Rows[row].Cells[3].Value = textBox_article.Text;
                            DopDop.dataGridView1.Rows[row].Cells[4].Value = textBox_description.Text;
                            if (checkBox_notifications.Checked == true)
                                DopDop.dataGridView1.Rows[row].Cells[5].Value = "1";
                            else DopDop.dataGridView1.Rows[row].Cells[5].Value = "0";
                            DopDop.dataGridView1.Rows[row].Cells[6].Value = "1"; // because day
                           // DopDop.dataGridView1.Rows.Add();
                        }


                    }
                    catch (Exception E)
                    {
                        label_error_time.Show();
                    }
                }
            }
            else // если время не заполнено, тогда неделя
            if (comboBox1.SelectedItem.ToString() == "Неделя")
            {
                string date = dateTimePicker1.ToString();
                String[] words_date = date.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int row = DopDop.dataGridView1.RowCount -1;
                DopDop.dataGridView1.Rows.Add();
                DopDop.dataGridView1.Rows[row].Cells[0].Value = "0";
                DopDop.dataGridView1.Rows[row].Cells[1].Value = words_date[0];
                DopDop.dataGridView1.Rows[row].Cells[2].Value = "0";
                DopDop.dataGridView1.Rows[row].Cells[3].Value = textBox_article.Text;
                DopDop.dataGridView1.Rows[row].Cells[4].Value = textBox_description.Text;
                if (checkBox_notifications.Checked == true)
                    DopDop.dataGridView1.Rows[row].Cells[5].Value = "1";
                else DopDop.dataGridView1.Rows[row].Cells[5].Value = "0";
                DopDop.dataGridView1.Rows[row].Cells[6].Value = "2"; // because week
            }
            else if(comboBox1.SelectedItem.ToString() == "Месяц")
            {
                int row = DopDop.dataGridView1.RowCount-1;
                DopDop.dataGridView1.Rows.Add();
                DopDop.dataGridView1.Rows[row].Cells[0].Value = "0";
                DopDop.dataGridView1.Rows[row].Cells[1].Value = dateTimePicker1.Value;
                DopDop.dataGridView1.Rows[row].Cells[2].Value = "0";
                DopDop.dataGridView1.Rows[row].Cells[3].Value = textBox_article.Text;
                DopDop.dataGridView1.Rows[row].Cells[4].Value = textBox_description.Text;
                if (checkBox_notifications.Checked == true)
                    DopDop.dataGridView1.Rows[row].Cells[5].Value = "1";
                else DopDop.dataGridView1.Rows[row].Cells[5].Value = "0";
                DopDop.dataGridView1.Rows[row].Cells[6].Value = "3"; // because month
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
    } }
