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

      
        /*private void button_DAY_Click(object sender, EventArgs e)
{
   if (!panel_DAY.Visible)
       panel_DAY.Visible = true;
   if (panel_dlya_nedeliiii.Visible)
       panel_dlya_nedeliiii.Visible = false;
   if (panel_dlya_mesyaca.Visible)
       panel_dlya_mesyaca.Visible = false;
}

private void button_WEEK_Click(object sender, EventArgs e)
{
   if (!panel_dlya_nedeliiii.Visible)
        panel_dlya_nedeliiii.Visible = true;
        if (panel_DAY.Visible)
       panel_DAY.Visible = false;
   if (panel_dlya_mesyaca.Visible)
       panel_dlya_mesyaca.Visible = false;
}

private void button_MONTH_Click(object sender, EventArgs e)
{
   if (!panel_dlya_mesyaca.Visible)
       panel_dlya_mesyaca.Visible = true;
   if (panel_DAY.Visible)
       panel_DAY.Visible = false;
   if (panel_dlya_nedeliiii.Visible)
       panel_dlya_nedeliiii.Visible = false;
}*/
    }
        

       
    }

