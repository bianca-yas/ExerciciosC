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
                              "\n2. Média de três notas");

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
                    default:
                        Console.WriteLine("Opção escolhida não é válida!");
                        break;
                }//fim do escolha
            } while (opcao != 0);
        }//fim do método
    }//fim da classe
}//fim do projeto
