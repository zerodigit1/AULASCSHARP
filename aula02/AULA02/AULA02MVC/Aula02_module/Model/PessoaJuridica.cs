using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_module.Model
{
    public class PessoaJuridica:Pessoa    
    {
        private string cnpj;
        public PessoaJuridica() { }
        public PessoaJuridica(string cnpj)
        {
            this.Cnpj = cnpj;
        }
        public string Cnpj { get { return cnpj; } set { cnpj = value; } }   
    }
}
