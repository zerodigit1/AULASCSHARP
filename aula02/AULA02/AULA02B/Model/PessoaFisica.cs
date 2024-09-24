using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA02B.Model
{
    public class PessoaFisica:Pessoa
    {
        private string cpf;
        public PessoaFisica() { }
        public PessoaFisica(string cpf)
        {
            this.Cpf = cpf;
        }
        public string Cpf {  get { return cpf; } set { cpf = value; } }
    }
}
