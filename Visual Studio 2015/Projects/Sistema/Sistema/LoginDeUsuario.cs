using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    class CadastroLoginDeUsuario
    {

        public String usuario;
        public String senha;


        public CadastroLoginDeUsuario(String usuario, String senha) {
            this.usuario = usuario;
            this.senha = senha;
        }

        public String getUsuario()
        {
            return usuario;
        }

        public String getSenha() {
            return senha;
        }


        public void setUsuario(String usuario) {
            this.usuario = usuario;
        }

        public void setSenha(String senha) {
            this.senha = senha;
        }




        
    }
}
