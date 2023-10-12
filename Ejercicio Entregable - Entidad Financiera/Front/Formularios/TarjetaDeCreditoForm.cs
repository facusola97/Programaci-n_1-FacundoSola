using Back;
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
    public partial class TarjetaDeCreditoForm : Form
    {
        Principal back = new Principal ();
        BancoDbContextcs dbContext = new BancoDbContextcs ();



        public TarjetaDeCreditoForm ( )
        {
            InitializeComponent ();
        }


        public void ActualizarDataGridView ( )
        {

            var tarjetas = dbContext.TarjetasDeCredito.ToList ();

            dataGridView1.DataSource = tarjetas;

        }


        private void button1_Click ( object sender, EventArgs e )
        {

        }

        private void button3_Click ( object sender, EventArgs e )
        {
            Inicio inicio = new Inicio ();
            inicio.Show ();
            this.Hide ();
        }

        private void button5_Click ( object sender, EventArgs e )
        {

        }

        private void TarjetaDeCreditoForm_Load ( object sender, EventArgs e )
        {
            comboBox1.DataSource = back.MostrarTodoslosClientes ();
            comboBox1.DisplayMember = "NombreCompleto";

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = back.MostrasTarjetas ();
            dataGridView1.Columns["LimiteCredito"].Width = 150;
            dataGridView1.Columns["Titular"].Visible = false;
        }
    }
}
