using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class TarjetaCredito
    {
        public TarjetaCredito ( string nrotarjeta, Cliente titular, decimal limiteCredito, decimal saldo )
        {
            NumeroTarjeta = nrotarjeta;
            Titular = titular;
            LimiteCredito = limiteCredito;
            Estado = Estados.Activa;
            SaldoDisponible = saldo;
            MontoDeuda = 0;
        }

        public int Id { get; set; }

        public string NumeroTarjeta { get; set; }

        public decimal LimiteCredito { get; set; }

        public decimal SaldoDisponible { get; set; }

        public Estados Estado { get; set; }

        public decimal MontoDeuda { get; set; }

        public Cliente Titular { get; set; }

    }
}
