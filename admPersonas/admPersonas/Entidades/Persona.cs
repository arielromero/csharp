using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admPersonas.Entidades
{
    class Persona
    {
        int id;
        string nombre;
        string apellido;
        DateTime fechanacimiento;
        int nro_documento;

        public Persona(int id, string nombre, string apellido, DateTime fechanacimiento, int nro_documento)
        {
            this.id = id;
            this.apellido = apellido;
            this.nombre = nombre;
            this.fechanacimiento = fechanacimiento;
            this.nro_documento = nro_documento;
        }
    }
}
