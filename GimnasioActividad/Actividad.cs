using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioActividad
{
    internal class Actividad
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String sala { get; set; }
        public String desripcion { get; set; }

        public Actividad() { 
        
        }

        public Actividad(int id, string nombre, string sala, string desripcion)
        {
            this.id = id;
            this.nombre = nombre;
            this.sala = sala;
            this.desripcion = desripcion;
        }
    }
}
