using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Monto_Artículos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_monto_total_de_artículos.Clear();
            txt_descuento.Clear();
            txt_monto_neto.Clear();
            txt_itbis.Clear();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txt_monto_total_de_artículos.Text, out double montoTotal))
            {
                double descuento = 0;
                double itbis = montoTotal * 0.18; 

                if (montoTotal >= 5001 && montoTotal <= 10000)
                {
                    descuento = montoTotal * 0.03;
                }
                else if (montoTotal > 10000 && montoTotal <= 15000)
                {
                    descuento = montoTotal * 0.05;
                }
                else if (montoTotal > 15000 && montoTotal <= 20000)
                {
                    descuento = montoTotal * 0.08;
                }
                else if (montoTotal > 20000)
                {
                    descuento = montoTotal * 0.1;
                }
                else
                {
                    MessageBox.Show("No aplica descuento.");
                    return;
                }

                double montoNeto = montoTotal - descuento + itbis;

                
                txt_descuento.Text = descuento.ToString("C");
                txt_itbis.Text = itbis.ToString("C");
                txt_monto_neto.Text = montoNeto.ToString("C");
            }
            else
            {
                MessageBox.Show("Por favor ingrese un monto válido.", "Error de entrada");
            }
        }
    }
}

    
