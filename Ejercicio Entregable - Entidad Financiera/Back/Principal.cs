using Back.Clases;
using System.Text;




namespace Back
{
    public class Principal
    {
        BancoDbContext db_context = new BancoDbContext ();

        public void AgregarCliente ( Cliente cliente )
        {
            db_context.Clientes.Add (cliente);
            db_context.SaveChanges ();
        }

        public void CrearCuentaBancaria ( int NumeroCuenta, double saldo, string NombreTitular )
        {
            CuentaBancaria newcuenta = new CuentaBancaria (NumeroCuenta, saldo, NombreTitular);

            db_context.CuentasBancarias.Add (newcuenta);
            db_context.SaveChanges ();
        }
        public void RealizarDeposito ( int IdCuenta, double saldo )
        {
            var cuenta = db_context.CuentasBancarias.Find (IdCuenta);
            if (cuenta != null)
            {
                cuenta.Saldo += saldo;
                db_context.SaveChanges ();
            }




        }


        public void RealizarExtraccion ( double Monto, int IdCuenta ) // BUSCAR COMO MEJORARLO
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


        public void RealizarTransferencia ( int cuentaOrigenId, int cuentaDestinoId, double monto )
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


        public void PagarTarjetaCredito ( int tarjetaId, double monto )
        {
            var tarjeta = db_context.TarjetasDeCredito.Find (tarjetaId);

            if (tarjeta != null && tarjeta.Estado == Estados.Activa && tarjeta.Saldo >= monto)
            {
                tarjeta.Saldo -= monto;
                db_context.SaveChanges ();
            }
        }

        public string GenerarResumenTarjeta ( int idTarjeta )
        {
            TarjetaDeCredito tarjeta = db_context.TarjetasDeCredito.Find(idTarjeta);
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
        public List<TarjetaDeCredito> ListaRetornarTarjetas ( )
        {
            return db_context.TarjetasDeCredito.ToList ();
        }















    }
}