//Nome:João Herval Maia
//Data:05/11/2021
//Exercício 1: lendo o valor de dois vetores e criando e imprimindo um conjunto C ordenado com os elementos comuns entre A e B
using System;

namespace Exercicio1
{
    class Program
    {
        //declarando um método chamado valorvetores, com um vetor int chamado vet como parâmetro
        static void valorvetores(int[] vet)
        {
            //declarando uma variável de número aleatório
         Random numaleatorio = new Random();
            //dando os valores da variável dos números aleatórios para o vetor vet  
        for (int u = 0; u < vet.Length; u++)
         {
                //dando aos números da posição u no vetor vet os valores do numaleatorio que vão de 1 a 100
             vet[u] = numaleatorio.Next(1, 100);
         }
        }
        //declarando um método chamado vetorordem, com um vetor int chamado vetor e uma variável booleana chamada ordenado como parâmetro
        static void vetorordem(int[] vetor, bool ordenado)
        {
            //fazendo com que a checagem para ordenar o vetor chamado vetor ocorra várias vezes
            for (int z = 0; z < vetor.Length - 1; z++)
            {
                for (int c = 0; c < vetor.Length - 1; c++)
                {
                    //checando se a variável ordenado e igual a true e ordenando o vetor chamado vetor se esse for o caso
                    if (ordenado == true)
                    {
                        if (vetor[c] > vetor[c + 1])
                        {
                            int numero = vetor[c];
                            vetor[c] = vetor[c + 1];
                            vetor[c + 1] = numero;
                        }
                    }
                    else
                    {
                        //checando os números do vetor para ordena-los corretamente
                        if (vetor[c] < vetor[c + 1])
                        {
                            int numero = vetor[c];
                            vetor[c] = vetor[c + 1];
                            vetor[c + 1] = numero;
                        }
                    }
                }
            }
            //checando se a variável ordenado e igual a true
            if (ordenado == true)
            {
                //imprimindo os números de vetor em ordem crescente
                Console.WriteLine("Os números do vetor em ordem crescente são");
                for (int d = 0; d < vetor.Length; d++)
                {
                    Console.WriteLine(vetor[d]);
                }
            }
            else
            {
                //imprimindo os números de vetor em ordem decrescente
                Console.WriteLine("Os númers do vetor em ordem decrescente são");
                for (int h = 0; h < vetor.Length; h++)
                {
                    Console.WriteLine(vetor[h]);
                }
            }
        }
        public static void Main(string[] args)
        {
            //dando valor à variável numa
            Console.WriteLine("Qual é a quantidade de números do vetor A?");
            int numa = int.Parse(Console.ReadLine());
            //fazendo com que a variável numa não seja maior que 100
            if (numa >= 100)
            {
                numa = 99;
            }
            int[] vetorA = new int[numa];
            //chamando o método valorvetores, com a variável vetorA como parâmetro
            valorvetores(vetorA);
            //dando valor à variável numb
            Console.WriteLine("Qual é a quantidade de números do vetor B?");
            int numb = int.Parse(Console.ReadLine());
            //fazendo com que a variável numb não seja maior que 100
            if (numb >= 100)
            {
                numb = 99;
            }
            int[] VetorB = new int[numb];
            //chamando o método valorvetores, com a variável vetorB como parâmetro
            valorvetores(VetorB);
            //declarando e dando valor a um vetor int chamado VetorC
            int[] VetorC = new int[numa + numb];
            //declarando uma variavel int chamada i 
            int i = 0;
            //fazendo com que as checagens a seguir sejam feitas com todos os elementos do VetorC
            for (int v = 0; v < VetorC.Length; v++)
            {
                //checando se o número na posição atual de v é menor do que os numeros no vetorA
                if (v < vetorA.Length)
                {
                    //igualando o número na posição atual de v do VetorC ao do vetorA
                    VetorC[v] = vetorA[v];
                }
                else
                {
                    //igualando o número na posição atual de v do VetorC ao do VetorB
                    VetorC[v] = VetorB[i];
                    //aumentando por 1 a variável i
                    i++;
                }
            }
            //declarando e dando valor à variável crescente
            bool crescente = true;
            //declarando e dando valor a uma variável num
            Console.WriteLine("Digite 0 para ordem crescente e 1 para ordem decrescente");
            int num = int.Parse(Console.ReadLine());
            //vendo se num é menor ou igual a 0
            if (num <= 0)
            {
                //igualando a variavel num a 0 e dando valor à variavel crescente se esse for o caso
                num = 0;
                crescente = true;
            }
            //vendo se num é menor ou igual a 1
            else if (num >= 1)
            {
                //igualando a variavel num a 1 e dando valor à variavel crescente se esse for o caso
                num = 1;
                crescente = false;
            }
            //chamando o método vetorordem com as variáveis VetorC e crescente como parâmetro
            vetorordem(VetorC, crescente);
        }
    }
}
