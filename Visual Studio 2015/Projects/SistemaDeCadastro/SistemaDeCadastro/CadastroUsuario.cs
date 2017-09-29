using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastro
{
    class CadastroUsuario
    {
        public String login, senha;

        public CadastroUsuario(String login, String senha) {
            setSenha(senha);
            setLogin(login);
        }

        public void setLogin(String login) {
            this.login = login;
        }

        public void setSenha(String senha)
        {
            this.senha = senha;
        }

        public String getLogin() {
            return login;
        }

        public String getSenha() {
            return senha;
        }
    }
}
