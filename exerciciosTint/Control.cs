using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosTint
{
    public class Control
    {
        ExerciciosIniciais exer;

        public Control() 
        {
            this.exer = new ExerciciosIniciais();
        }//fim do construtor

        public void mostrarMenu()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: " +
                              "\n0. Sair" +
                              "\n1. Mostrar Números" +
                              "\n2. Média de três notas" +
                              "\n3. Verificador" +
                              "\n4. Tabuada" +
                              "\n5. Fatorial" +
                              "\n6. Potencia" +
                              "\n7. Raiz" +
                              "\n8. Ímpar ou Par" +
                              "\n9. Ordem Crescente" +
                              "\n10. Contar Vogais" +
                              "\n11. Inverter Palavra" +
                              "\n12. Primos");

        }//fim do método

        public void menu()
        {
            int opcao = 0;
            do
            {
                mostrarMenu(); //Mostrar as opções oara o usuário
                opcao = Convert.ToInt32(Console.ReadLine());

                //Escolha
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("\n\n\nObrigado!");
                        break;
                    case 1:
                        Console.WriteLine("Informe um número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe outro número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        ExerciciosIniciais exer = new ExerciciosIniciais(num1, num2);                        //Utilizando - criando o objeto exer
                        Console.WriteLine(exer.imprimir());
                        break;
                    case 2:
                        Console.WriteLine("Informe uma nota entre 0 e 10: ");
                        double nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe uma nota entre 0 e 10: ");
                        double nota2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe uma nota entre 0 e 10: ");
                        double nota3 = Convert.ToDouble(Console.ReadLine());

                        //Executar

                        double media = this.exer.media(nota1, nota2, nota3);
                        if (media == -1)
                        {
                            Console.WriteLine("Uma ou mais notas estão erradas! Digite novamente.");
                        }
                        else
                        {
                            Console.WriteLine("\n\nA média é: " + media);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.verificador(num));
                        break;
                    case 4:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        if(num < 0)
                        {
                            Console.WriteLine("Erro! Digite um número positivo");
                        }
                        Console.WriteLine(this.exer.tabuada(num));
                        break;
                    case 5:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        if(num < 0)
                        {
                            Console.WriteLine("Informe um número positivo");
                        }
                        Console.WriteLine(this.exer.fatorial(num));
                        break;
                    case 6:
                        Console.WriteLine("Informe um número: ");
                        num1 = (int)Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o número que vai ser elevado: ");
                        num2 = (int)Convert.ToDouble(Console.ReadLine());
                        if((num1 <= 0) || (num2 <= 0))
                        {
                            Console.WriteLine("Erro! Digite um número positivo.");
                        }
                        Console.WriteLine(this.exer.potencia(num1,num2));
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        num1 = (int)Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe o segundo número: ");
                        num2 = (int)Convert.ToDouble(Console.ReadLine());
                        if((num1 <= 0) || (num2 <= 0))
                        {
                            Console.WriteLine("Informe um número positivo");
                        }
                        Console.WriteLine(this.exer.raiz(num1,num2));
                        break;
                    case 8:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        if(num <= 0)
                        {
                            Console.WriteLine("Informe um número positivo");
                        }
                        Console.WriteLine(this.exer.imparPar(num));
                        break;
                    case 9:
                        Console.WriteLine("Informe um número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe o segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                           
                        Console.WriteLine(this.exer.ordemC(num1,num2));
                        break;
                    case 10:
                        Console.WriteLine("Escreva um texto: ");
                        string vogais = Console.ReadLine();

                        Console.WriteLine(this.exer.vogaisContar(vogais));
                        break;
                    case 11:
                        Console.WriteLine("Escreva um texto");
                        string palavra = Console.ReadLine();

                        Console.WriteLine(this.exer.inverter(palavra));
                        break;
                    case 12:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(this.exer.primos(num));
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do escolha
            } while (opcao != 0);
        }//fim do método
    }//fim da classe
}//fim do projeto
