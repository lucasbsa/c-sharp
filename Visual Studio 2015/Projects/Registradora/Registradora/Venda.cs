using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registradora
{
    class Venda
    {

        static void Main(string[] args)
        {
            Console.WriteLine("nao consgeue ");

            LerArquivo.lerArquivo();
            ManipulacaoDeDados.mostrarProdutos();

            int opcao;
            string qtd, codprod = "";
            int qtdInt;
            do
            {
                Console.WriteLine("1 - Fazer venda");
                Console.WriteLine("2 - Total vendido no dia");
                Console.WriteLine("3 - Gerar relatório de vendas ");
                Console.WriteLine("4 - Iniciar venda e finalizar ");
                Console.WriteLine("0 - Sair ");
                Console.Write("Escolha uma opção: ");
                string entrada = Console.ReadLine();
                bool result = int.TryParse(entrada, out opcao);

                switch (opcao) {
                    case 1:
                        Console.Write("Digite o código do produto: ");
                        string codigo = Console.ReadLine();
                        Console.Write("Quantidade vendida: ");
                        string quantidade = Console.ReadLine();          
                        // bool quantParse = int.TryParse(quantidade, out quantidadeParte);
                        int quantidadeParte = int.Parse(quantidade);
                        Console.WriteLine(quantidadeParte);
                        double valorDaVenda = ManipulacaoDeDados.Venda(codigo, quantidadeParte);
                       // double valorDaVenda = ManipulacaoDeDados.Venda(codigo, quantidadeParte);
                        Console.WriteLine("Total da venda: "+valorDaVenda);
                        Console.WriteLine("-------------------------------------------------------");

                        break;


                    case 2:
                        Console.WriteLine("Total vendido no dia: " + ManipulacaoDeDados.totalVendidoNoDia());
                        Console.WriteLine("-------------------------------------------------------");
                        break;

                    case 3:
                        ManipulacaoDeDados.getRelatorio();
                        Console.WriteLine("-------------------------------------------------------");
                        break;

                    case 4:
                                          
                        int op;
                        Console.WriteLine("1 - Iniciar venda ");

                        do {
                           
                            
                            string opcaoEntrada = Console.ReadLine();
                            op = int.Parse(opcaoEntrada);
                            switch (op) {
                                
                                case 1:
                                    Console.WriteLine(" Digite o código do produto: ");
                                    codprod = Console.ReadLine();
                                    Console.WriteLine("Digite a quantidade vendida ");
                                    qtd = Console.ReadLine();
                                    qtdInt = int.Parse(qtd);
                                    double valoreDaVenda = ManipulacaoDeDados.Venda(codprod, qtdInt);

                                    break;


                                case 0:
                                    
                                    Console.WriteLine("Cupom finalizado!");

                                    //double valoresDaVenda = ManipulacaoDeDados.Venda(codprod, ManipulacaoDeDados.getQuantidadeVendida());
                                    ManipulacaoDeDados.getRelatorioVendas();
                                    Console.WriteLine("Total da venda: " + ManipulacaoDeDados.getValorDaVenda());
                                    break;
                            }
                            Console.WriteLine("0 - Finalizar venda");
                        } while (op != 0);

                        break;

                    default :
                        Console.WriteLine("Sair do sistema");
                        break;
                }
            }
            while (opcao != 0);

            Console.Read();
        }





    }
}
