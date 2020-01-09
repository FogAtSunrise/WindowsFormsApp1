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

        private void добавитьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddForm z = new AddForm();
            z.Show();
        }
    }
}
//