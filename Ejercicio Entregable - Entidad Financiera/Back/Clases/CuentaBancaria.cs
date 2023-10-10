using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back.Clases
{
    public class CuentaBancaria
    {
        
       [Key] public int IdCuenta { get; set; }

        
        public string NumeroCuenta { get; set; }

        public double Saldo { get; set; }

        
        public string NombreTitular { get; set; }

        public Tipos? Tipo { get; set; }

        public CuentaBancaria(int IdCuenta, string NumeroCuenta, double saldo, string NombreTitular)
        {
            this.IdCuenta = IdCuenta;
            this.NumeroCuenta = NumeroCuenta;
            Saldo = saldo;
            this.NombreTitular = NombreTitular;
        }

        public CuentaBancaria(string NumeroCuenta, double saldo, string NombreTitular)
        {
            this.NumeroCuenta = NumeroCuenta;
            Saldo = saldo;
            this.NombreTitular = NombreTitular;
        }

     
        
        

    }
}
