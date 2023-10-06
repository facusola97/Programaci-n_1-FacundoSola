using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Back.Clases;
using Microsoft.EntityFrameworkCore;

namespace Back
{
    public class BancoDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaBancaria> CuentasBancarias { get; set; }
        public DbSet<TarjetaDeCredito> TarjetasDeCredito { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-BAI14A1;database=BDFinaciero;trusted_connection=true;Encrypt=False");
        }
    }




}
