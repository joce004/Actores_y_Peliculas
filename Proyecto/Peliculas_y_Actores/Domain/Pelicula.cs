using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Modelo para el objeto película

namespace Domain
{
    
    public class Pelicula
    {
        public string ID { get; set; } // Identificador único del registro
        public string Titulo { get; set; }  // Titulo del registro
        public string Genero { get; set; } // Genero del registro
        public DateTime Fecha_Estreno { get; set; } // Fecha de estreno del registro
        public string Foto { get; set; } // Directorio de la imagen del registro
    }
}
