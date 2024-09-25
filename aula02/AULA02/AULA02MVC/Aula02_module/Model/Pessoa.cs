using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_module.Model
{
    public abstract class Pessoa
    {
        private string nome;
        //usar ctor + tab +tab para gerar o construtor automaticamente
        public Pessoa() { }
        public Pessoa(string nome)
        {
                this.Nome = nome;
        }
        public string Nome { get => nome; set => nome = value; }
    }
}
