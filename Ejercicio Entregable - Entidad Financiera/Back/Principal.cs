using Back.Clases;
using Microsoft.EntityFrameworkCore;

namespace Back
{
    public class Principal
    {
        BancoDbContext db_context = new BancoDbContext();

       
        
            
        

        public void AgregarCliente ( Cliente cliente )
        {
            db_context.Clientes.Add (cliente);
            db_context.SaveChanges ();
        }

        public void CrearCuentaBancaria ( Cliente clienteTitular, string numeroCuenta,Tipos tipo )
        {
            CuentaBancaria newcuenta = new CuentaBancaria (numeroCuenta,clienteTitular,tipo ); 
            db_context.CuentasBancarias.Add (newcuenta);
            db_context.SaveChanges ();
        }



        public void EmitirTarjetaCredito ( string  NumeroTarjeta, Cliente Titular, decimal LimiteCredito, decimal Saldo )
        {
               TarjetaCredito tarjeta = new TarjetaCredito(NumeroTarjeta, Titular,LimiteCredito,Saldo);
            db_context.TarjetasCredito.Add (tarjeta);
            db_context.SaveChanges ();


        }

        public void RealizarDeposito ( int cuentaId, decimal monto )
        {
                    var cuenta = db_context.CuentasBancarias.FirstOrDefault (c => c.Id == cuentaId);
                    if (cuenta != null)
                    {
                        cuenta.Saldo += monto;
                        db_context.SaveChanges ();
                    }

            

        }



        public void RealizarExtraccion ( decimal Monto, int IdCuenta )
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


        public void RealizarTransferencia ( int cuentaOrigenId, int cuentaDestinoId, decimal monto )
        {
            var cuentaOrigen = db_context.CuentasBancarias.Find(cuentaOrigenId);
            var cuentaDestino = db_context.CuentasBancarias.Find (cuentaDestinoId);

            if (cuentaOrigen != null && cuentaDestino != null && cuentaOrigen.Saldo >= monto)
            {
                cuentaOrigen.Saldo -= monto;
                cuentaDestino.Saldo += monto;
                db_context.SaveChanges ();
            }
        }

        public void PagarTarjetaCredito ( int tarjetaId, decimal monto )
        {
            var tarjeta = db_context.TarjetasCredito.Find (tarjetaId);

            if (tarjeta != null && tarjeta.Estado == Estados.Activa && tarjeta.SaldoDisponible >= monto)
            {
                tarjeta.SaldoDisponible -= monto;
                db_context.SaveChanges ();
            }
        }












    }
}