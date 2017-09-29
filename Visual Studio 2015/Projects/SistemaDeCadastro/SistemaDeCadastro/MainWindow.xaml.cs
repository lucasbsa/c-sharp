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

namespace SistemaDeCadastro
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void txt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            String login = txtLogin.Text;
            if(ControleDeDados.buscarUsuario(login) == true)
            {
                JServicos serv = new JServicos();
                serv.Show();
                    }
                
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {

            String login = txtLogin.Text;
            String senha = txtSenha.Text;

            CadastroUsuario cadaUser = new CadastroUsuario(login, senha); // cria usuario
            //GravarArquivo.GravaArquivo(cadaUser);
            ControleDeDados.inicializar(); // inicializa array de usuarios caso tenho mais de um usuario
            if (ControleDeDados.buscarUsuario(login) == false)
            {
                ControleDeDados.adicionarUsuario(cadaUser);
                MessageBox.Show("Usúario adicionado com sucesso no list");
            }
            else
                MessageBox.Show("Já está cadastrado");


        }
    }
}
