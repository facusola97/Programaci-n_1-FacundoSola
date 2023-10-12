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
using Microsoft.EntityFrameworkCore;

namespace Front.Formularios
{
    public partial class ClienteForm : Form
    {
        Principal back = new Principal ();
        BancoDbContextcs dbContext = new BancoDbContextcs ();

        public void ActualizarDataGridView ( )
        {

            var clientes = dbContext.Clientes.ToList ();

            dataGridView1.DataSource = clientes;

        }


        public ClienteForm ( )
        {
            InitializeComponent ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            Inicio inicio = new Inicio ();
            inicio.Show ();
            this.Hide ();
        }

        private void button2_Click ( object sender, EventArgs e )
        {
            Cliente nuevoCliente = new Cliente (txtnombre.Text, txtapellido.Text, int.Parse (txtdni.Text));

            nuevoCliente.Nombre = txtnombre.Text;
            nuevoCliente.Apellido = txtapellido.Text;
            nuevoCliente.DNI = int.Parse (txtdni.Text);

            back.AgregarCliente (nuevoCliente);

            dbContext.SaveChanges ();

            dataGridView1.DataSource = Principal.db_context.Clientes.ToList ();

            ActualizarDataGridView ();

            txtnombre.Clear ();
            txtapellido.Clear ();
            txtdni.Clear ();

        }

        private void ClienteForm_Load ( object sender, EventArgs e )
        {
            Principal.db_context.Clientes.Load ();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Principal.db_context.Clientes.Local.ToBindingList ();
        }

        private void label2_Click ( object sender, EventArgs e )
        {

        }

        private void txtnombre_TextChanged ( object sender, EventArgs e )
        {

        }

        private void button3_Click ( object sender, EventArgs e )
        {
           
        }
    }
}
