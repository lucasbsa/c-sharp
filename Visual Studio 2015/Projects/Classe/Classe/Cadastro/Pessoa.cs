using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Classe.Interface;
namespace Classe.Cadastro
{
    class Pessoa : IPessoa
    {
        #region Atributos
        private string nome, idade, dataNascimento;
        private int quantidadePessoas;
        #endregion

        #region Construtores
        public Pessoa() { }

        public Pessoa(string nome, string dataNascimento) {
            this.nome = nome;
            this.dataNascimento = dataNascimento;

        }

        public Pessoa(int qtd)
        {
            quantidadePessoas = qtd;
        }
        #endregion

        #region Gets/Sets
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Idade
        {
            get { return idade; }
        }

        public string DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }

           
        }

       

        public void calcularIdade(string dataNascimento)
        {
            throw new NotImplementedException();
        }

        public int QuantidadePessoas
        {
            get { return quantidadePessoas; }
        }
        #endregion
        /*Crie um método que irá adicionar pessoas no carro. Esse método terá as
seguintes características:
- Ele deverá receber por parâmetro o número de pessoas entrarão no carro. Esse
número não precisa encher o carro, você poderá acrescentar as pessoas aos
poucos.
- O método deve retornar a frase: "Já temos [X] pessoas no carro!"
- Se o carro já estiver cheio, com todos os assentos já preenchidos, o método
deve retornar a frase: "O carro já está lotado!"
- Se ainda houverem lugares no carro, mas a quantidade de pessoas passadas por
parâmetro for ultrapassar o limite de assentos do carro, então você deve
mostrar quantos assentos ainda podem ser ocupados, com a frase:
"Só cabem mais [QUANTIDADE_DE_PESSOAS_QUE_CABEM] pessoas!"
- Se couber somente mais uma pessoa, mostrar a palavra "pessoa" no retorno
citado acima, no lugar de "pessoas". */
        public string addPessoas(int x) {
            int y = QuantidadePessoas;
            int qtdAssentosDisponiveis = y;


            if (qtdAssentosDisponiveis == 0)
            {
                return "O carro já está lotado";
            }

            else if (qtdAssentosDisponiveis < x) {
                return "Número de pessoas maior do que assentos disponiveis!\n " + " há apenas "+qtdAssentosDisponiveis+" disponiveis";
            }


            qtdAssentosDisponiveis = qtdAssentosDisponiveis - x;  
            return " Já temos  "+x+" no carro";
        }







    }
}
