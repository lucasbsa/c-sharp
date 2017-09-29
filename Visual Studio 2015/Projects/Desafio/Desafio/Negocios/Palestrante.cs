using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Negocios
{
    class Palestrante
    {
       private string nomePalestrante;

        public Palestrante(string nomePalestrante) {
            this.nomePalestrante = nomePalestrante;
        }

        public string NomePalestrante{
            get { return nomePalestrante; }
            set { nomePalestrante = value; }
            }


    }
}
