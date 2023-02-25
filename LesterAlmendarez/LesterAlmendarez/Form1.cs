using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LesterAlmendarez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pRIMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ejercicio = new FormEjer1();
            ejercicio.Show();

        }

        private void sEGUNDOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ejercicio = new FormEjer2();
            ejercicio.Show();
        }

        private void tERCEROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ejercicio = new FormEjer3();
            ejercicio.Show();
        }
    }
}
