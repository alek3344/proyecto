using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class Lista_escuadron
    {
        string cedula;
        string codigo;
        string nombres;
        int nbomberos;

        public Lista_escuadron(string cedula, string codigo, string nombres, int nbomberos)
        {
            this.cedula = cedula;
            this.codigo = codigo;
            this.nombres = nombres;
            this.nbomberos = nbomberos;
        }

        public Lista_escuadron()
        {
        }
    }
}
