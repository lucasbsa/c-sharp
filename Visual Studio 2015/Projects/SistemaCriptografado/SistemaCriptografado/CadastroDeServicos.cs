using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCriptografado
{
    class CadastroDeServicos
    {

        private String usuarioDoServico, senhaDoServico, nomeDoServico;

        public CadastroDeServicos(String usuarioDoServico, string senhaDoServico, string nomeDoServico)
        {
            this.usuarioDoServico = usuarioDoServico;
            this.senhaDoServico = senhaDoServico;
            this.nomeDoServico = nomeDoServico;
        }

        void setUsuarioDoServico(String usuarioDoServico) { this.usuarioDoServico = usuarioDoServico; }

        void setSenhaDoServico(String senhaDoServico) { this.senhaDoServico = senhaDoServico; }

        void setNomeDoServico(String nomeDoServico) { this.nomeDoServico = nomeDoServico; }

       public String getNomeDoServico() { return nomeDoServico; }

       public  String getUsuarioDoServico() { return usuarioDoServico; }

      public  String getSenhaDoServico() { return senhaDoServico; }

    }
}
