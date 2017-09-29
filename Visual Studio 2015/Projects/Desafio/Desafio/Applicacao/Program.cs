using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.Negocios;
namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {

            Palestrante palestrante = new Palestrante("lucas");
            Palestra palestra = new Palestra("palestra A", 30, palestrante);

            // dia tem que ser array, com tributo que diminui o tempo do dia
            // quando terminar o tempo, o dia e instanciado e colocado na agenda
            // um palestrante tem uma palestra e seu tempo de duração
            // 
            Dia primeiroDia = new Dia(120, palestra, palestrante);
            Dia segundooDia = new Dia(120, palestra, palestrante);

            Agenda agenda = new Agenda();

            agenda.adicionarDiaNaAgenda(primeiroDia);
            agenda.getAgenda();
            
            Console.WriteLine("aqui");
            Console.Read();
        }
    }
}
