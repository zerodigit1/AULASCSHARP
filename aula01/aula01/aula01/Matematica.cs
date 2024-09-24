using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula01
{
    public class Matematica
    {
        private double a, b;
        public double rsoma { get; set; }
        public double rsubt { get; set; }
        public double rmult { get; set; }
        public double rdivi { get; set; }
        
        public string WriteSoma
        { get { return $"Soma a = {this.a} e b = {this.b} = {this.Soma()}"; } }

        public string WriteSubtracao
        { get { return $"Subtracao a = {this.a} e b = {this.b} = {this.Subtracao()}"; } }

        public string WriteDivisao
        { get { return $"Divisao a = {this.a} e b = {this.b} = {this.Divisao()}"; } }

        public string WriteMultiplicacao
        { get { return $"Multiplicacao a = {this.a} e b = {this.b} = {this.Multiplicacao()}"; } }

        public Matematica()
        {
            this.a = 1;
            this.b = 1;
        }
        public Matematica(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double getA()
        {
            return this.a;
        }
        public void setA(double a)
        {
            this.a = a;
        }
        public double getB()
        {
            return this.b;
        }
        public void setB(double b)
        {
            this.b = b;
        }
        public double Soma()
        {
            this.rsoma = a + b;
            return this.rsoma;
        }
        public double Multiplicacao()
        {
            this.rmult = a * b;
            return this.rmult;
        }

        public double Subtracao()
        {
            this.rsubt = a - b;
            return this.rsubt;
            
        }

        public double Divisao()
        {
            this.rdivi = a / b;
            return this.rdivi;
        }

        public override string ToString()
        {
            return WriteSoma + Environment.NewLine + WriteSubtracao + Environment.NewLine + WriteMultiplicacao + Environment.NewLine + WriteDivisao;

        }

    }// Class Matematica
}// Namespace Aula01
