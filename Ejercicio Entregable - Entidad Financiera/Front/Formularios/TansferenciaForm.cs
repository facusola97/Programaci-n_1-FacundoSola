using Back;
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
    public partial class TansferenciaForm : Form
    {

        Principal back = new Principal ();
        BancoDbContextcs dbContext = new BancoDbContextcs ();

        public TansferenciaForm ( )
        {
            InitializeComponent ();
        }




        public void ActualizarDataGridView ( )
        {
            // Obtener los datos de la base de datos.
            var cuentas = dbContext.CuentasBancarias.ToList ();


            // Asignar los datos a la herramienta datagridview.
            dataGridView1.DataSource = cuentas;

            dbContext.SaveChanges ();
        }

        private void numericUpDown1_ValueChanged ( object sender, EventArgs e )
        {

        }

        private void TansferenciaForm_Load ( object sender, EventArgs e )
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = back.MostrarCuentas ();
            dataGridView1.Columns["Titular_Cuenta"].Visible = false;
        }

        private void button4_Click ( object sender, EventArgs e )
        {


        }
    }
}
