using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioActividad
{
    class Cliente
    {
        public int id { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String ciudad { get; set; }
        public int telefono { get; set; }
        public Cliente()
        {

        }

        public Cliente(int id, string nombre, string apellidos, DateTime fechaNacimiento, string ciudad, int telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.ciudad = ciudad;
            this.telefono = telefono;
        }
    }


}
