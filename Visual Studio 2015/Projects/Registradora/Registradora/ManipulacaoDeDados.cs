using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Registradora
{
    class ManipulacaoDeDados
    {
        private static Produto[] produtos;
        private static int contadorDeProdutos;
        private static double totalVendidoDia;
        private static double valorDaVenda;
        private static List<RelatorioVendas> listaRelatorio;
        private static int quantidadeDeProdutos;
        public static bool inicializarArrayProdutos() {
            if (produtos == null)
            {
                produtos = new Produto[50];
                contadorDeProdutos = 0;
                totalVendidoDia = 0;
                listaRelatorio = new List<RelatorioVendas>();
                quantidadeDeProdutos = 0;
                valorDaVenda = 0;
                return true;
            }
            else if (produtos != null)
                return true;

            else
                return false;
        }

        public static Produto criarProdutos(string linha) {
            if (linha != "")
            {
                string[] atributosprodutos = new string[3];
                String[] sep = linha.Split(';');
                string codProduto = sep[0];
                string nomeProduto = sep[1];
                string valorProduto = sep[2];
                double valorAlterado = Convert.ToDouble(valorProduto);
                Produto produto = new Produto(codProduto, nomeProduto, valorAlterado);
                return produto;
            }

            else return null;
        }

        public static int getSize() {
            return contadorDeProdutos;
        }

        public static bool adicionarProduto(Produto prod) {
            if (inicializarArrayProdutos() == true)
            {
                if (prod != null)
                {
                    if (contadorDeProdutos == 0)
                    {
                        produtos[0] = prod;
                        contadorDeProdutos++;
                        return true;
                    }

                    else if (contadorDeProdutos < 50)
                    {
                        produtos[contadorDeProdutos] = prod;
                        contadorDeProdutos++;
                        return true;
                    }

                    else
                        return false;
                }
            }

            return false;
                
        }

        public static void mostrarProdutos()
        {
            for(int i = 0; i < ManipulacaoDeDados.getSize(); i++)
            {
                Console.WriteLine("Informações do Produto "+produtos[i].getNome()+"-"+produtos[i].getValor()+ "-" + produtos[i].getCodigo());
            }
        }

        public static Produto getProduto(int indice) {
            return produtos[indice];
        }

        public static int buscarProduto(string codigo)
        {
            for (int i=0;i<ManipulacaoDeDados.getSize();i++) {
                if (produtos[i].getCodigo().Equals(codigo))
                {
                    return i;
                }

                else
                    continue;
            }

            return -1;
        }

        public static bool removerProduto(int indice)
        {

            if (indice == 0) {
                if (getSize() == 1)
                {
                    produtos[0] = null;
                    totalVendidoDia = totalVendidoDia + produtos[indice].getValor();
                    contadorDeProdutos--;
                }

                else
                {

                    totalVendidoDia = totalVendidoDia + produtos[indice].getValor();
                    produtos[indice] = produtos[indice + 1];
                    produtos[indice + 1] = null;
                    contadorDeProdutos--;
                }
            }
            else if (indice <= getSize() && indice != 1) { 
            if (getSize() == 1)
            {
                produtos[0] = null;
                totalVendidoDia = totalVendidoDia + produtos[indice].getValor();
                    contadorDeProdutos--;
                }

                else
                {
                    for (int i = indice-1;i<getSize();i++) {
                            if(produtos[indice+1] != null)
                        {
                            
                             totalVendidoDia = totalVendidoDia + produtos[indice-1].getValor();
                            produtos[indice - 1] = produtos[indice + 1];
                            produtos[indice + 1] = null;
                            contadorDeProdutos--;

                        }
                            else
                        {
                            totalVendidoDia = totalVendidoDia + produtos[indice - 1].getValor();
                            produtos[indice] = null;
                            contadorDeProdutos--;
                        }
                    }
                }
        }

            return false; 


         
        }

        public static int getQuantidadeVendida() {
            return quantidadeDeProdutos;
        }

        public static double Venda(string codigoProduto, int quantidadeVendida) {
            double valorProduto;

            int indice = buscarProduto(codigoProduto);
            quantidadeDeProdutos = quantidadeDeProdutos +quantidadeVendida;

            valorProduto = produtos[indice].getValor() * quantidadeVendida;
            valorDaVenda = valorProduto;
            totalVendidoDia = totalVendidoDia + valorProduto;
            Produto prod = getProduto(indice);
            adicionarRelatorio(prod, quantidadeVendida, produtos[indice].getValor());
            return valorProduto;
                         
        }

        public static double getValorDaVenda()
        {
            return valorDaVenda;
        }

        public static double totalVendidoNoDia()
        {
            return totalVendidoDia;
        }

        public static void adicionarRelatorio(Produto prod, int qtd, double valor) {
            RelatorioVendas rel = new RelatorioVendas(prod, qtd, valor);
            listaRelatorio.Add(rel);

        }

        public static void getRelatorio()
        {
            foreach (RelatorioVendas rl in listaRelatorio) 
                     Console.WriteLine("Codigo do produto : "+rl.getProduto().getCodigo() +"\n"+"Nome do produto: "+ rl.getProduto().getNome()+"\n"+"Valor do produto: "+rl.getProduto().getValor()
                        +"\n" +"Total vendido no dia: "+totalVendidoNoDia()+"\n"+"Quantidade vendida: "+getQuantidadeVendida());

            

        }

        public static void getRelatorioVendas()
        {
            foreach (RelatorioVendas rl in listaRelatorio)
                Console.WriteLine("Codigo do produto : " + rl.getProduto().getCodigo() + "\n" + "Nome do produto: " + rl.getProduto().getNome() + "\n" + "Valor do produto: " + rl.getProduto().getValor()
                   + "\n" + "Quantidade vendida: " + getQuantidadeVendida());



        }




    }
}



