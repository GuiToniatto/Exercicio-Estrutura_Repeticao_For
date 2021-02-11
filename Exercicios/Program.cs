using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;

            Console.WriteLine("Seja bem vindo à lista de exercícios de estruturas condicionais. A seguir será fornecido o tópico dos 8 exercícios onde você poderá escolher um deles para testar.");

            while (continuar != 0)
            {
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("Exercício 1 - Valores ímpares.");
                Console.WriteLine("Exercício 2 - Valores dentro de um intervalo.");
                Console.WriteLine("Exercício 3 - Preferência de combustível.");
                Console.WriteLine("Exercício 4 - Dvisão de 2 números.");
                Console.WriteLine("Exercício 5 - Fatorial de um número.");
                Console.WriteLine("Exercício 6 - Divisores de um número.");
                Console.WriteLine("Exercício 7 - Quadrado e cubo de um valor.");
                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Escola a opção do exercício desejado (se desejar encerrar o programa digite qualquer outro número): ");
                int opcao = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                if (opcao == 1)
                {
                    Console.WriteLine("Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.");

                    Console.Write("Digite o valor de X = ");
                    int x = int.Parse(Console.ReadLine());

                    for(int i = 0; i <= x; i++)
                    {
                        if (i % 2 != 0)
                            Console.WriteLine(i);
                    }
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo[10, 20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo(use a palavra \"in\" para dentro do intervalo, e \"out\" para fora do intervalo).");

                    Console.Write("Digite quantos números deseja digitar = ");
                    int n1 = int.Parse(Console.ReadLine());

                    int inside = 0;
                    int outside = 0;

                    for(int i = 0; i < n1; i++)
                    {
                        Console.Write("Informe o número = ");
                        int valor = int.Parse(Console.ReadLine());

                        if (valor >= 10 && valor <= 20)
                            inside++;
                        else
                            outside++;
                    }

                    Console.WriteLine($"{inside} in");
                    Console.WriteLine($"{outside} out");
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal.Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.");

                    Console.Write("Digite quantos casos de teste deseja verificar = ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Informe os 3 números na mesma linha = ");
                        string[] temp = Console.ReadLine().Split(" ");
                        float n1 = float.Parse(temp[0]);
                        float n2 = float.Parse(temp[1]);
                        float n3 = float.Parse(temp[2]);

                        float total = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;

                        Console.WriteLine(total.ToString("F1"));
                    }
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo segundo. Se o denominador for igual a zero, mostrar a mensagem \"divisao impossivel\".");

                    Console.Write("Digite quantos casos de teste deseja verificar = ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Informe os 2 números na mesma linha = ");
                        string[] temp = Console.ReadLine().Split(" ");
                        float n1 = float.Parse(temp[0]);
                        float n2 = float.Parse(temp[1]);

                        if (n2 == 0)
                            Console.WriteLine("divisao impossivel");
                        else
                        {
                            float total = n1 / n2;
                            Console.WriteLine(total.ToString("F1"));
                        }

                    }
                }
                else if (opcao == 5)
                {
                    Console.WriteLine("Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1. Lembrando que, por definição, fatorial de 0 é 1.");

                    Console.Write("Digite o valor de N = ");
                    int n = int.Parse(Console.ReadLine());
                    int total = 1;

                    for (int i = 1; i <= n; i++)
                    {
                        total *= i;
                    }

                    Console.WriteLine(total);
                }
                else if (opcao == 6)
                {
                    Console.WriteLine("Ler um número inteiro N e calcular todos os seus divisores.");

                    Console.Write("Digite o valor de N = ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {
                        if (n % i == 0)
                            Console.WriteLine(i);
                    }
                }
                else if (opcao == 7)
                {
                    Console.WriteLine("Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, começando de 1 até N.Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme exemplo.");

                    Console.Write("Digite o valor de N = ");
                    int n = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
                    }
                }

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Write("Digite 1 caso queira verificar outro exercício ou 0 para encerrar: ");
                continuar = int.Parse(Console.ReadLine());

                Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

                Console.Clear();
            }
        }
    }
}
