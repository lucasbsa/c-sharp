using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace SistemaDeCadastro
{
    class ControleDeDados
    {
       

        private static CadastroUsuario[] arrayCadastroUsuario;
        private static CadastroDeServicos[] arrayCadastroDeServicos;
        private static  int contaUsuario = 0;
        private static int contadorServicos = 0;

        public static void inicializar() {

            if (arrayCadastroUsuario == null)
            {
                arrayCadastroUsuario = new CadastroUsuario[10];
                arrayCadastroDeServicos = new CadastroDeServicos[100];
            }
            else
                MessageBox.Show("Já existe!");
        }

        public static void adicionarUsuario(CadastroUsuario user) {

            if (getContaUsuario() == 0)
            {
                arrayCadastroUsuario[contaUsuario] = user;
                contaUsuario++;
            }

            else if (getContaUsuario() < 9)
            {
                arrayCadastroUsuario[contaUsuario] = user;
                contaUsuario++;
            }
            else
                MessageBox.Show("Não foi cadastro! ");

        }

        public static int getContaUsuario() {
            return contaUsuario;
        }

        public static Boolean buscarUsuario(String login) {
         
            for(int i = 0;i<getContaUsuario();i++) {
              // String nome = arrayCadastroUsuario[i].getLogin();
                if (arrayCadastroUsuario[i].getLogin().Equals(login))
                    return true;
                else
                    continue;               
            }
            return false;
        }


        public static int getContadorServicos() { return contadorServicos; }


        public static void adicionarServico(CadastroDeServicos cadServ) {
            if (getContadorServicos() == 0)
            {
                arrayCadastroDeServicos[contadorServicos] = cadServ;
                contadorServicos++;
            }

            else if (getContadorServicos() < 99)
            {
                arrayCadastroDeServicos[contadorServicos] = cadServ;
                contadorServicos++;
            }
            else
                MessageBox.Show("Não foi cadastro! ");
        }

        public static CadastroDeServicos getBuscarServico( String nomeServico) {
            for (int i = 0; i < getContadorServicos(); i++)
            {
                String nome = arrayCadastroDeServicos[i].getNomeServico();
                if (arrayCadastroDeServicos[i].getNomeServico().Equals(nomeServico))
                    return arrayCadastroDeServicos[i];
                else
                    continue;
            }
            return null;
        }

        public static String getNomeServicoCadastrado(CadastroDeServicos cadasSer) {
            return cadasSer.getNomeServico();
        }

        public static String getLoginServicoCadastrado(CadastroDeServicos cadasSer)
        {
            return cadasSer.getLogin();
        }

        public static String getSenhaServicoCadastrado(CadastroDeServicos cadasSer)
        {
            return cadasSer.getSenhaServico();
        }








    }
}
