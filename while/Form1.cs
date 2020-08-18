using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numero = 1;
            while (numero <= 100)
            {
                listBox1.Items.Add(numero);
                numero = numero + 1;

                /* declara variavel inteiro, variavel iniciada com 1
                 * enquanto o numero for menor ou igual a 100 listbox sera preenchido
                 * expressão = numero + numero1 é o incremento */
            }
        }
    }
}
