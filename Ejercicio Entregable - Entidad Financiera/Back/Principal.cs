using Back.Clases;
using Microsoft.Identity.Client;
using System.Text;



namespace Back
{
    public class Principal
    {
        public static BancoDbContext db_context = new BancoDbContext ();

        public void AgregarCliente ( Cliente cliente )                   ///CLiente
        {
            db_context.Clientes.Add (cliente);
            db_context.SaveChanges ();
        }


        public static void CrearCuentaBancaria ( Cliente Nombre, Tipos tipo ) //Metodo 1 para cuenta bancaria
        {
            CuentaBancaria newCuenta = new CuentaBancaria (Nombre, tipo);



            // Llama al método para generar el número de cuenta y asígnalo a la propiedad.
            newCuenta.NumeroCuenta = GenerarNumeroCuenta (newCuenta.dni);
            newCuenta.Titular_Cuenta = Nombre;
            newCuenta.NombreTitular = Nombre.NombreCompleto;
            newCuenta.Tipo = tipo;
            db_context.CuentasBancarias.Add (newCuenta);
            db_context.SaveChanges ();



        }




        public static void RealizarDeposito ( int IdCuenta, double saldo ) //Metodo 2 para cuenta bancaria
        {
            var cuenta = db_context.CuentasBancarias.Find (IdCuenta);
            if (cuenta != null)
            {
                cuenta.Saldo += saldo;
                db_context.SaveChanges ();
            }




        }
        private static string GenerarNumeroCuenta ( string dni )
        {

            string numeroAleatorio = new Random ().Next (1000, 9999).ToString ();

            // Combina todo para formar el número de cuenta.
            string numeroCuenta = $"{numeroAleatorio}-{dni:D4}-{numeroAleatorio}";

            return numeroCuenta;
        }



        public static void RealizarExtraccion ( double Monto, int IdCuenta ) // BUSCAR COMO MEJORARLO //Metodo 3 para cuenta bancaria
        {
            var cuenta = db_context.CuentasBancarias.Find (IdCuenta);

            if (cuenta != null)
            {
                if (Monto > 0 && Monto <= cuenta.Saldo)
                {
                    cuenta.Saldo -= Monto;
                    db_context.SaveChanges ();
                }
            }
        }




        public static void RealizarTransferencia ( int cuentaOrigenId, int cuentaDestinoId, double monto ) //Metodo 4 para cuenta bancaria
        {
            var cuentaOrigen = db_context.CuentasBancarias.Find (cuentaOrigenId);
            var cuentaDestino = db_context.CuentasBancarias.Find (cuentaDestinoId);

            if (cuentaOrigen != null && cuentaDestino != null && cuentaOrigen.Saldo >= monto)
            {
                cuentaOrigen.Saldo -= monto;
                cuentaDestino.Saldo += monto;
                db_context.SaveChanges ();
            }
        }


        public static void PagarTarjetaCredito ( int tarjetaId, double monto ) //Metodo 1 para tarjeta
        {
            var tarjeta = db_context.TarjetasDeCredito.Find (tarjetaId);

            if (tarjeta != null && tarjeta.Estado == Estados.Activa && tarjeta.Saldo >= monto)
            {
                tarjeta.Saldo -= monto;
                db_context.SaveChanges ();
            }
        }

        public static string GenerarResumenTarjeta ( int idTarjeta )      //Metodo 2 para tarjeta------ buscar como hacerlo mas simple           
        {
            TarjetaDeCredito tarjeta = db_context.TarjetasDeCredito.Find (idTarjeta);
            if (tarjeta != null)
            {
                StringBuilder ret = new StringBuilder ();

                ret.AppendLine ("Resumen de su tarjeta:");
                ret.AppendLine ("Numero de tarjeta: " + tarjeta.NumeroTarjeta);
                ret.AppendLine ("Titular: " + tarjeta.NombreTitular);
                ret.AppendLine ("Limite credito: " + tarjeta.LimiteCredito);
                ret.AppendLine ("Saldo: " + tarjeta.Saldo);
                ret.AppendLine ("Deuda: " + tarjeta.MontoDeuda);
                ret.AppendLine ("Estado: " + tarjeta.Estado);

                return ret.ToString ();
            }
            return "Error";
        }
        public static List<TarjetaDeCredito> ListaRetornarTarjetas ( )
        {
            return db_context.TarjetasDeCredito.ToList ();
        }






        public List<CuentaBancaria> MostrarCuentas ( ) // retorna los valores de cuenta - configurarlo con el form
=>      {       
            db_context.CuentasBancarias.ToList();
        }   

        // metodo para clientes o lista de titulares

        public List<Cliente> MostrarTodoslosClientes ( ) 
        {

        
            return db_context.Clientes.ToList ();
        
        
        }

        public List<TarjetaDeCredito> MostrasTarjetas ( ) 
        {


            return db_context.TarjetasDeCredito.ToList ( );
        
        
        }




    }
}