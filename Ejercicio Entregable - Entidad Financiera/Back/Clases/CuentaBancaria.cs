using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class CuentaBancaria
    {
        public CuentaBancaria ( string nroCuenta, Cliente titular, Tipos tipo )
        {
            NumeroCuenta = nroCuenta;
            ClienteTitular = titular;
            Saldo = 0;
            Tipo = tipo;
        }

        public int Id { get; set; }

        public string NumeroCuenta { get; set; }

        public decimal Saldo { get; set; }

        public Tipos Tipo { get; set; }

        public Cliente ClienteTitular { get; set; }

    }
}
