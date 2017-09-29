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

namespace SistemaDeCadastro
{
    /// <summary>
    /// Interaction logic for JServicos.xaml
    /// </summary>
    public partial class JServicos : Window
    {
        public JServicos()
        {
            InitializeComponent();
        }


     

        private void Cadastrar_Click_1(object sender, RoutedEventArgs e)
        {
            CadastroDeServicos cad = new CadastroDeServicos(txtLogin.Text, txtNomeServico.Text, txtSenha.Text);
            ControleDeDados.adicionarServico(cad);
            limparCampos();

        }


        public void limparCampos()
        {
            txtLogin.Clear();
            txtNomeServico.Clear();
            txtSenha.Clear();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            JPesquisarServicos jPesquisar = new JPesquisarServicos();
            jPesquisar.Show();

        }
    }
}
