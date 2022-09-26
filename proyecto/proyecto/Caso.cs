using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    public class Caso
    {
        string codigo;
        string causa;
        string tipo;
        int heridos;
        int fallecidos;
        string descripcion;
        string nomclave;

        public Caso(string codigo, string causa, string tipo, int heridos, int fallecidos, string descripcion, string nomclave)
        {
            this.codigo = codigo;
            this.causa = causa;
            this.tipo = tipo;
            this.heridos = heridos;
            this.fallecidos = fallecidos;
            this.descripcion = descripcion;
            this.nomclave = nomclave;
        }

        public Caso()
        {
        }

    }
}
