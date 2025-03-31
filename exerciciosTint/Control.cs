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
                              "\n12. Primos" +
                              "\n13. Soma, Multiplica"+
                              "\n14. Medias"+
                              "\n15. Porcentagem"+
                              "\n16. Porcentagem 2"+
                              "\n17. Quadrados"+
                              "\n18. Velocidade"+
                              "\n19. IMC"+
                              "\n20. Desconto 9%"+
                              "\n21. Desconto 7%"+
                              "\n22. Volume"+
                              "\n23. Desconto 27%"+
                              "\n24. Trapézio"+
                              "\n25. Média final"+
                              "\n26. Parcela" +
                              "\n27. Consumo Médio"+
                              "\n28. Média lista");

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
                    case 13:
                        Console.WriteLine("Digite um número");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite outro número");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        if((num1 < 0) || (num2 < 0))
                        {
                            Console.WriteLine("Informe um número positivo");
                        }

                        Console.WriteLine(this.exer.exercicio11(num1,num2));
                        break;
                    case 14:
                        Console.WriteLine("Digite a primeira nota");
                        int val1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite a segunda nota");
                        int val2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite a terceira nota");
                        int val3 = Convert.ToInt32(Console.ReadLine());

                        if((val1 < 0) || (val2 < 0) || (val3 < 0))
                        {
                            Console.WriteLine("Digite um número positivo");
                        }

                        Console.WriteLine(this.exer.medias(val1,val2,val3));
                        break;
                    case 15:
                        Console.WriteLine("Informe um número");
                        num = Convert.ToInt32(Console.ReadLine());
                        if(num <= 0)
                        {
                            Console.WriteLine("Digite um número maior que zero!");
                        }

                        Console.WriteLine(this.exer.porcentagem(num));
                        break;
                    case 16:
                        Console.WriteLine("Informe um número");
                         num = Convert.ToInt32((Console.ReadLine()));
                        if(num <= 0)
                        {
                            Console.WriteLine("´Digite um número maior que zero!");
                        }

                        Console.WriteLine(this.exer.porcentagem2(num));
                        break;
                    case 17:
                        Console.WriteLine("Digite um número");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número");
                        num2= Convert.ToInt32(Console.ReadLine());
                        if((num1 <= 0)||(num2 <= 0))
                        {
                            Console.WriteLine("Digite um número positivo");
                        }

                        Console.WriteLine(this.exer.quadrado(num1,num2));
                        break;
                    case 18:
                        Console.WriteLine("Digite a velocidade do objeto");
                        int vel1 = Convert.ToInt32(Console.ReadLine());
                        if(vel1 < 0)
                        {
                            Console.WriteLine("Digite um número válido");
                        }

                        Console.WriteLine(this.exer.velocidade(vel1));
                        break;
                    case 19:
                        Console.WriteLine("Digite seu peso");
                        double peso = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite sua altura");
                        double altura = Convert.ToDouble(Console.ReadLine());
                        if((peso <= 0) || (altura <= 0))
                        {
                            Console.WriteLine("Digite um peso ou altura válidos");
                        }

                        Console.WriteLine(this.exer.imc(peso,altura));
                        break;
                    case 20:
                        Console.WriteLine("Informe um valor");
                        double valor = Convert.ToDouble(Console.ReadLine());

                        if(valor <= 0)
                        {
                            Console.WriteLine("Digite um valor válido");
                        }

                        Console.WriteLine(this.exer.desconto(valor));
                        break;
                    case 21:
                        Console.WriteLine("Informe um valor");
                        valor = Convert.ToDouble(Console.ReadLine());
                        if(valor <= 0)
                        {
                            Console.WriteLine("Digite um valor válido");
                        }

                        Console.WriteLine(this.exer.desconto2(valor));
                        break;
                    case 22:
                        Console.WriteLine("Digite o comprimento da caixa");
                        double comprimento = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a largura da caixa");
                        double largura = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a altura da caixa");
                        altura = Convert.ToDouble(Console.ReadLine());

                        if((comprimento <= 0) || (largura <= 0) || (altura <= 0))
                        {
                            Console.WriteLine("Digite um número válido");
                        }

                        Console.WriteLine(this.exer.volume(comprimento,largura,altura));
                        break;
                    case 23:
                        Console.WriteLine("Digite um valor");
                        valor = Convert.ToDouble(Console.ReadLine());

                        if (valor <= 0)
                        {
                            Console.WriteLine("Digite um valor válido");
                        }

                        Console.WriteLine(this.exer.desconto3(valor));
                        break;
                    case 24:
                        Console.WriteLine("Informe o número da base 1");
                        int base1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o número da base 2");
                        int base2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a altura do trapézio");
                        altura = Convert.ToDouble(Console.ReadLine());

                        if((base1 <= 0) || (base2 <= 0) || (altura <= 0))
                        {
                            Console.WriteLine("Informe um número válido");
                        }

                        Console.WriteLine(this.exer.trapezio(base1,base2,altura));
                        break;
                    case 25:
                        Console.WriteLine("Informe a primeira nota");
                        double n1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a segunda nota");
                        double n2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a terceira nota");
                        double n3 = Convert.ToDouble(Console.ReadLine());

                        if((n1 < 0) || (n2 < 0) || (n3 < 0))
                        {
                            Console.WriteLine("Informe uma nota válida");
                        }

                        Console.WriteLine(this.exer.mediaPeso(n1,n2,n3));
                        break;

                    case 26:
                        Console.WriteLine("Informe o valor da compra");
                        valor = Convert.ToDouble(Console.ReadLine());

                        if(valor < 0)
                        {
                            Console.WriteLine("Informe um valor válido");
                        }

                        Console.WriteLine(this.exer.parcela(valor));
                        break;
                    case 27:
                        Console.WriteLine("Informe a distancia percorrida: ");
                        double distancia = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe os litros consumidos: ");
                        double litros = Convert.ToDouble(Console.ReadLine());

                        if((distancia <= 0) || (litros <= 0))
                        {
                            Console.WriteLine("Informe um valor válido");
                        }

                        Console.WriteLine(this.exer.consumoMedio(distancia,litros));
                        break;
                    case 28:
                        List<double> numeros = new List<double>();
                        string entrada;

                        Console.WriteLine("Informe os números (Digite 'sair' para sair)");
                        while (true)
                        {
                            Console.WriteLine("Digite um número");
                            entrada = Console.ReadLine();

                            if (entrada.ToLower() == "sair")
                                break;
                            
                            if(double.TryParse(entrada, out double numero))
                            {
                                numeros.Add(numero);
                            }
                            else
                            {
                                Console.WriteLine("Entrada Inválida.");
                            }
                        }

                        if(numeros.Count > 0)
                        {
                            double soma = 0;
                            foreach(double num4 in numeros)
                            {
                                soma += num4;
                            }
                            double media3 = soma / numeros.Count;
                            Console.WriteLine($"A média dos números digitados é: {media3:F2}");
                        }
                        else
                        {
                            Console.WriteLine("Nenhum número foi digitado");
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
