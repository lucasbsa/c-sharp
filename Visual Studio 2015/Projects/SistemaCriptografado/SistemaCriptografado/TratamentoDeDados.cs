using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCriptografado
{
    class  TratamentoDeDados
    {
        // pegar e gravar os dados de usuario em uma lista de usuarios

        static String[] listaDeUsuario = new String[1];
        public static ArrayList  listaServicos = new ArrayList();

        public static void addUsuario(String login) {
            listaDeUsuario[0] =login;
        }

        public static void addServicoNaLista(CadastroDeServicos cad) {
            listaServicos.Add(cad);
        }

        public static void gravarUsuarioNoArquivo()
        {
            String loginDoArray = listaDeUsuario[0];
            String linhaCrip = Criptografia.Encrypt(loginDoArray);
            Dados.GravarArquivo(linhaCrip);
        }


        public static Boolean usuarioExistente(String login, String senha) {
            if (Dados.getLogin().Equals(login) && Dados.getSenha().Equals(senha))
                return true;
            else
                return false;
        }




    }
}
