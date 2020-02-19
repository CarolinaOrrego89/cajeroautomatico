using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajeroautomatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnretirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.5, 0.25, 0.1, 0.05, 0.01 };
            double cantidad = double.Parse(txtcantidad.Text);
            sbyte n = 0;
            string respuesta = "respuesta: \n";
            foreach (double denominacion in denominaciones)
            {
                while (denominacion <= Math.Round(cantidad, 2))
                {
                    n++;
                    cantidad -= denominacion;
                }
                if (n > 0)
                {
                    respuesta += n + (denominacion > 1 ? " billete:" : " monedas ") + denominacion + "\n";
                }
                n = 0;
            }
            lblrespuesta.Text = respuesta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, i, n;
            n = int.Parse(txtNum.Text);
            a = 0;
            for (i = 1; i < (n + 1); i++)

                if (n % i == 0)
                    a++;
            lblrespu.Text = ((a != 2) ? n + "EL NUMERO NO ES PRIMO " : n + "  EL NUMERO ES PRIMO" + "\n");
            txtNum.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtfibonaci.Text), a = 0, b = 1, au, i;
            string respuesta = "";
            for (i = 0; i < n; i++)
            {
                au = a;
                a = b;
                b = au + a;
                respuesta += "la suma de " + a + " es " + b + "\n";
                lblrespuesta.Visible = true;
                lblrespuesta.Text = "" + respuesta;
                txtfibonaci.Text = "";
            }
        }
    }
}

