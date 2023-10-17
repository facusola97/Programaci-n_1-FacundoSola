using Back.Clases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Back
{
    public class Principal
    {
        public static BancoDbContextcs db_context = new BancoDbContextcs ();

        public void AgregarCliente ( Cliente cliente )                   ///CLiente
        {
            db_context.Clientes.Add (cliente);
            db_context.SaveChanges ();
        }

       

        


        public static void CrearCuentaBancaria ( Cliente Nombre, Tipos tipo, string dni ) //Metodo 1 para cuenta bancaria
        {
            CuentaBancaria newCuenta = new CuentaBancaria ();
            newCuenta.NumeroCuenta = GenerarNumeroCuenta (dni );
            newCuenta.Titular_Cuenta = Nombre;
            newCuenta.NombreTitular = Nombre.NombreCompleto;
            newCuenta.Tipo = tipo;
            newCuenta.Saldo = 0;
            db_context.CuentasBancarias.Add (newCuenta);
            db_context.SaveChanges ();



        }

        public static void EmitirTarjeta ( Cliente titular, double limite, double saldo, double montoDeuda, Estados estado )
        {
            var nuevaTarjeta = new TarjetaDeCredito
            {
                LimiteCredito = limite,
                Saldo = saldo,
                MontoDeuda = montoDeuda,
                Titular = titular,
                NombreTitular = titular.NombreCompleto,
                Estado = estado
            };

            db_context.TarjetasDeCredito.Add (nuevaTarjeta);
            db_context.SaveChanges ();
        }


        public static void RealizarDeposito ( CuentaBancaria cuentaBancaria, double saldo )
        {
            // Comprobar si hay una cuenta bancaria seleccionada
            if (cuentaBancaria != null)
            {
                // Mostrar un mensaje de error
                cuentaBancaria.Saldo += saldo;
                db_context.SaveChanges ();

            }

            // Realizar el depósito
           
        }


        public static string GenerarNumeroCuenta ( string dni )
        {

            string numeroAleatorio = new Random ().Next (100000, 999999).ToString ();

            
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
            var tarjeta = db_context.TarjetasDeCredito.Find (idTarjeta);
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
        {
            return db_context.CuentasBancarias.ToList ();



        }

        // metodo para clientes o lista de titulares

        public List<Cliente> MostrarTodoslosClientes ( )
        {


            return db_context.Clientes.ToList ();


        }

        public List<TarjetaDeCredito> MostrasTarjetas ( )
        {
            return db_context.TarjetasDeCredito.ToList ();


        }

        public static List<Tipos> mostrartipos ( )
        {
            List<Tipos> tipos = new List<Tipos> ();

            // Agregar los valores del enum a la lista.
            tipos.Add (Tipos.CajaAhorro);
            tipos.Add (Tipos.CuentaCorriente);

            return tipos;
        }

        public static List<string> ObtenerNumerosCuenta ( )
        {
            // Obtener la lista de cuentas bancarias
            var cuentasBancarias = db_context.CuentasBancarias;

            // Crear una lista de números de cuenta
            var numerosCuenta = new List<string> ();

            // Iterar por la lista de cuentas bancarias y verificar que los números de cuenta no sean nulos ni vacíos
            foreach (var cuentaBancaria in cuentasBancarias)
            {
                if (!string.IsNullOrWhiteSpace (cuentaBancaria.NumeroCuenta))
                {
                    // Agregar el número de cuenta a la lista
                    numerosCuenta.Add (cuentaBancaria.NumeroCuenta);
                }
            }

            // Devolver la lista de números de cuenta
            return numerosCuenta;
        }



    }

}


