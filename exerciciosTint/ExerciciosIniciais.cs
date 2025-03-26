using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosTint
{
    public class ExerciciosIniciais
    {
        //Area de variavéis -> Globais
        private int num1;
        private int num2;

        public ExerciciosIniciais()
        {

        }//fim do construtor

        public ExerciciosIniciais(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }//fim do construtor

        //Métodos modificadores
        public int getNum1() { return this.num1; }
        public int getNum2() { return this.num2; }

        public void setNum1(int num1) { this.num1 = num1; }
        public void setNum2(int num2) { this.num2 = num2; }

        public string imprimir()
        {
            return "\nPrimeiro Número: " + getNum1() +
                   "\nSegundo Número: " + getNum2();
        }//fim do imprimir

        public double media(double nota1, double nota2, double nota3)
        {
            double med = 0;
            if ((nota1 >= 0 && nota1 <= 10)
              && (nota2 >= 0 && nota2 <= 10)
              && (nota3 >= 0 && nota3 <= 10))
            {
                med = (nota1 + nota2 + nota3) / 3;
                return med;
            }//fim do if
            return -1;
        }

        public string verificador(int num)
        {
            if (num < 0)
            {
                return "Esse número é negativo.\n";
            } else if (num > 0)
            {
                return "Esse número é positivo.\n";
            }
            else
            {
                return "Esse número é Zero.\n";
            }
        } //fim do verificador

        public string tabuada(int num)
        {
            string resultado = "";

            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + (num) + " * " + (i) + " = " + (num * i);
            }
            return resultado;
        } //fim da tabuada

        public int fatorial(int num)
        {
            for (int i = num - 1; i >= 1; i--)
            {
                num *= i;
            }
            return num;
        }//fim do fatorial

        public double potencia(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }//fim da potencia

        public double raiz(double num1, double num2)
        {
            return Math.Sqrt(num1) + Math.Sqrt(num2);
        }//fim da raiz

        public string imparPar(int num)
        {
            string resultado = "";
            if (num / 2 == 0)
            {
                resultado = "Esse número é par";
            }
            else
            {
                resultado = "Esse número é ímpar";
            }
            return resultado;
        }//fim do impar par

        public string ordemC(int num1, int num2)
        {
            string ordem = "";
            if (num1 > num2)
            {
                ordem = "A ordem dos números é: " + num1 + "\n" + num2;
            } else if (num2 > num1)
            {
                ordem = "A ordem dos números é: " + num2 + "\n" + num1;
            }
            return ordem;
        }


        public string vogaisContar(string vogais)
        {
            vogais = vogais.ToLower();
            int contarVogais = 0;
            string vogal = "aeiou";

            foreach(char c in vogais)
            {
                if (vogal.Contains(c))
                {
                    contarVogais++;
                }
            }
            return "Essa palavra tem " + contarVogais + " vogais";
        }

        public string inverter(string palavra)
        {
            char[] caracteres = palavra.ToCharArray();

            Array.Reverse(caracteres);
            string invertida = new string(caracteres);
            return invertida;
        }

        public string primos(int num)
        {
            if(num <= 1)
            {
                return "Não é primo";
            }
            for(int i = 2; i <= Math.Sqrt(num);i++)
            {
                if(num % i == 0)
                {
                    return "Não é primo";
                }
            }
            return "É primo";
        }
  }//fim da classe
}//fim do projeto
