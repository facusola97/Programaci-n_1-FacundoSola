using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front.Formularios
{
    public partial class TarjetaDeCreditoForm : Form
    {
        public TarjetaDeCreditoForm ( )
        {
            InitializeComponent ();
        }

        private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void button4_Click ( object sender, EventArgs e )
        {
        }

        private void button5_Click ( object sender, EventArgs e )
        {
            InicioForm inicio = new InicioForm ();
            inicio.Show ();
            this.Hide ();
        }

        private void pictureBox2_Click ( object sender, EventArgs e )
        {
        }

        private void label1_Click ( object sender, EventArgs e )
        {
        }

        private void pictureBox1_Click ( object sender, EventArgs e )
        {
        }

        private void button1_Click ( object sender, EventArgs e )
        {
        }

        private void button4_Click_1 ( object sender, EventArgs e )
        {

        }

        private void label4_Click ( object sender, EventArgs e )
        {

        }
    }
}
