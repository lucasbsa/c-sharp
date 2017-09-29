using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUsuario
{
    public class CadastroDeUsuario
    {
        private String nomeDoUsuario, senha;

       public CadastroDeUsuario(String nome , String senha) {
            this.nomeDoUsuario = nome;
            this.senha = senha;
        }
         public string getSenha() { return senha; }
         public void setSenha(string senha) { this.senha = senha; }
         public String getNomeDoUsuario() { return nomeDoUsuario; }
         public  void setNomeDoUsuario(String nome) { this.nomeDoUsuario = nome; }



    }
}
