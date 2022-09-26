using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class Sede
    {
        string codigo;
        string nombre;
        string ubicacion;

        public Sede(string codigo, string nombre, string ubicacion)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.ubicacion = ubicacion;
        }

        public Sede()
        {
        }
    }
}
