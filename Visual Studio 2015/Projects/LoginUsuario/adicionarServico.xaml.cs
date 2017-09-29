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

namespace LoginUsuario
{
    /// <summary>
    /// Interaction logic for adicionarServico.xaml
    /// </summary>
    public partial class adicionarServico : Window
    {
        public adicionarServico()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            LerGravarArquivo arq = new LerGravarArquivo();
            
            arq.cadastrarServicos(textBoxNomeDoServico.Text,textBoxUsuarioDoServico.Text,textBoxSenhaDoServico.Text);
            textBoxNomeDoServico.Clear();
            textBoxSenhaDoServico.Clear();
            textBoxUsuarioDoServico.Clear();
            MessageBox.Show("Serviço cadastrado");
        }
    }
}
