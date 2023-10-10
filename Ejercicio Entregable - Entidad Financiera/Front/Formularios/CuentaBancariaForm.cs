using Back;
using Back.Clases;
using Microsoft.EntityFrameworkCore;
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
            Principal.db_context.CuentasBancarias.Load ();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Principal.db_context.CuentasBancarias.Local.ToBindingList ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            //CuentaBancaria cuenta = new CuentaBancaria (txt1, txtdni, txtNombre);





        }

        private void bindingSource1_CurrentChanged ( object sender, EventArgs e )
        {

        }

        private void txt1_TextChanged ( object sender, EventArgs e )
        {

        }
    }
}
