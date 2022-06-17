using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Modelo para el objeto actor

namespace Domain
{
    public class Actor
    {
        public string ID { get; set; }  // Identificador único del registro
        public string Nombre { get; set; } // Nombre del registro
        public DateTime  Fecha_Nacimiento { get; set; } // Fecha de nacimiento del registro
        public string Sexo { get; set; } // Sexo del registro
        public string Foto { get; set; } // Directorio de la imagen del registro
    }
}
