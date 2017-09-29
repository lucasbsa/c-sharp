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
    class  GravarArquivo
    {
        public static void GravaArquivo(CadastroUsuario use)
        {
            Stream saida;
            StreamWriter escritor;
            String nome = use.getLogin() + ";" + use.getSenha();
            //  String nomeCript = Criptografia.Encrypt(nome);
            saida = File.Open("saida.txt", FileMode.Create);
            escritor = new StreamWriter(saida);
            MessageBox.Show("Cadastra foi feito!");
            escritor.WriteLine(nome);
            escritor.Close();
            saida.Close();


        }

    }
}
