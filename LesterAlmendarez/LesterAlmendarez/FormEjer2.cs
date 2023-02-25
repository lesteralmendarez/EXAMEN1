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
    public partial class FormEjer2 : Form
    {

        public FormEjer2()
        {
            InitializeComponent();
        }

        private void FormEjer2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CALCULObutton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void CALCULARbutton_Click(object sender, EventArgs e)
        {

            double de = 0.15;
            double numero1 = 0;
            double numero2 = 0;

            String Producto1 = PRODUCTO1textBox.Text;
            String Producto2 = PRODUCTO2textBox.Text;

            numero1 = Convert.ToDouble(PRECIO1textBox.Text);
            numero2 = Convert.ToDouble(PRECIO2textBox.Text);

            double suma = numero1 + numero2;
            double descuentoo = suma * 0.15;
            MessageBox.Show("LA VENTA SIN DESCUENTO ES " + suma);
            MessageBox.Show("EL DESCUENTO ES DE " + descuentoo);
            double Descuento = await DescAsync(suma, descuentoo);
            // mensaje de impresion para ver el promedio en pantalla
            MessageBox.Show($"LA COMPRA CON EL DESCUENTO INCLUIDO ES DE  :{Descuento}");

        }

        private async Task<double> DescAsync(double suma, double descuentoo)
        {

            double descuento = await Task.Run(() =>
            {

                //operacion aritmetica para calcular promedio
                return (suma - descuentoo);


            });


            return descuento;
        }















    }
}
