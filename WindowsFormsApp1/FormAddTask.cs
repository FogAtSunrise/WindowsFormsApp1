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

            if (String.IsNullOrWhiteSpace(dop1) || (textBox_hour.Text) == String.Empty || String.IsNullOrWhiteSpace(dop2) || (textBox_minutes.Text) == String.Empty)
                label_error_time.Show();
            else
                if (dop1.Contains(" ") || dop1.Contains("#") || dop1.Contains("%") || dop1.Contains("$") || dop2.Contains(" ") || dop2.Contains("#") || dop2.Contains("%") || dop2.Contains("$"))
                label_error_time.Show();
            else if (dop1.Length < 2 || dop1.Length > 2 || dop2.Length < 2 || dop2.Length > 2) label_error_time.Show();
            else {
                try {
                    int hour = Convert.ToInt32(dop1);
                    int minutes = Convert.ToInt32(dop2);
                    if (hour > 23 || hour < 00 || minutes > 59 || minutes < 00) label_error_time.Show();
                    else label_error_time.Text = "ok";
                }
                catch (Exception E){
                    label_error_time.Show();
                }
             }


            
        }
} }
