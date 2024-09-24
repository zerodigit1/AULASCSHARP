using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aula01.Suportes;

namespace aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Caneta.Escreve(" Este Console Ta Possuido ");
            int num1 = 5;
            int num2 = 15;
            Matematica aMat = new Matematica(num1, num2);
            Console.WriteLine(aMat);
            aMat.setA(40);
            aMat.setB(20);
            Console.WriteLine(aMat);

            //Console.WriteLine($"SOMA: {soma} SUBTRACAO: {subtracao}");
            //Console.WriteLine($"MULTIPLICACAO: {multiplicacao} DIVISAO: {divisao}");
            //Console.WriteLine("Press <ENTER> to Exit");


            //int soma = num1 + num2;
            //Caneta.Escreve(soma.ToString());
            //string v1 = Console.ReadLine();
            //string v2 = Console.ReadLine();
            //soma = int.Parse(v1) + int.Parse(v2);
            // Caneta.Escreve($"Soma de {v1} e {v2} eh igual = "+soma);
            // Estruturas de Decisao
            // Estruturas de repeticao
            //for (int i = 1;i <=10;i++)
            //{
            //    Console.WriteLine(i.ToString());
            //}
            Console.ReadLine();

        }
    }
}
