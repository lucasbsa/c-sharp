using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registradora
{
    class LerArquivo
    {
       private static string[] line;
        private static string nomeArquivoPassado;

        public static bool buscarArquivos(string NomeDoArquivo) {
             string nome = "C:\\Users\\lsantos\\Documents\\Visual Studio 2015\\Projects\\Registradora\\Registradora\\bin\\Debug\\" + NomeDoArquivo;
            string[] arquivos = Directory.GetFiles("C:\\Users\\lsantos\\Documents\\Visual Studio 2015\\Projects\\Registradora\\Registradora\\bin\\Debug\\");
            foreach (string arq in arquivos)
            {
                if (arq.Equals(nome))
                {
                    setAlteraArquivo(nome);
                    lerArquivo(); //gravando os dados em um array
                    return true;
                }
                else
                    continue;
               
            }
            return false;
        }

        public static  void setAlteraArquivo(string nome) {
            nomeArquivoPassado = nome;
        }


        public static  void lerArquivo()

        {
            line = new String[20];
            string textoFInal = "";
            int contador = 0;

            try
            {
                StreamReader STR_arquivo;
                STR_arquivo = new StreamReader("saida.txt");
                string linha;

                while ((linha = STR_arquivo.ReadLine()) != null)
                {
                    if (!linha.Equals(""))
                    {
                        ManipulacaoDeDados.adicionarProduto(ManipulacaoDeDados.criarProdutos(linha));
                        line[contador] = linha;
                        contador++;
                    }

                }

                STR_arquivo.Close();

            }
            catch (IOException e)
            {
                textoFInal = e.Message;
            }




        }


        public static void getMostrarOsDados()
        {
            foreach (string linha in line) {
                Console.WriteLine(linha);

            }
        }
    }
}
