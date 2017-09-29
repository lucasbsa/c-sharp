using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaCriptografado
{

    class Dados
    {

       
        static  String[] usuario  = new String[2];

        static String[] line;
        public static List<String> listaServico = new List<String>();
        public static int contador = 0;
        

        public static void GravarArquivo(String nome)
        {
            Stream saida;
            StreamWriter escritor;
            //  String nomeCript = Criptografia.Encrypt(nome);
            saida = File.Open("saida.txt", FileMode.Create);
            escritor = new StreamWriter(saida);
          //  MessageBox.Show("Cadastra foi feito!");
            escritor.WriteLine(nome);
            escritor.Close();
            saida.Close();
        }
        // GRAVA OS SERVICOS NA LIST
        public static void gravarServicoNaLista(CadastroDeServicos cad) {
            String linha = cad.getNomeDoServico() + cad.getUsuarioDoServico()+ cad.getSenhaDoServico();
            listaServico.Add(linha);
            contador++;
        }
        // LE OS SERVICOS DO ARQUIVO
        public static void lerServicosDoArquivo(String servicos) {

            StreamReader STR_arquivo;
            STR_arquivo = new StreamReader("saida.txt");
            string linha = STR_arquivo.ReadLine();
            //STR_arquivo.Close(); testar

            while ((linha = STR_arquivo.ReadLine()) != null) {
                listaServico.Add(linha);
            }
            STR_arquivo.Close();
        }
        // GRAVA OS ELEMENTOS DO LIST EM UM ARQUIVO CRIPTOGRAFADO
        public static void gravarArquivoCriptografado() {
            Stream saida;
            StreamWriter escritor;
            //  String nomeCript = Criptografia.Encrypt(nome);
            saida = File.Open("saida.txt", FileMode.Create);
            escritor = new StreamWriter(saida);
            //  MessageBox.Show("Cadastra foi feito!");

            while (contador > 0) {
                foreach (String linha in listaServico) {
                    String linhaCrip = Criptografia.Encrypt(linha);
                    escritor.WriteLine(linhaCrip);                   
                }              
            }
            escritor.Close();
            saida.Close();
        }
        public static void lerArquivo()
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
                    line[contador] = linha;
                    contador++;
                }
                STR_arquivo.Close();
            }
            catch (IOException e)
            {
                textoFInal = e.Message;
            }
        }
        public static  int arquivoVazio()
        {
            StreamReader STR_arquivo;
            STR_arquivo = new StreamReader("saida.txt");
            string linha = STR_arquivo.ReadLine();
            STR_arquivo.Close();
            if ((linha == null))
            {
                return 0;
            }
            else
                return 1;
        }

        public static string getLinhaArquivoLogin()
        {
            String nome = line[0];
            return nome;
        }

        public static void cadastrarLoginNaLista(String linha) { 
           // usuario = new String[2];
            String[] sep = linha.Split(';');
            String nome = sep[0];
            usuario[0] = nome;
           // String nomeUsuario = usuario[0];
           // return nomeUsuario;

        }
        public static void CadastrarSenhaNaLista(String linha)
        {
            //usuario = new String[2];
            String[] sep = linha.Split(';');
            String senha = sep[1];
            usuario[1] = senha;
           // String senhaUsuario = usuario[1];
           // return senhaUsuario;

        }
        public static String getLogin() {
            String login = usuario[0];
            return login;
        }

        public static String getSenha()
        {
            String senha = usuario[1];
            return senha;
        }
        public static Boolean testaUsuario(String nome, String senha) {
            if (getLogin().Equals(nome) && getSenha().Equals(senha))
                   return true;
            else
                return false;

        }
    }
}
