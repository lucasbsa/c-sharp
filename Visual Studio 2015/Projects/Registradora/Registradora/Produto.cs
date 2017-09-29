using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registradora
{
    class Produto
    {
        private string codigo;
        private double valor;
        private string nome;

        public Produto(string codigo, string nome, double valor){
            this.codigo = codigo;
            this.nome = nome;
            this.valor = valor;
        }


        public string getNome() { return nome; }

        public string getCodigo() { return codigo; }

        public double getValor() { return valor; }

        public void setValor(double valor) { this.valor = valor; }

        public void setNome(string nome) { this.nome = nome; }

        public void setCodigo(string codigo) { this.codigo = codigo; }


    }
}
