using NumerosPares.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosPares.View
{
    public partial class FormPares : Form
    {
        public FormPares()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ParesClass calculo = new ParesClass();
            if(txtNumero.Text != string.Empty)
            {
                int valor = Convert.ToInt32(txtNumero.Text);
                string resultado = calculo.calcularPares(valor);
                lblResul.Text = (resultado.ToString());
            }
            else
            {

            }


        }
    }
}
