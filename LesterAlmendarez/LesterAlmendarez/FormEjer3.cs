﻿using System;
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
    public partial class FormEjer3 : Form
    {
        public FormEjer3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Multiplos();
        }

        private static void Multiplos() {

            for (int i =1; i <= 100; i++) {

                if (i % 3 == 0 && i % 5 == 0)
                {

                    MessageBox.Show("lester almendarez ");



                }
                else if (i % 3 == 0)
                {

                    MessageBox.Show("lester");

                }
                else if (i % 5 == 0)
                {

                    MessageBox.Show("almendarez");

                }
                else {

                    MessageBox.Show("  "+i);
                
                }





            }
        
        
        
        
        
        }






    }
}
