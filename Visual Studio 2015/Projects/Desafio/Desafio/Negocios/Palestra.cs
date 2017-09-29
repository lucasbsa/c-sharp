using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Negocios
{
    class Palestra
    {
        private string nomePalestra;
        private int tempoDePalestra;
        private Palestrante palestrante;

        public Palestra(string nomePalestra, int tempoDePalestra, Palestrante palestrante) {
            this.nomePalestra = nomePalestra;
            this.tempoDePalestra = tempoDePalestra;
            this.palestrante = palestrante;
        }


        public int TempoDePalestra
        {
            get { return tempoDePalestra; }
            set { tempoDePalestra = value; }
        }

        public string NomePalestra
        {
            get { return nomePalestra; }
            set { nomePalestra = value; }
        }

        public Palestrante NomePalestrante
        {
            get { return palestrante; }
            set { palestrante = value; }
        }


        



    }
}
