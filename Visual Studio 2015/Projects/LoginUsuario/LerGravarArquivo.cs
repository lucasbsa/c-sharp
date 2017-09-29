using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections;



namespace LoginUsuario
{
    class LerGravarArquivo
    {

        String[] usuario;
        String[] line;
        int contador = 0;
        ArrayList listaServico = new ArrayList();

        

        public void adicionarArquivoNaLista(string linha)
        {
            listaServico = new ArrayList();
            listaServico.Add(linha);
            contador++;
        }

       

        public void criptografarArquivo()
        {
            if (arquivoVazio() != 0)
            {

                StreamReader STR_arquivo;
                STR_arquivo = new StreamReader("saida.txt");
                String linha = STR_arquivo.ReadLine();
                String userCrip = Criptografia.Encrypt(linha);
                STR_arquivo.Close();

                using (System.IO.StreamWriter file = new System.IO.StreamWriter("saida.txt", true))
                    {
                       
                        file.WriteLine(userCrip);
                        file.Close();

                    }



            }
        }


        public void GravarArquivo(CadastroDeUsuario use) {
            Stream saida;
            StreamWriter escritor;
            String nome = use.getNomeDoUsuario() + ";" + use.getSenha();
            saida = File.Open("saida.txt", FileMode.Create);
            escritor = new StreamWriter(saida);
            MessageBox.Show("Cadastra foi feito!");
            escritor.WriteLine(nome);
            escritor.Close();
            saida.Close();


        }






       /* public void lerArquivo()

        {
            line = new String[20];
            string textoFInal ="";
            int contador =0;

            try{
                StreamReader STR_arquivo;
                STR_arquivo = new StreamReader("saida.txt");
                string linha;

                while ((linha = STR_arquivo.ReadLine())!= null) {
                    line[contador] = linha;
                    contador++;
                            
                }

                STR_arquivo.Close();

            }
            catch (IOException e) {
                textoFInal = e.Message;
            }

            
        }

        public string getLinhaArquivoLogin() {
            String nome = line[0];
            return nome;

        }*/

        public int arquivoVazio()
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
        

        public string getUsuario()
        {

            if (arquivoVazio() == 1)
            {
                string textoFInal = "";
                string linha = "";

                try
                {
                    StreamReader STR_arquivo;
                    STR_arquivo = new StreamReader("saida.txt");
                    linha = STR_arquivo.ReadLine();
                    STR_arquivo.Close();

                }
                catch (IOException e)
                {
                    textoFInal = e.Message;

                }

                usuario = new String[2];
                String[] sep = linha.Split(';');
                usuario[0] = sep[0];
                String nomeUsuario = usuario[0];
                return nomeUsuario;


            }

            else
                return null;
        }


        public string getSenhaUsuario()
        {

            if (arquivoVazio() == 1)
            {
                string textoFInal = "";
                string linha = "";

                try
                {
                    StreamReader STR_arquivo;
                    STR_arquivo = new StreamReader("saida.txt");
                    linha = STR_arquivo.ReadLine();
                    STR_arquivo.Close();

                }
                catch (IOException e)
                {
                    textoFInal = e.Message;

                }

                usuario = new String[2];
                String[] sep = linha.Split(';');
                usuario[0] = sep[1];
                String nomeSenha = usuario[0];
                return nomeSenha;


            }

            else
                return null;
        }

        public Boolean verificaUsuarioCadastrado(String nome, String useCad) {
            if (nome.Equals(useCad))
                return false;
            else
                return true;
        }

        public Boolean verificaSenhaUsuarioCadastrado(String nome, String useCad)
        {
            if (nome.Equals(useCad))
                return false;
            else
                return true;
        }



        public String usuarioCadastrado(CadastroDeUsuario cadUse) {
            return cadUse.getNomeDoUsuario();
        }

        public String senhaCadastrada(CadastroDeUsuario cadUse) {
            return cadUse.getNomeDoUsuario();
        }


       public void cadastrarServicos(String servico, String usuario, string senha) {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("saida.txt", true))
            {
                String serv = servico+";"+usuario + ";" + senha;
                adicionarArquivoNaLista(serv);
               // String encrypt = Criptografia.Encrypt(serv);
                file.WriteLine(serv);
                file.Close();
            }
            
        }

        public void removeDaLista(String servRemover)
        {
            foreach (String linha in listaServico)
            {
                if (linha.Equals(servRemover)){
                    listaServico.Remove(linha);
                }

            }
        }

        public void gravandoDadosDaLista() {

        }


