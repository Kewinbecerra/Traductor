using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traductor
{
    public class Palabras
    {
        public Palabras(int id, string palabra, int id_ingles, int id_frances, int id_aleman)
        {
            Id = id;
            Palabra = palabra;
            Id_ingles = id_ingles;
            Id_frances = id_frances;
            Id_aleman = id_aleman;
        }
        public Palabras() { }
        public Palabras(int id, string palabra)
        {
            Id = id;
            Palabra = palabra;
        }

        public int Id { get; set; }
        public string Palabra { get; set; }
        public int Id_ingles { get; set; }

        public int Id_frances { get; set; }

        public int Id_aleman { get; set; }
    }

}
