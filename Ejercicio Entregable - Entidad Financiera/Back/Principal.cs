using Back.Clases;
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


        public static void CrearCuentaBancaria ( string NumeroCuenta, double saldo, string NombreTitular ) //Metodo 1 para cuenta bancaria
        {
            CuentaBancaria newcuenta = new CuentaBancaria ( NumeroCuenta, saldo, NombreTitular);

            db_context.CuentasBancarias.Add (newcuenta);
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
        private string GenerarNumeroCuenta ( int clienteId, Tipos tipo )
        {
          
            string tipoCuentaAbreviado = tipo.ToString ().Substring (0, 3).ToUpper ();

            // Combina el ID del cliente con un número aleatorio de 4 dígitos.
            string numeroAleatorio = new Random ().Next (1000, 9999).ToString ();

            // Combina todo para formar el número de cuenta.
            string numeroCuenta = $"{tipoCuentaAbreviado}-{clienteId:D4}-{numeroAleatorio}";

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


        public string GenerarNumeroCuenta ( int parametro )
        {

            string numeroAleatorio = new Random ().Next (1000, 9999).ToString ();

            string numeroCuenta = $"{numeroAleatorio}-{parametro:D4}-{numeroAleatorio}";

            return numeroCuenta;
        }












    }
}