using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Back.Clases
{
    public class CuentaBancaria
    {
        



        [Key] public string? NumeroCuenta { get; set; }

        public double? Saldo { get; set; }
        public Cliente? Titular_Cuenta { get; set; }

        public string? NombreTitular { get; set; }
        public Tipos? Tipo { get; set; }


    }
}
