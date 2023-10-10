using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

namespace Back.Clases
{
    public class Cliente
    {
        
       
        
       [Key] public int IdCliente { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int dni { get; set; }

        public Cliente(int ClienteId ,string nombre, string apellido, int dni)
        {
            IdCliente = ClienteId;
            Nombre = nombre;
            Apellido = apellido;
            this.dni = dni;
        }
        public Cliente(string nombre, string apellido, int dni)
        {
            // Supongamos que aquí generamos un IdCliente único, por ejemplo, utilizando algún método de generación de ID único.
           
            Nombre = nombre;
            Apellido = apellido;
            this.dni = dni;
        }


        








    }
}
