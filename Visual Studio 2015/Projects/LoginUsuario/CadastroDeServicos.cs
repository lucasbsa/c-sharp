using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUsuario
{
    class CadastroDeServicos
    {
        private String usuarioDoServico, senhaDoServico, nomeDoServico;

       public  CadastroDeServicos(String usuarioDoServico, string senhaDoServico, string nomeDoServico) {
            this.usuarioDoServico = usuarioDoServico;
            this.senhaDoServico = senhaDoServico;
            this.nomeDoServico = nomeDoServico;
        }

        void setUsuarioDoServico(String usuarioDoServico) { this.usuarioDoServico=usuarioDoServico; }

        void setSenhaDoServico(String senhaDoServico) { this.senhaDoServico = senhaDoServico; }

        void setNomeDoServico(String nomeDoServico) { this.nomeDoServico = nomeDoServico; }

        String getNomeDoServico() { return nomeDoServico; }

        String getUsuarioDoServico() { return usuarioDoServico; }

        String getSenhaDoServico() { return senhaDoServico; }
        
    }
}
