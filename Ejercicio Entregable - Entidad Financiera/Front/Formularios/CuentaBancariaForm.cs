using Back;
using Back.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Front.Formularios
{
    public partial class CuentaBancariaForm : Form
    {
        Principal back = new Principal ();
        BancoDbContextcs dbContext = new BancoDbContextcs ();
          

        public void ActualizarDataGridView ( )
        {
            // Obtener los datos de la base de datos.
            var cuentas = dbContext.CuentasBancarias.ToList ();


            // Asignar los datos a la herramienta datagridview.
            dataGridView1.DataSource = cuentas;

            dbContext.SaveChanges ();
        }


        public CuentaBancariaForm ( )
        {
            InitializeComponent ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {



        }

        private void button2_Click ( object sender, EventArgs e )
        {
            Inicio inicio = new Inicio ();
            inicio.Show ();
            this.Hide ();
        }

        private void comboBox1_SelectedIndexChanged ( object sender, EventArgs e )
        {

        }

        private void CuentaBancariaForm_Load ( object sender, EventArgs e )
        {
            comboBox1.DataSource = back.MostrarTodoslosClientes ();
            comboBox1.DisplayMember = "NombreCompleto";

            comboBox2.DataSource = Principal.mostrartipos ();
            comboBox2.DisplayMember = ToString ();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = back.MostrarCuentas ();
            dataGridView1.Columns["Titular_Cuenta"].Visible = false;


        }

        private void button1_Click_1 ( object sender, EventArgs e )
        {




            
        }

        private void button4_Click ( object sender, EventArgs e )
        {
            Tipos tipos = (comboBox2.SelectedIndex == 0) ? Tipos.CajaAhorro : Tipos.CuentaCorriente;
            string dni = txtdni.Text;

            Principal.CrearCuentaBancaria ((Cliente)comboBox1.SelectedItem,tipos,dni );

            ActualizarDataGridView ();

        }

        private void label2_Click ( object sender, EventArgs e )
        {

        }
    }
}
