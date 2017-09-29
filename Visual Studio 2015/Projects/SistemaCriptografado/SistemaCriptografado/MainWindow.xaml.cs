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

namespace SistemaCriptografado
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            CadastroDeUsuario cad = new CadastroDeUsuario(textBoxNomeUsuario.Text, textBoxSenhaDoUsuario.Text);
            // formamos aqui a linha com ";" que vai ser colocado na lista e depois no arquivo
            String linhaUsuario = cad.getNomeDoUsuario() + ";" + cad.getSenha();
            TratamentoDeDados.addUsuario(linhaUsuario);
            TratamentoDeDados.gravarUsuarioNoArquivo();
            MessageBox.Show("Cadastro feito");
            textBoxNomeUsuario.Clear();
            textBoxSenhaDoUsuario.Clear();
            //this.Close();

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            JServicos jServ;
            Dados.lerArquivo();
            String descripLinha = Criptografia.Decrypt(Dados.getLinhaArquivoLogin());
            String linha = descripLinha;
            Dados.cadastrarLoginNaLista(linha);
            Dados.CadastrarSenhaNaLista(linha);
            String login = Dados.getLogin();
            String senha = Dados.getSenha();
            if (Dados.testaUsuario(login, senha) == true)
            {

                jServ = new JServicos();
                jServ.Show();

            }

            else
                MessageBox.Show("Usuário não tem permissão ou não está cadastrado");

            
        }
    }
}

/*
 1)  qd abre o sistema carregamos os dados do arquivo em uma lista, se o usuario for valido.
 2)  trabalhamos com as listas ate fechar o programa
 3) quando fecharmos o sistema ele salva os dados no arquivo.

    **** MOSTRAR DADOS NOS CAMPOS
    * Dados.lerArquivo();
            String descripLinha = Criptografia.Decrypt(Dados.getLinhaArquivoLogin());
            String linha = descripLinha;
            String login = Dados.getLogin(linha);
            String senha = Dados.getSenha(linha);
            textBoxNomeUsuario.Text = login;
            textBoxSenhaDoUsuario.Text = senha;
     
     */
