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
        }//fim do primos

        public string exercicio11(int num1,int num2)
        {
            int soma = 0;
            int multi = 0;
            soma = num1 + num2;
            multi = soma * num1;

            return "O resultado é: "+multi;

        }//fim do exercicio 11

        public string medias(int val1,int val2,int val3)
        {
            double media = 0;
            media = (val1 + val2 + val3) / 3;

            return "A média é: "+media;
        }//fim do medias

        public string porcentagem(int num)
        {
            double porcentagem = 0;

            porcentagem = (num * 15) / 100;
            return "15% do número é igual a: " + porcentagem;
        }//fim da porcentagem

        public string porcentagem2(int num)
        {
            double result1 = 0;
            double result2 = 0;

            result1 = (num * 5) / 100;
            result2 = (num * 50) / 100;

            return "O resultado de 5%: " + result1 + "\nO resultado de 50%: " + result2;
        }//fim da porcentagem2

        public string quadrado(int num1,int num2)
        {
            double quad1 = 0;
            double quad2 = 0;
            double soma = 0;

            quad1 = num1 * num1;
            quad2 = num2 * num2;

            soma = quad1+ quad2;
            return "A soma dos quadrados dos números é: " + soma;
        }//fim do quadrado

        public string velocidade(int vel1)
        {
            double resultado = 0;
            resultado = vel1 * 3.6;

            return "A velocidade em Km/h é de: " + resultado;
        }//fim da velocidade

        public string imc(double peso,double altura)
        {
            double imc = 0;

            imc = peso / (altura * altura);
            return "O IMC do usuário é: " + imc;
        }//fim do imc

        public string desconto(double valor)
        {
            double desconto = 0;
            desconto = (valor * 9)/100;

            return "O desconto do valor será de: " + desconto;
        }//fim do desconto

        public string desconto2(double valor)
        {
            double desconto = 0;
            double valorDesconto = 0;

            desconto = (valor * 7)/100;
            valorDesconto = valor - desconto;

            return "Valor inicial: " + valor + "\nValor do desconto: " + desconto + "\nValor final com desconto: " + valorDesconto;
        }//fim do desconto2

        public string volume(double comprimento,double largura,double altura)
        {
            double volume = 0;
            volume = comprimento * largura * altura;

            return "O volume da caixa é de: " + volume;
        }//fim do volume

        public string desconto3(double valor)
        {
            double desconto = 0;
            desconto = (valor * 27)/100;

            return "O desconto de 27% é de: " + desconto;
        }//fim do desconto3

        public string trapezio(int base1,int base2,double altura)
        {
            double area = 0;

            area = ((base1 + base2) * altura) / 2;
            return "A área do trapezio é de: " + area;
        }//fi do trapezio

        public string mediaPeso(double n1, double n2, double n3)
        {
            double media = 0;
            int peso1 = 2;
            int peso2 = 3;
            int peso3 = 5;

            media = ((n1 * peso1) + (n2 * peso2) + (n3 * peso3))/(peso1 + peso2 + peso3);

            return "A média final desse aluno é: " + media;
        }//fim da mediaPeso

        public string parcela(double valor)
        {
            double acrescimo = 0;
            double valorTotal = 0;
            double parcela = 0;

            acrescimo = (valor * 16)/100;
            valorTotal = valor + acrescimo;
            parcela = valorTotal / 10;

            return "O valor total da compra é de: " + valorTotal + "\nO valor de cada parcela será de: " + parcela;
        }//fim da parcela

        public string consumoMedio(double distancia, double litros)
        {
            double consumo = 0;

            consumo = distancia / litros;
            return "O consumo médio é de: " + consumo;
        }//fim do consumoMedio
  }//fim da classe
}//fim do projeto
