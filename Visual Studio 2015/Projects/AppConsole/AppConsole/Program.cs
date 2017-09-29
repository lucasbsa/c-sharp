using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados dados = new Dados();
            
                dados.ShowDialog(); 
        
            Console.WriteLine("teste");
            Console.Read();

            
        }
    }
}
