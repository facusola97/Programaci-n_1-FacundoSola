using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Back.Clases
{
    public class Cliente
    {
        public Cliente ( string Nombre, string Apellido, int DNI )
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
        }
       [Key] public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string? Apellido { get; set; }
        public int DNI { get; set; }
        public string? NombreCompleto { get { return Nombre + " " + Apellido; } }
    }

}
