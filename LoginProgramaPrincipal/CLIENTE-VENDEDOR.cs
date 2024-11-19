using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginProgramaPrincipal
{
    public partial class CLIENTE_VENDEDOR : Form
    {
        public CLIENTE_VENDEDOR()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("Has ingresado como CONSUMIDOR - CLIENTE.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ACA TIENEN QUE PONER EL CATALOGO
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show("Como eres Vendedor, te pasaremos al INICIO DE SESION. ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 LOGINVENDEDOR = new Form1();
                LOGINVENDEDOR.ShowDialog();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CLIENTE_VENDEDOR_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
