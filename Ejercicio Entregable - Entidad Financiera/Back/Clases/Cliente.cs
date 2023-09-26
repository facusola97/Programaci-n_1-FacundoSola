using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class Cliente
    {
        public Cliente ( string nombre, string apellido, string dni )
        {  
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;  
        
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }


    }
}
