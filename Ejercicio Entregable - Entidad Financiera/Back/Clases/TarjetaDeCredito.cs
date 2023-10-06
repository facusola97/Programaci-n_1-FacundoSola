using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Back.Clases
{
    public class TarjetaDeCredito
    {

        [Key] public int IdTarjeta {  get; set; }
        public int NumeroTarjeta { get; set; }
        public double LimiteCredito { get; set; }
        public double Saldo { get; set; }
        public double MontoDeuda { get; set; }
        
        public string? NombreTitular { get; set; }
        public Estados? Estado { get; set; }

        public TarjetaDeCredito(int IdTarjeta, double LimiteCredito, double Saldo)
        {
            this.IdTarjeta = IdTarjeta;
            this.LimiteCredito = LimiteCredito;
            Estado = Estados.Activa;
            this.Saldo = Saldo  ;
            MontoDeuda = 0;
        }
        public TarjetaDeCredito(double LimiteCredito, double Saldo)
        {
            this.LimiteCredito = LimiteCredito;
            Estado = Estados.Activa;
            this.Saldo = Saldo;
            MontoDeuda = 0;
        }

    }
}
