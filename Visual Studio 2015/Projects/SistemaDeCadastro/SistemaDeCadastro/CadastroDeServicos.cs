using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeCadastro
{
    class CadastroDeServicos
    {
        private String login, nomeServico, senhaServico;

        public CadastroDeServicos(String login, String nomeServico, String senhaServico) {
            this.login = login;
            this.nomeServico = nomeServico;
            this.senhaServico = senhaServico;
        }

        public void setLogin(String login) {
            this.login = login;
        }

        public void setNomeServico(String nomeServico)
        {
            this.nomeServico = nomeServico;
        }

        public void setSenhaServico(String senhaServico)
        {
            this.senhaServico = senhaServico;
        }

        public String getLogin()
        {
            return login;
        }

        public String getNomeServico() {
            return nomeServico;

        }

        public String getSenhaServico()
        {
            return senhaServico;
        }


    }
}
