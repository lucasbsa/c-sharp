using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registradora
/*
Alterar o programa desenvolvido no exercício 1 de maneira que ao final do dia,
além do total vendido, o caixa possa gerar um relatório com todas as vendas 
do dia detalhando, para cada venda, o código do produto, sua descrição, o valor unitário,
a quantidade vendida e o total da venda.    

*/

{
    class RelatorioVendas
    {
        private Produto produto;
        private int quantidadeVendida;
        private  double totalDaVenda;
     

        public RelatorioVendas(Produto produto, int quantidadeVendida, double totalDaVenda ) {
            this.produto = produto;
            this.quantidadeVendida = quantidadeVendida;
            this.totalDaVenda = totalDaVenda;
        }

        public  Produto getProduto() {
            return produto;
        }

        public int getQuantidadeVend() { return quantidadeVendida; }

        public double getTotalDaVenda() { return totalDaVenda; }





    }
}
