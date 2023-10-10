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
    public partial class ClienteFrom : Form
    {
        BancoDbContext dbContext = new BancoDbContext ();
        Principal backP = new Principal ();


        public ClienteFrom ( )
        {
            InitializeComponent ();
        }

        private void pictureBox1_Click ( object sender, EventArgs e )
        {

        }

        private void button3_Click ( object sender, EventArgs e )
        {
            InicioForm inicio = new InicioForm ();
            inicio.Show ();
            this.Hide ();
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            Cliente nuevoCliente = new Cliente (txt1.Text, txt2.Text, int.Parse (txt3.Text));

            nuevoCliente.Nombre = txt1.Text;
            nuevoCliente.Apellido = txt2.Text;
            nuevoCliente.dni = int.Parse (txt3.Text);


            dbContext.Clientes.Add (nuevoCliente);
            dbContext.SaveChanges ();


            dataGridView1.DataSource = Principal.db_context.Clientes.ToList ();

            txt1.Clear ();
            txt2.Clear ();
            txt2.Clear ();
        }

        private void textBox1_TextChanged ( object sender, EventArgs e )
        {

        }

        private void dataGridView1_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {

        }
    }
}
