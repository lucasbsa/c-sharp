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
using System.Windows.Shapes;
using System.IO;

namespace LoginUsuario
{
    /// <summary>
    /// Interaction logic for CadastroDeServico.xaml
    /// </summary>
    public partial class CadastroDeServico : Window
    {
        LerGravarArquivo arq = new LerGravarArquivo();
        String dadosEditados = "";

        public CadastroDeServico()
        {
            InitializeComponent();
        }

        

        private  void btnNovo_Click(object sender, RoutedEventArgs e)


        {

            adicionarServico adSer = new adicionarServico();
            adSer.ShowDialog();
            
           /* try
            {
                using (StreamReader sr = new StreamReader("saida.txt"))
                {
                    StreamReader STR_arquivo;
                    STR_arquivo = new StreamReader("saida.txt");
                    string linha;
                    linha = (linha = STR_arquivo.ReadLine());
                    textBlockTeste.Text = linha;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/
        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {


          

            string nomeServico = arq.getNomeServico(textBoxParaPesquisar.Text);
           String nomeUsuario = arq.getNomeUsuario(textBoxParaPesquisar.Text);
           String senha = arq.getSenhaDoServico(textBoxParaPesquisar.Text);

            if (nomeServico != null && nomeServico.Equals(textBoxParaPesquisar.Text))
            {
                textBoxServico.Text = nomeServico;
                textBoxUsuario.Text = nomeUsuario;
                textBoxSenha.Text = senha;
                getDadosTextBox(textBoxServico.Text,textBoxUsuario.Text,textBoxSenha.Text);

               habilitarCampos();
                textBoxParaPesquisar.Clear();


            }

            else if (nomeUsuario != null && nomeUsuario.Equals(textBoxParaPesquisar.Text))
            {
                textBoxServico.Text = nomeServico;
                textBoxUsuario.Text = nomeUsuario;
                textBoxSenha.Text = textBoxSenha.Text;
                textBoxSenha.Text = senha;
                getDadosTextBox(textBoxServico.Text, textBoxUsuario.Text, textBoxSenha.Text);


                // desabilitar os campos para nao editar
                habilitarCampos();


                textBoxParaPesquisar.Clear();

            }

            else
            {
                MessageBox.Show("Serviço não cadastrado");
                textBoxParaPesquisar.Clear();

            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            limparCampos();
          //  habilitarCampos();

        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            arq.removerServico(textBoxServico.Text);
            textBoxParaPesquisar.Clear();
            textBoxSenha.Clear();
            textBoxServico.Clear();
            //habilitarCampos();

            textBoxUsuario.Clear();
            MessageBox.Show("Serviço removido com sucesso");
        }


        private void habilitarCampos()
        {

            textBoxSenha.IsEnabled = true;
            textBoxServico.IsEnabled = true;
            textBoxUsuario.IsEnabled = true;
            btnSalvar.IsEnabled = true;
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
                 
        }

        private void getDadosTextBox(String nomeServ, String nomeUser, String senhaSer)
        {
            String editar = nomeServ;
            dadosEditados = editar;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            
            LerGravarArquivo arq = new LerGravarArquivo();
            arq.removerServico(dadosEditados);
            arq.cadastrarServicos(textBoxServico.Text, textBoxUsuario.Text,textBoxSenha.Text);
            MessageBox.Show("Cadastro alterado com sucesso!");
            limparCampos();
        }

        private void limparCampos()
        {
            textBoxParaPesquisar.Clear();
            textBoxSenha.Clear();
            textBoxServico.Clear();
            textBoxUsuario.Clear();
        }
    }
}
