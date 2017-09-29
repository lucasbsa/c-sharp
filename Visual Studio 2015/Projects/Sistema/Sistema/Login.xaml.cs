﻿using System;
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

namespace Sistema
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

        private void btnCadastrarLogin_Click(object sender, RoutedEventArgs e)
        {
            String usuario = txtUsuarioLogin.Text;
            String senha = txtUsuarioLogin.Text;

            CadastroLoginDeUsuario user = new CadastroLoginDeUsuario(usuario,senha);

            GravarArquivo.GravarArquivos(user);
        }
    }
}
