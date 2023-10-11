using Back;
using Back.Clases;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
    public partial class CuentaBancariaForm : Form
    {
        public CuentaBancariaForm ( )
        {
            InitializeComponent ();
        }
        BancoDbContext dbContext = new BancoDbContext ();
        Principal backP = new Principal ();
        private void button3_Click ( object sender, EventArgs e )
        {
            InicioForm inicio = new InicioForm ();
            inicio.Show ();
            this.Hide ();
        }

        private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {

        }

        private void CuentaBancaria_Load ( object sender, EventArgs e )
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = backP.MostrarCuentas ();
            dataGridView1.Columns["Titular"].Visible = false;
            dataGridView1.Columns["NombreTitular"].Width = 150;
            dataGridView1.DataSource = Principal.db_context.CuentasBancarias.Local.ToBindingList ();

            comboBox1.DataSource = backP.MostrarTodoslosClientes ();
            comboBox1.DisplayMember = "NombreCompleto";
        }

        private void button1_Click ( object sender, EventArgs e )
        {

            Cliente cliente = new Cliente () ;
            Tipos tipodecuenta = (comboBox2.SelectedItem == null) ? Tipos.CajaAhorro : Tipos.CuentaCorriente;
            Principal.CrearCuentaBancaria (cliente,tipodecuenta);








        }

        private void txt2_TextChanged ( object sender, EventArgs e )
        {

        }
    }
}
