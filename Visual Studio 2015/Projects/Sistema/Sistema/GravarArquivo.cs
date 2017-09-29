using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sistema
{
    class GravarArquivo
    {
        public static void GravarArquivos(CadastroLoginDeUsuario use)
        {
            Stream saida;
            StreamWriter escritor;
            String nome = use.getUsuario() + ";" + use.getSenha();
            saida = File.Open("saida.txt", FileMode.Create);
            escritor = new StreamWriter(saida);
            MessageBox.Show("Cadastra foi feito!");
            escritor.WriteLine(nome);
            escritor.Close();
            saida.Close();


        }

    }
}
