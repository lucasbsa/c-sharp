using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classe.Cadastro;

namespace Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa(5);
            Console.WriteLine(p.addPessoas(4));
            Console.WriteLine(p.addPessoas(4));

            Console.Read();
            
        }
    }
}
