using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Negocios
{
    class Dia
    {
        // cada dia instanciado precisamos saber o tempo disponivel para as palestras
        // precisamos ter os palestrantes e as palestras que serão dadas
        // com gets e sets 
        private int tempoParaPalestra;
        private Palestra palestra;
        private Palestrante palestrante;

        public Dia(int tempoParaPalestra, Palestra palestra, Palestrante palestrante)
        {
            this.tempoParaPalestra = tempoParaPalestra;
            this.palestrante = palestrante;
            this.palestra = palestra;
        }

        public int TempoParaPalestra
        {
            get { return tempoParaPalestra; }
            set { tempoParaPalestra = value; }
        }


        public Palestra getPalestra
        {
            get { return palestra; }
            set { palestra = value; }

        }

        public Palestra getP()
        {
            return palestra;
        }

        public Palestrante getPalestrante
        {
            get { return palestrante; }
            set { palestrante = value; }
        }




    }
}
