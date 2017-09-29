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
    /// Interaction logic for JPesquisarServicos.xaml
    /// </summary>
    public partial class JPesquisarServicos : Window
    {
        public JPesquisarServicos()
        {
            InitializeComponent();
        }

        private void btnPesquisarServico_Click(object sender, RoutedEventArgs e)
        {
            String nomeServico = txtNomeDoServicoPesquisar.Text;
            if (ControleDeDados.getBuscarServico(nomeServico) != null)
            {
                CadastroDeServicos ser = ControleDeDados.getBuscarServico(nomeServico);
                txtNomeServico.Text = ControleDeDados.getNomeServicoCadastrado(ser);
                txtLoginServico.Text = ControleDeDados.getLoginServicoCadastrado(ser);
                txtSenhaServico.Text = ControleDeDados.getSenhaServicoCadastrado(ser);
            }

            else
                MessageBox.Show("Serviço não cadastrado");
        }
    }
}
