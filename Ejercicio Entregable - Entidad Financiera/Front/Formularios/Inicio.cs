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
    public partial class Inicio : Form
    {
        public Inicio ( )
        {
            InitializeComponent ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            ClienteForm cliente = new ClienteForm ();
            cliente.Show ();
            this.Hide ();
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            CuentaBancariaForm cuentaBancaria = new CuentaBancariaForm ();
            cuentaBancaria.Show ();
            this.Hide ();
        }

        private void button3_Click ( object sender, EventArgs e )
        {
            TarjetaDeCreditoForm tarjetaDeCredito = new TarjetaDeCreditoForm ();
            tarjetaDeCredito.Show ();
            this.Hide ();
        }
    }
}
