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

namespace SistemaCriptografado
{
    /// <summary>
    /// Interaction logic for CadastroDeServico.xaml
    /// </summary>
    public partial class CadastroDeServico : Window
    {
        public CadastroDeServico()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            CadastroDeServicos cad = new CadastroDeServicos(txtServico.Text, txtUsuario.Text, txtSenha.Text);
            TratamentoDeDados.addServicoNaLista(cad);
        }
    }
}
