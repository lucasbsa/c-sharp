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
namespace LoginUsuario
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

        public void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {

            CadastroDeUsuario cadUse;
            LerGravarArquivo arq = new LerGravarArquivo(); 
           

            cadUse = new CadastroDeUsuario(textBoxUsuario.Text, textBoxSenha.Text);

            if ((arq.arquivoVazio()==1)&&(!arq.verificaUsuarioCadastrado(textBoxUsuario.Text, arq.getUsuario())))
            {
                MessageBox.Show("Usuario já está cadastrado");
            }

            else
            {
                arq.GravarArquivo(cadUse);


            }



            textBoxSenha.Clear();
                textBoxUsuario.Clear();
                
               
                  
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            CadastroDeServico cadser;
            LerGravarArquivo arq = new LerGravarArquivo();
           
            if ((arq.arquivoVazio() == 1) && (!arq.verificaUsuarioCadastrado(textBoxUsuario.Text, arq.getUsuario()))
                &&(!arq.verificaSenhaUsuarioCadastrado(textBoxSenha.Text,arq.getSenhaUsuario())))
            {
                cadser = new CadastroDeServico();
                cadser.Show();

              

                this.Close();
            }

            else
            {
                MessageBox.Show("Usuário ou senha inválido");
            }



            textBoxSenha.Clear();
            textBoxUsuario.Clear();




        }


       
    }
}
