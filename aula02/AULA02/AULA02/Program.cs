using AULA02.Enuns;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 10, n2 = 10, n3 = 10;
            double media = (n1+ n2 + n3)/3;
            SituacaoAluno situacao;

            if (media>=7) {situacao = SituacaoAluno.Aprovado;}
            else if (media >= 5) { situacao = SituacaoAluno.Recuperacao; }
            else {situacao = SituacaoAluno.Reprovado;}

            Console.WriteLine(situacao);

            foreach(Level level in Enum.GetValues(typeof(Level)))
            {
                
                Console.WriteLine($"{level} - {Convert.ToInt32(level)} - {level.GetHashCode()} - {(int)level}");

            }

            SituacaoAluno sitalu;
            bool tryParse= Enum.TryParse("Active",out sitalu);
            Console.WriteLine($"Try 1 : {tryParse}");
            tryParse = Enum.TryParse("recuperacao", out sitalu);
            Console.WriteLine($"Try 2 : {tryParse}");
            tryParse = Enum.TryParse("Aprovado", out sitalu);
            Console.WriteLine($"Try 3 : {tryParse}   {sitalu}");
            //sitalu = (SituacaoAluno)Enum.Parse(typeof(SituacaoAluno), "Test");
            //Console.WriteLine($"Try 4 :   {sitalu}");  
            Console.ReadLine();
        }//main
    }//program
}//namespace
