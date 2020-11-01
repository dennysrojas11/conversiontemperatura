using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxFahrenheit.Focus();
            labelResultado.Visible = false;
        }

        private void textBoxFahrenheit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonConvertir.Focus();
            }
            Validar.validar(e);
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            if (textBoxFahrenheit.Text.Length == 0)
            {
                MessageBox.Show("Ingrese grados", "Número no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFahrenheit.Focus();
            }
            else
            {
                Calcular c = new Calcular(int.Parse(textBoxFahrenheit.Text));
                labelResultado.Text = c.convertir().ToString();
                labelResultado.Visible = true;
            }
        }
    }
}
