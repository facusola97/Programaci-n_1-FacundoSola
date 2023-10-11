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
        public string dni { get; set; }
        
        public Cliente(int ClienteId ,string nombre, string apellido, string dni)
        {
            IdCliente = ClienteId;
            Nombre = nombre;
            Apellido = apellido;
            this.dni = dni;
        }
        public Cliente(string nombre, string apellido, string dni)
        {
           
            Nombre = nombre;
            Apellido = apellido;
            this.dni = dni;
        }


       public string NombreCompleto { get { return Nombre + " " + Apellido; } }


        public Cliente ( string dni )
        {
            


            this.dni = dni;
        }


        public Cliente (  )
        {
            


            
        }


    }
}