        public string getNomeServico(String nome)
        {
            StreamReader STR_arquivo = new StreamReader("saida.txt");
            String nomeServico = "";
            if (arquivoVazio() == 1)
            {
                string linha = "";

                try
                {
                    
                    linha = STR_arquivo.ReadLine();
                    while ((linha = STR_arquivo.ReadLine()) != null)
                    {
                        nomeServico = "";
                        usuario = new String[2];
                        String[] sep = linha.Split(';');
                        usuario[0] = sep[0];
                        usuario[1] = sep[1];

                        nomeServico = usuario[0];
                        String nomeUsuario = usuario[1];
                        if (nomeServico.Equals(nome)||nomeUsuario.Equals(nome))
                        {
                            STR_arquivo.Close();
                            return nomeServico;
                            // coloquei agora
                        }
                        else
                            continue;
                    }

                    STR_arquivo.Close();
                    // coloquei agora

                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message);
                }




            }
            STR_arquivo.Close();

            return " " ;



        }



        public String getNomeUsuario(string nomeUsu)
        {

            StreamReader STR_arquivo = new StreamReader("saida.txt");
            String nomeUsuario = "";
                if (arquivoVazio() == 1)
            {
                string linha = "";

                try
                {
                   
                    linha = STR_arquivo.ReadLine();
                    while ((linha = STR_arquivo.ReadLine()) != null)
                    {
                        nomeUsuario = " ";
                        usuario = new String[2];
                        String[] sep = linha.Split(';');
                        usuario[0] = sep[0];
                        usuario[1] = sep[1];

                        String nomeServico = usuario[0];
                        nomeUsuario = usuario[1];
                        if (nomeUsuario.Equals(nomeUsu)||nomeServico.Equals(nomeUsu))
                        {
                            STR_arquivo.Close();
                            return nomeUsuario;
                            // coloquei agora
                        }
                        else
                            continue;
                    }

                    STR_arquivo.Close();
                    // coloquei agora

                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            STR_arquivo.Close();

            return "";


        }


        public String getNomeUsuarioServ(string nomeSer)
        {

            StreamReader STR_arquivo = new StreamReader("saida.txt");
            String nomeUsuario = "";
            if (arquivoVazio() == 1)
            {
                string linha = "";

                try
                {

                    linha = STR_arquivo.ReadLine();
                    while ((linha = STR_arquivo.ReadLine()) != null)
                    {
                        nomeUsuario = " ";
                        usuario = new String[2];
                        String[] sep = linha.Split(';');
                        usuario[0] = sep[0];
                        usuario[1] = sep[1];

                        String nomeServico = usuario[0];
                        nomeUsuario = usuario[1];
                        if (nomeUsuario.Equals(nomeSer) || nomeServico.Equals(nomeSer))
                        {
                            STR_arquivo.Close();
                            return nomeUsuario;
                            // coloquei agora
                        }
                        else
                            continue;
                    }

                    STR_arquivo.Close();
                    // coloquei agora

                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            STR_arquivo.Close();

            return "";


        }



        public String getSenhaDoServico(string nomeServ)
        {


            StreamReader STR_arquivo = new StreamReader("saida.txt");
            String senhaDoServ = "";
            String nomeServico = "";
            string nomeUsuario = "";
            if (arquivoVazio() == 1)
            {
                string linha = "";

                try
                {
                    
                    linha = STR_arquivo.ReadLine();
                    while ((linha = STR_arquivo.ReadLine()) != null)
                    {
                        senhaDoServ = "";
                        nomeServico = "";
                        nomeUsuario = "";
                        usuario = new String[3];
                        String[] sep = linha.Split(';');
                        usuario[0] = sep[0];
                        usuario[1] = sep[1];
                        usuario[2] = sep[2];

                        nomeServico = usuario[0];
                        nomeUsuario = usuario[1];
                        senhaDoServ = usuario[2];
                        if ( nomeUsuario.Equals(nomeServ)|| nomeServico.Equals(nomeServ))
                        {
                            STR_arquivo.Close();
                            return senhaDoServ;
                            // coloquei agora
                        }
                        else
                            continue;
                    }

                    STR_arquivo.Close();
                    // coloquei agora

                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message);
                }

            }
            STR_arquivo.Close();

            return "";


        }

        public void removerServico(String nomeServico)
        {
            String senhaSer = getSenhaDoServico(nomeServico);
            string serv = getNomeServico(nomeServico);
            string usuario = getNomeUsuarioServ(nomeServico);
            String removerServ = serv +";"+ usuario+";" + senhaSer;
            using (StreamReader reader = new StreamReader("saida.txt"))
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    string line = null;
                    string n = nomeServico;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (String.Compare(line,removerServ) == 0)
                            continue;

                        writer.WriteLine(line);

                    }
                    writer.Close();

                }
                reader.Close();

            }

            //Deleta o arquivo original
            File.Delete("saida.txt");
            //Copia o arquivo modificado, com o mesmo nome do arquivo original
            File.Copy("output.txt", "saida.txt");
            //Exclui um dos arquivos novos, já que este está duplicado.
            File.Delete("output.txt");

           


        }


        public string getLogin(String login) {
            usuario = new String[2];
            String[] sep = login.Split(';');
            usuario[0] = sep[0];
            usuario[1] = sep[1];

            String loginCadastrado = usuario[0];
            String senhaLogin = usuario[1];

            return loginCadastrado;
           

        }
    }
}
