using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traductor
{
    public class Palabras
    {
        private int id;
        private string palabra;
        private int? id_ingles;
        private int? id_frances;
        private int? id_aleman;

        public int? Id_ingles { get => id_ingles; set => id_ingles = value; }
        public int? Id_frances { get => id_frances; set => id_frances = value; }
        public int? Id_aleman { get => id_aleman; set => id_aleman = value; }
        public int Id { get => id; set => id = value; }
        public string Palabra { get => palabra; set => palabra = value; }
    }
}