using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace domotica.Data
{
    
    public class Usuarios
    {
       
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //lo he puesto en mayusculas el DNI por convención 
        public string DNI { get; set; }
        /* esta sera la cadena donde esta almacenada la imagne dentro de nuestrapropia aplicación, esto conlleva que si borro la imagen, 
         * tengo que dejar la cadena esta vacia
         */
        public string Imagen { get; set; }
        //foreign key de la tabla aspnetusers
        public string Iduser {get;set;}

    }
}
