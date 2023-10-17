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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Front
{
    public partial class Deposito : Form
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




        public Deposito ( )
        {
            InitializeComponent ();
        }

        private void Deposito_Load ( object sender, EventArgs e )
        {
            comboBox1.DataSource = Principal.ObtenerNumerosCuenta ();



            dataGridView1.DataSource = null;
            dataGridView1.DataSource = back.MostrarCuentas ();
            dataGridView1.Columns["Titular_Cuenta"].Visible = false;

        }

        private void button1_Click ( object sender, EventArgs e )
        {
           
            //}
            if (dataGridView1.CurrentRow.DataBoundItem is CuentaBancaria cuentaSeleccionada)
            {
                if (double.TryParse (txtmonto.Text, out double saldo))
                {
                    // Llama al método RealizarDeposito para realizar el depósito en la cuenta seleccionada.
                    Principal.RealizarDeposito (cuentaSeleccionada, saldo);
                }
                else
                {
                    // Manejar la situación en la que el monto ingresado no es un número válido.
                    MessageBox.Show ("Ingrese un monto de depósito válido.");
                }
            }
            else
            {
                // Mostrar un mensaje de error o manejar la situación de cuenta no seleccionada.
                MessageBox.Show ("Por favor, seleccione una cuenta bancaria válida.");
            }


            ActualizarDataGridView ();

            MessageBox.Show ("La Operación se ha realizado con éxito!!");
        }






        
    }

}
