using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Negocios
{
    class Agenda
    {
        // 6hrs de palestra por dia
        // dois dias de palestras 12hrs
        // sessao de debate nao pode comecar antes das 16hrs e nem depois das 17hrs
        // Agenda quando é criada precisamos colocar o dia
        // 
        private ArrayList<Dia> agenda;
        

        public Agenda()
        {
            agenda = new ArrayList<Dia>();
           
        }

        public bool adicionarDiaNaAgenda(Dia dia) {
            if (DistribuicaoDePalestrantes.districuiPalestrante(dia))
            {
                agenda.Add(dia);
                return true;

            }

            else
                return false;


        }

        public void getAgenda()
        {

            foreach (Dia dia in agenda)
                      Console.WriteLine(dia.getPalestrante.NomePalestrante+" "+dia.getPalestra.NomePalestra);
            
               
        }

       




       

        


        
              


        




    }
}
