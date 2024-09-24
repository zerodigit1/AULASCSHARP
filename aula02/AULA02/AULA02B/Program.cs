using AULA02B.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA02B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.Nome = "Fonts";
            pf.Cpf = "123456789";

            PessoaJuridica pj  = new PessoaJuridica();
            pj.Nome = "FONTS LTDA";
            pj.Cnpj = "23.345.678/001-00";

            ValdiarPessoa(new Cachorro());
            Console.ReadLine();


        }//main
        static void ValdiarPessoa(Pessoa p)
        {
            if (p is PessoaFisica)
            {
                PessoaFisica pf = (PessoaFisica)p;
                Console.WriteLine(pf.Cpf);
            }
            else if (p is PessoaJuridica)
            {
                 PessoaJuridica pj = (PessoaJuridica)p;
                Console.WriteLine(pj.Cnpj);
            }
            else
            {
                Console.WriteLine(" Tipo Invalido");
            }
        }
    }//program
}//namespace
